using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Diagnostics; // Stopwatch
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

// including the M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTClient
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        int run;
        decimal time = 0;
        string time_now = "";
        MqttClient client;
        bool Repeat = false;
        bool Trigger = false;
        string save_location;
        Stopwatch watch = new Stopwatch();
        StringBuilder val = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { client.Disconnect(); }
            catch { }
        }
        
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (!Trigger)
                val.Clear();
            val.Append("\n");        
            val.Append(Encoding.UTF8.GetString(e.Message));
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            client = new MqttClient(broker_textBox.Text);
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            try
            {
                client.Connect(clientid_textBox.Text, user_textBox.Text, password_textBox.Text);
                if (topic_textBox.Text != "")
                {
                    string Topic = topic_textBox.Text;
                    // subscribe to the topic with QoS 0 ( 0, 1, 2 )
                    client.Subscribe(new string[] { Topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
                    time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    log_textBox.Text += $"Subscribe start @{time_now}\r\n";
                }
                else
                    MessageBox.Show("Subscribe topic is required.");
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void save_ButtonClick(object sender, EventArgs e)
        {
            Repeat = !int.TryParse(run_comboBox.Text, out run);
            save_location = path_Label.Text;
            time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            log_textBox.Text += $"Record start @{time_now}\r\n";
            record();
            save_Button.Enabled = false;
            stop_Button.Visible = true;
            
        }

        private void reset()
        {
            val.Clear();
            //watch.Stop();
            //MessageBox.Show(watch.Elapsed.TotalSeconds.ToString());
            if (!Repeat) {
                run--;

                if (run <= 0)
                {
                    Trigger = false;
                    save_Button.Enabled = true;
                    stop_Button.Visible = false;

                    time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    log_textBox.Text += $"Record end @{time_now}\r\n";
                    return;
                }
                else
                    record();
                time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                log_textBox.Text += $"Record left {run} times @{time_now}\r\n";
            }
            else
            {
                time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                log_textBox.Text += $"Continuous record @{time_now}\r\n";
                record();
            }
        }
        private async void record()
        {
            Trigger = true;
            val.Clear();
            time = time_Box.Value *1000;
            string record_time = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            //watch.Reset();
            //watch.Start();
            await Task.Delay(Convert.ToInt32(time));
            using (var stream = new FileStream(
                $"{save_location}\\{record_time}.csv", FileMode.Create, FileAccess.Write, FileShare.Write, 4096, useAsync:true))
                {
                    var bytes = Encoding.UTF8.GetBytes(val.ToString());
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                }
            reset();
        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            Repeat = false;
            run = 0;
            time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            log_textBox.Text += $"Force stop @{time_now}\r\n";
            reset();
        }

        private void exit_ButtonClick(object sender, EventArgs e)
        {
            client.Disconnect();
            Application.Exit();
        }

        private void folder_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path_Label.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                save_location = dialog.FileName;
            }
            path_Label.Text = save_location;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // Stopwatch
using System.Drawing;
using System.Linq;
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
        MqttClient client;
        bool Trigger = false;
        decimal time = 0;
        bool Repeat = false;
        int run;
        string save_location;
        StringBuilder val = new StringBuilder();
        Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new MqttClient(broker_textBox.Text);
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            client.Connect(clientid_textBox.Text, user_textBox.Text, password_textBox.Text);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }
        
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            if (!Trigger)
                val.Clear();
            val.Append("\n");        
            val.Append(Encoding.UTF8.GetString(e.Message));
            //SetText(val.ToString());
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (topic_textBox.Text != "")
            {
                string Topic = topic_textBox.Text;
                // subscribe to the topic with QoS 0 ( 0, 1, 2 )
                client.Subscribe(new string[] { Topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
                SetText("");
            }
            else
                MessageBox.Show("Subscribe topic is required.");
        }


        private void SetText(String text)
        {
            // we need this construction because the receiving code in the library and the UI with textbox run on different threads
            if (this.RecText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                this.RecText.Text = text;
        }

        private void save_ButtonClick(object sender, EventArgs e)
        {
            Repeat = !int.TryParse(run_comboBox.Text, out run);
            /*
            if (Repeat)
                MessageBox.Show("Repeat");
            else
                MessageBox.Show(run.ToString());
            */
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                save_location = dialog.FileName;
            }
            record();
            save_Button.Enabled = false;
            stop_Button.Visible = true;
        }
        
        private async void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                string time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                //File.WriteAllText($"{save_location}\\{time_now}.csv", val.ToString());
                using (var stream = new FileStream(
                    $"{save_location}\\{time_now}.csv", FileMode.Create, FileAccess.Write, FileShare.Write, 4096, useAsync:true))
                {
                    var bytes = Encoding.UTF8.GetBytes(val.ToString());
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                }
                //watch.Stop();
                //MessageBox.Show(watch.Elapsed.TotalSeconds.ToString());
                reset();
            }
        }
        private void reset()
        {
            val.Clear();
            timer1.Stop();
            
            if (!Repeat) {
                run--;

                if (run <= 0)
                {
                    Trigger = false;
                    save_Button.Enabled = true;
                    stop_Button.Visible = false;
                    timer1.Dispose();
                }
                else
                    record();
            }
            else
                record();
        }
        private void record()
        {
            Trigger = true;
            val.Clear();
            time = time_Box.Value *10;
            timer1.Start();
            //watch.Reset();
            //watch.Start();

        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            Repeat = false;
            run = 0;
            reset();
        }
    }
}

﻿using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
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
        MqttClient client;
        StringBuilder val = new StringBuilder();
        Topic topic1;
        Topic topic2;
        Topic topic3;
        Topic topic4;

        public Form1()
        {
            InitializeComponent();
        }
        
        public void Button_Visible(short group)
        {
            if (group == 1)
            {
                save_Button.Visible = !save_Button.Visible;
                stop_Button.Visible = !save_Button.Visible;
            }else if(group == 2)
            {
                save_Button_2.Visible = !save_Button_2.Visible;
                stop_Button_2.Visible = !save_Button_2.Visible;
            }
            else if (group == 3)
            {
                save_Button_3.Visible = !save_Button_3.Visible;
                stop_Button_3.Visible = !save_Button_3.Visible;
            }
            else if (group == 4)
            {
                save_Button_4.Visible = !save_Button_4.Visible;
                stop_Button_4.Visible = !save_Button_4.Visible;
            }

        }
        public void Log_Text(short group,string str)
        {
            string time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            if(group==1)
                log_textBox.AppendText($"{str} @{time_now}\r\n");
            else if(group==2)
                log_textBox_2.AppendText($"{str} @{time_now}\r\n");
            else if (group == 3)
                log_textBox_3.AppendText($"{str} @{time_now}\r\n");
            else if (group == 4)
                log_textBox_4.AppendText($"{str} @{time_now}\r\n");
        }

        private void Save_Button_Func(Topic topic_)
        {
            topic_.Subscribe();
            client.MqttMsgPublishReceived += topic_.Client_MqttMsgPublishReceived;
            topic_.Save();
        }
        private void Stop_Button_Func(Topic topic_)
        {
            topic_.Repeat = false;
            topic_.run = -1;
            Log_Text(topic_.group, $"Force stop ");
            topic_.reset();
            topic_.Unsubscribe();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                client.Disconnect();
                /*using (var stream = new FileStream(
                    $"{path_Label.Text}\\log_{time_now}.txt", FileMode.Create, FileAccess.Write, FileShare.Write, 4096, useAsync: true))
                {
                    var bytes = Encoding.UTF8.GetBytes(log_textBox.Text);
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                }*/
            }
            catch {
                //MessageBox.Show("Disconnect error.");
            }
        }

     // Group A           
        private void save_Button_Click(object sender, EventArgs e)
        {
            topic1 = new Topic(client, topic_textBox.Text, time_Box.Value, run_comboBox.Text, path_Label.Text, 1, this);
            Save_Button_Func(topic1);
        }
    
        private void stop_Button_Click(object sender, EventArgs e)
        {
            Stop_Button_Func(topic1);
        }

        private void folder_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path_Label.Text;//*****
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                path_Label.Text = dialog.FileName;   //*****
        }

    //  Group B
        private void save_Button_2_Click(object sender, EventArgs e)
        {
            topic2 = new Topic(client, topic_textBox_2.Text, time_Box_2.Value, run_comboBox_2.Text, path_Label_2.Text, 2, this);
            Save_Button_Func(topic2);
        }

        private void stop_Button_2_Click(object sender, EventArgs e)
        {
            Stop_Button_Func(topic2);
        }

        private void folder_Button_2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path_Label_2.Text;//*****
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                path_Label_2.Text = dialog.FileName;   //*****
        }

    //  Group C
        private void save_Button_3_Click(object sender, EventArgs e)
        {
            topic3 = new Topic(client, topic_textBox_3.Text, time_Box_3.Value, run_comboBox_3.Text, path_Label_3.Text, 3, this);
            Save_Button_Func(topic3);
        }

        private void stop_Button_3_Click(object sender, EventArgs e)
        {
            Stop_Button_Func(topic3);
        }

        private void folder_Button_3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path_Label_3.Text;//*****
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                path_Label_3.Text = dialog.FileName;   //*****
        }

    //  Group D
        private void save_Button_4_Click(object sender, EventArgs e)
        {
            topic4 = new Topic(client, topic_textBox_4.Text, time_Box_4.Value, run_comboBox_4.Text, path_Label_4.Text, 4, this);
            Save_Button_Func(topic4);
        }

        private void stop_Button_4_Click(object sender, EventArgs e)
        {
            Stop_Button_Func(topic4);
        }      

        private void folder_Button_4_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = path_Label_4.Text;//*****
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                path_Label_4.Text = dialog.FileName;   //*****
        }



        private void exit_ButtonClick(object sender, EventArgs e)
        {
            client.Disconnect();
            Application.Exit();
        }

       
        private void connect_Click(object sender, EventArgs e)
        {
            client = new MqttClient(broker_textBox.Text);
            try
            {
                client.Connect(clientid_textBox.Text, user_textBox.Text, password_textBox.Text);
            }
            catch
            {
                MessageBox.Show("Connect error");
            }
            broker_textBox.Enabled = false;
            clientid_textBox.Enabled = false;
            user_textBox.Enabled = false;
            password_textBox.Enabled = false;
            Connect.Enabled = false;

            group1.Enabled = true;
            group2.Enabled = true;
            group3.Enabled = true;
            group4.Enabled = true;
        }

        private string admin_user = "ml6a01";
        private string admin_pw = "ml6a01";
        private void admin_button_Click(object sender, EventArgs e)
        {
            if (admin_textBox.Text == admin_user && adminpw_textBox.Text == admin_pw)
            {
                GroupBox[] group_all = { group1, group2, group3, group4 };
                foreach (var group in group_all)
                    group.Enabled = !group.Enabled;
            }
                
        }
    }
}

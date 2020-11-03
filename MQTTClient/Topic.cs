using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;

namespace MQTTClient
{
    class Topic
    {
        protected string topic;
        protected MqttClient client;
        protected decimal time;
        public int run;
        public string path;
        public StringBuilder val = new StringBuilder("\n");
        private readonly object lockobject = new object();
        //private readonly Form1 form;
        private  Form1 form;
        public bool repeat = false;
        public short group;

        public Topic(MqttClient client, string topic,decimal time,string run,string path,short group,Form1 form)
        {
            this.client = client;
            this.topic = topic;
            this.time = time*1000;
            this.repeat = !int.TryParse(run, out this.run);
            this.path = path;
            this.form = form;
            this.group = group;

        }
        public void Add_String(string s)
        {
            lock (this.lockobject)
            {
                val.Append(s);
            }
        }
        public string To_String()
        {
            lock(this.lockobject){
                return val.ToString();
            }
        }
        public void Clear()
        {
            lock (this.lockobject)
            {
                val.Clear();
            }
        }
        public void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (e.Topic != topic) return;
            Add_String("\n");
            Add_String(Encoding.UTF8.GetString(e.Message));
        }
        public void Subscribe()
        {
            if (topic != "")
            {
                // subscribe to the topic with QoS 0 ( 0, 1, 2 )
                client.Subscribe(new string[] { topic }, new byte[] { 2 });   // we need arrays as parameters because we can subscribe to different topics with one call
            }
            string time_now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            form.Log_Text(group,"Subscribe start ");
        }
        public void Unsubscribe()
        {
            client.Unsubscribe(new string[] { topic });
        }
        public void Save()
        {
            form.Log_Text(group,"Record start ");
            Clear();
            record();
            form.Button_Visible(group);
        }

        public void reset()
        {
            if (!repeat)
            {
                run--;
                if (run <= 0)
                {
                    if (run == -100) return;
                    form.Button_Visible(group);
                    form.Log_Text(group,"Record end.");
                    run = -100;
                }
                else
                {
                    record();
                    form.Log_Text(group, $"Record left {run} times.");
                }
            }
            else
            {
                form.Log_Text(group,$"Continuous record.");
                record();
            }
        }
        private async void record()
        {
            string record_time = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            await Task.Delay(Convert.ToInt32(time));
            if (run == -100) return;
            /*
            if (val.Length < 1)
                form.Log_Text(group,"No values.");
            else
            {
                using (var stream = new FileStream(
                    $"{path}\\{record_time}.csv", FileMode.Create, FileAccess.Write, FileShare.Write, 4096, useAsync: true))
                {
                    var bytes = Encoding.UTF8.GetBytes(val.ToString());
                    val = null;
                    val = new StringBuilder("\n");
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                }
            }*/
            if (val.Length < 1) form.Log_Text(group, "No values.");
            else
            {
                using (var stream = new FileStream(
                    $"{path}\\{record_time}.csv", FileMode.Create, FileAccess.Write, FileShare.Write, 4096, useAsync: true))
                {
                    var bytes = Encoding.UTF8.GetBytes(To_String());
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                    Clear();
                }
            }
            reset();
        }
    }
}

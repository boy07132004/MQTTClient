namespace MQTTClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RecText = new System.Windows.Forms.TextBox();
            this.topic_textBox = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.broker_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_broker = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.label_pswd = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label_client = new System.Windows.Forms.Label();
            this.clientid_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.run_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_Box = new System.Windows.Forms.NumericUpDown();
            this.stop_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.time_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // RecText
            // 
            this.RecText.Location = new System.Drawing.Point(12, 241);
            this.RecText.Multiline = true;
            this.RecText.Name = "RecText";
            this.RecText.Size = new System.Drawing.Size(473, 130);
            this.RecText.TabIndex = 0;
            // 
            // topic_textBox
            // 
            this.topic_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.topic_textBox.Location = new System.Drawing.Point(85, 90);
            this.topic_textBox.Name = "topic_textBox";
            this.topic_textBox.Size = new System.Drawing.Size(400, 29);
            this.topic_textBox.TabIndex = 1;
            this.topic_textBox.Text = "rand";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(509, 44);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(85, 45);
            this.btnSubscribe.TabIndex = 3;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(509, 152);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(85, 45);
            this.save_Button.TabIndex = 4;
            this.save_Button.Text = "Save!";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_ButtonClick);
            // 
            // broker_textBox
            // 
            this.broker_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.broker_textBox.Location = new System.Drawing.Point(85, 18);
            this.broker_textBox.Name = "broker_textBox";
            this.broker_textBox.Size = new System.Drawing.Size(122, 29);
            this.broker_textBox.TabIndex = 5;
            this.broker_textBox.Text = "192.168.0.161";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Topic";
            // 
            // label_broker
            // 
            this.label_broker.AutoSize = true;
            this.label_broker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broker.Location = new System.Drawing.Point(12, 21);
            this.label_broker.Name = "label_broker";
            this.label_broker.Size = new System.Drawing.Size(59, 20);
            this.label_broker.TabIndex = 8;
            this.label_broker.Text = "Broker";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(12, 56);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 20);
            this.label_user.TabIndex = 9;
            this.label_user.Text = "User";
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.user_textBox.Location = new System.Drawing.Point(85, 53);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(122, 29);
            this.user_textBox.TabIndex = 10;
            this.user_textBox.Text = "raspi3b";
            // 
            // label_pswd
            // 
            this.label_pswd.AutoSize = true;
            this.label_pswd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pswd.Location = new System.Drawing.Point(224, 60);
            this.label_pswd.Name = "label_pswd";
            this.label_pswd.Size = new System.Drawing.Size(80, 20);
            this.label_pswd.TabIndex = 11;
            this.label_pswd.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_textBox.Location = new System.Drawing.Point(305, 53);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(122, 29);
            this.password_textBox.TabIndex = 12;
            this.password_textBox.Text = "ml6a01";
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client.Location = new System.Drawing.Point(224, 23);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(74, 20);
            this.label_client.TabIndex = 13;
            this.label_client.Text = "Client ID";
            // 
            // clientid_textBox
            // 
            this.clientid_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clientid_textBox.Location = new System.Drawing.Point(305, 17);
            this.clientid_textBox.Name = "clientid_textBox";
            this.clientid_textBox.Size = new System.Drawing.Size(122, 29);
            this.clientid_textBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "s";
            // 
            // run_comboBox
            // 
            this.run_comboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.run_comboBox.FormattingEnabled = true;
            this.run_comboBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "N"});
            this.run_comboBox.Location = new System.Drawing.Point(205, 136);
            this.run_comboBox.Name = "run_comboBox";
            this.run_comboBox.Size = new System.Drawing.Size(41, 28);
            this.run_comboBox.TabIndex = 15;
            this.run_comboBox.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Run";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_Box
            // 
            this.time_Box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_Box.Location = new System.Drawing.Point(85, 136);
            this.time_Box.Name = "time_Box";
            this.time_Box.Size = new System.Drawing.Size(48, 29);
            this.time_Box.TabIndex = 17;
            this.time_Box.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stop_Button
            // 
            this.stop_Button.BackColor = System.Drawing.Color.Red;
            this.stop_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_Button.ForeColor = System.Drawing.Color.Black;
            this.stop_Button.Location = new System.Drawing.Point(509, 212);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(85, 45);
            this.stop_Button.TabIndex = 18;
            this.stop_Button.Text = "Stop!";
            this.stop_Button.UseVisualStyleBackColor = false;
            this.stop_Button.Visible = false;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 383);
            this.Controls.Add(this.stop_Button);
            this.Controls.Add(this.time_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.run_comboBox);
            this.Controls.Add(this.clientid_textBox);
            this.Controls.Add(this.label_client);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label_pswd);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_broker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.broker_textBox);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.topic_textBox);
            this.Controls.Add(this.RecText);
            this.Name = "Form1";
            this.Text = "MQTT Client Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecText;
        private System.Windows.Forms.TextBox topic_textBox;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.TextBox broker_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_broker;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.Label label_pswd;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.TextBox clientid_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox run_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown time_Box;
        private System.Windows.Forms.Button stop_Button;
    }
}


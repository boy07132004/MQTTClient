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
            this.time_Box = new System.Windows.Forms.NumericUpDown();
            this.stop_Button = new System.Windows.Forms.Button();
            this.log_textBox = new System.Windows.Forms.TextBox();
            this.path_Label = new System.Windows.Forms.Label();
            this.folder_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.time_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_textBox
            // 
            this.topic_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.topic_textBox.Location = new System.Drawing.Point(69, 76);
            this.topic_textBox.Name = "topic_textBox";
            this.topic_textBox.Size = new System.Drawing.Size(339, 29);
            this.topic_textBox.TabIndex = 1;
            this.topic_textBox.Text = "rand";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(4, 111);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(404, 36);
            this.btnSubscribe.TabIndex = 3;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(4, 226);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(404, 36);
            this.save_Button.TabIndex = 4;
            this.save_Button.Text = "Save!";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_ButtonClick);
            // 
            // broker_textBox
            // 
            this.broker_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.broker_textBox.Location = new System.Drawing.Point(69, 6);
            this.broker_textBox.Name = "broker_textBox";
            this.broker_textBox.Size = new System.Drawing.Size(122, 29);
            this.broker_textBox.TabIndex = 5;
            this.broker_textBox.Text = "192.168.0.100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Topic";
            // 
            // label_broker
            // 
            this.label_broker.AutoSize = true;
            this.label_broker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_broker.Location = new System.Drawing.Point(4, 9);
            this.label_broker.Name = "label_broker";
            this.label_broker.Size = new System.Drawing.Size(59, 20);
            this.label_broker.TabIndex = 8;
            this.label_broker.Text = "Broker";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(4, 44);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 20);
            this.label_user.TabIndex = 9;
            this.label_user.Text = "User";
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.user_textBox.Location = new System.Drawing.Point(69, 41);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(122, 29);
            this.user_textBox.TabIndex = 10;
            this.user_textBox.Text = "raspi3b";
            // 
            // label_pswd
            // 
            this.label_pswd.AutoSize = true;
            this.label_pswd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pswd.Location = new System.Drawing.Point(206, 44);
            this.label_pswd.Name = "label_pswd";
            this.label_pswd.Size = new System.Drawing.Size(80, 20);
            this.label_pswd.TabIndex = 11;
            this.label_pswd.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_textBox.Location = new System.Drawing.Point(286, 41);
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
            this.label_client.Location = new System.Drawing.Point(206, 9);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(74, 20);
            this.label_client.TabIndex = 13;
            this.label_client.Text = "Client ID";
            // 
            // clientid_textBox
            // 
            this.clientid_textBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clientid_textBox.Location = new System.Drawing.Point(286, 6);
            this.clientid_textBox.Name = "clientid_textBox";
            this.clientid_textBox.Size = new System.Drawing.Size(122, 29);
            this.clientid_textBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "每";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒儲存一次";
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
            this.run_comboBox.Location = new System.Drawing.Point(262, 156);
            this.run_comboBox.Name = "run_comboBox";
            this.run_comboBox.Size = new System.Drawing.Size(41, 28);
            this.run_comboBox.TabIndex = 15;
            this.run_comboBox.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "共儲存";
            // 
            // time_Box
            // 
            this.time_Box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time_Box.Location = new System.Drawing.Point(35, 157);
            this.time_Box.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
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
            this.stop_Button.Location = new System.Drawing.Point(4, 226);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(404, 36);
            this.stop_Button.TabIndex = 18;
            this.stop_Button.Text = "Stop!";
            this.stop_Button.UseVisualStyleBackColor = false;
            this.stop_Button.Visible = false;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // log_textBox
            // 
            this.log_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.log_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_textBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.log_textBox.Location = new System.Drawing.Point(4, 268);
            this.log_textBox.MinimumSize = new System.Drawing.Size(400, 180);
            this.log_textBox.Multiline = true;
            this.log_textBox.Name = "log_textBox";
            this.log_textBox.ReadOnly = true;
            this.log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textBox.Size = new System.Drawing.Size(404, 180);
            this.log_textBox.TabIndex = 20;
            this.log_textBox.WordWrap = false;
            // 
            // path_Label
            // 
            this.path_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.path_Label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.path_Label.Location = new System.Drawing.Point(67, 196);
            this.path_Label.MaximumSize = new System.Drawing.Size(300, 20);
            this.path_Label.Name = "path_Label";
            this.path_Label.Size = new System.Drawing.Size(300, 20);
            this.path_Label.TabIndex = 21;
            this.path_Label.Text = "C:\\\\Users";
            // 
            // folder_Button
            // 
            this.folder_Button.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.folder_Button.Location = new System.Drawing.Point(380, 193);
            this.folder_Button.Name = "folder_Button";
            this.folder_Button.Size = new System.Drawing.Size(28, 29);
            this.folder_Button.TabIndex = 22;
            this.folder_Button.Text = "...";
            this.folder_Button.UseVisualStyleBackColor = true;
            this.folder_Button.Click += new System.EventHandler(this.folder_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "次";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "儲存於";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.folder_Button);
            this.Controls.Add(this.path_Label);
            this.Controls.Add(this.log_textBox);
            this.Controls.Add(this.stop_Button);
            this.Controls.Add(this.time_Box);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.broker_textBox);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.topic_textBox);
            this.Name = "Form1";
            this.Text = "MQTT Client Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.NumericUpDown time_Box;
        private System.Windows.Forms.Button stop_Button;
        private System.Windows.Forms.TextBox log_textBox;
        private System.Windows.Forms.Label path_Label;
        private System.Windows.Forms.Button folder_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


namespace Game_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(670, 35);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(458, 541);
            this.logs.TabIndex = 0;
            this.logs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(198, 89);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(169, 34);
            this.textBox_ip.TabIndex = 2;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(128, 180);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(50, 30);
            this.label_port.TabIndex = 3;
            this.label_port.Text = "Port";
            this.label_port.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(198, 176);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(169, 34);
            this.textBox_port.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(198, 278);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(169, 34);
            this.textBox_username.TabIndex = 6;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(207, 498);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(127, 39);
            this.button_connect.TabIndex = 7;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(207, 560);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(127, 39);
            this.button_disconnect.TabIndex = 8;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(199, 380);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(169, 34);
            this.textBox_answer.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(394, 380);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(127, 39);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox logs;
        private Label label1;
        private TextBox textBox_ip;
        private Label label_port;
        private TextBox textBox_port;
        private Label label2;
        private TextBox textBox_username;
        private Button button_connect;
        private Button button_disconnect;
        private Label label3;
        private TextBox textBox_answer;
        private Button button_send;
    }
}
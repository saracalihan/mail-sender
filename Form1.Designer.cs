
namespace email_sender
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
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tbxSender = new System.Windows.Forms.TextBox();
            this.tbxDisplayName = new System.Windows.Forms.TextBox();
            this.tbxReceivers = new System.Windows.Forms.TextBox();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.rtbxBody = new System.Windows.Forms.RichTextBox();
            this.gbxEmailInfo = new System.Windows.Forms.GroupBox();
            this.Subject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxMailServerInformation = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.cbxSSL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.gbxEmailInfo.SuspendLayout();
            this.gbxMailServerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(234, 319);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(101, 34);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxSender
            // 
            this.tbxSender.Location = new System.Drawing.Point(95, 26);
            this.tbxSender.Name = "tbxSender";
            this.tbxSender.Size = new System.Drawing.Size(217, 23);
            this.tbxSender.TabIndex = 1;
            this.tbxSender.TextChanged += new System.EventHandler(this.tbxSender_TextChanged);
            // 
            // tbxDisplayName
            // 
            this.tbxDisplayName.Location = new System.Drawing.Point(95, 63);
            this.tbxDisplayName.Name = "tbxDisplayName";
            this.tbxDisplayName.Size = new System.Drawing.Size(217, 23);
            this.tbxDisplayName.TabIndex = 2;
            // 
            // tbxReceivers
            // 
            this.tbxReceivers.Location = new System.Drawing.Point(95, 101);
            this.tbxReceivers.Name = "tbxReceivers";
            this.tbxReceivers.Size = new System.Drawing.Size(217, 23);
            this.tbxReceivers.TabIndex = 3;
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(95, 139);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(217, 23);
            this.tbxSubject.TabIndex = 4;
            this.tbxSubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rtbxBody
            // 
            this.rtbxBody.Location = new System.Drawing.Point(20, 181);
            this.rtbxBody.Name = "rtbxBody";
            this.rtbxBody.Size = new System.Drawing.Size(292, 177);
            this.rtbxBody.TabIndex = 5;
            this.rtbxBody.Text = "Message";
            // 
            // gbxEmailInfo
            // 
            this.gbxEmailInfo.Controls.Add(this.Subject);
            this.gbxEmailInfo.Controls.Add(this.label4);
            this.gbxEmailInfo.Controls.Add(this.label3);
            this.gbxEmailInfo.Controls.Add(this.label2);
            this.gbxEmailInfo.Controls.Add(this.rtbxBody);
            this.gbxEmailInfo.Controls.Add(this.tbxSubject);
            this.gbxEmailInfo.Controls.Add(this.tbxReceivers);
            this.gbxEmailInfo.Controls.Add(this.tbxDisplayName);
            this.gbxEmailInfo.Controls.Add(this.tbxSender);
            this.gbxEmailInfo.Location = new System.Drawing.Point(7, 12);
            this.gbxEmailInfo.Name = "gbxEmailInfo";
            this.gbxEmailInfo.Size = new System.Drawing.Size(333, 370);
            this.gbxEmailInfo.TabIndex = 6;
            this.gbxEmailInfo.TabStop = false;
            this.gbxEmailInfo.Text = "Email Information:";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(7, 145);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(49, 15);
            this.Subject.TabIndex = 9;
            this.Subject.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reciver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Display Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sender: ";
            // 
            // gbxMailServerInformation
            // 
            this.gbxMailServerInformation.Controls.Add(this.label6);
            this.gbxMailServerInformation.Controls.Add(this.label5);
            this.gbxMailServerInformation.Controls.Add(this.label7);
            this.gbxMailServerInformation.Controls.Add(this.tbxHost);
            this.gbxMailServerInformation.Controls.Add(this.cbxSSL);
            this.gbxMailServerInformation.Controls.Add(this.btnSendMail);
            this.gbxMailServerInformation.Controls.Add(this.label1);
            this.gbxMailServerInformation.Controls.Add(this.nudPort);
            this.gbxMailServerInformation.Controls.Add(this.tbxPassword);
            this.gbxMailServerInformation.Controls.Add(this.txbUsername);
            this.gbxMailServerInformation.Location = new System.Drawing.Point(359, 17);
            this.gbxMailServerInformation.Name = "gbxMailServerInformation";
            this.gbxMailServerInformation.Size = new System.Drawing.Size(352, 365);
            this.gbxMailServerInformation.TabIndex = 7;
            this.gbxMailServerInformation.TabStop = false;
            this.gbxMailServerInformation.Text = "Mail Server Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Host: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sender: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password: ";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(97, 96);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(239, 23);
            this.tbxHost.TabIndex = 7;
            // 
            // cbxSSL
            // 
            this.cbxSSL.AutoSize = true;
            this.cbxSSL.Location = new System.Drawing.Point(19, 176);
            this.cbxSSL.Name = "cbxSSL";
            this.cbxSSL.Size = new System.Drawing.Size(44, 19);
            this.cbxSSL.TabIndex = 6;
            this.cbxSSL.Text = "SSL";
            this.cbxSSL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(93, 132);
            this.nudPort.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(98, 23);
            this.nudPort.TabIndex = 4;
            this.nudPort.ValueChanged += new System.EventHandler(this.nudHost_ValueChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(96, 58);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(239, 23);
            this.tbxPassword.TabIndex = 3;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(97, 22);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(239, 23);
            this.txbUsername.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 395);
            this.Controls.Add(this.gbxMailServerInformation);
            this.Controls.Add(this.gbxEmailInfo);
            this.Name = "Form1";
            this.Text = "Email Sender";
            this.gbxEmailInfo.ResumeLayout(false);
            this.gbxEmailInfo.PerformLayout();
            this.gbxMailServerInformation.ResumeLayout(false);
            this.gbxMailServerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox tbxSender;
        private System.Windows.Forms.TextBox tbxDisplayName;
        private System.Windows.Forms.TextBox tbxReceivers;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.RichTextBox rtbxBody;
        private System.Windows.Forms.GroupBox gbxEmailInfo;
        private System.Windows.Forms.GroupBox gbxMailServerInformation;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.CheckBox cbxSSL;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}


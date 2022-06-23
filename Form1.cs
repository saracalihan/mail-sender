using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email_sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mail mail = new Mail();
                mail.Sender = tbxSender.Text;
                mail.DisplayName = tbxDisplayName.Text;
                mail.Receivers.Add(tbxReceivers.Text);
                mail.Subject = tbxSubject.Text;
                mail.Body = rtbxBody.Text;
                mail.Username = txbUsername.Text;
                mail.Password = tbxPassword.Text;
                mail.Host = tbxHost.Text;
                mail.Port = (int)nudPort.Value;
                mail.EnableSSL = cbxSSL.Checked;
                mail.Init();
                MessageBox.Show("Sending ...", "Mail Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mail.Send())
                {
                    MessageBox.Show("Success", "Mail Status" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudHost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxSender_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

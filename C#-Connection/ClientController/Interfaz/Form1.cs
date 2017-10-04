using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
using Exceptions;

namespace UI
{
    public partial class Form1 : Form
    {
        Client emotiv;
        public Form1()
        {
            InitializeComponent();
            this.disconnect_btn.Enabled = false;
            this.up_btn.Enabled = false;
            this.down_btn.Enabled = false;
            this.right_btn.Enabled = false;
            this.left_btn.Enabled = false;
            this.pull_btn.Enabled = false;
            this.push_btn.Enabled = false;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            emotiv = new Client(this.ip_txt.Text.Trim(), int.Parse(this.port_txt.Text.Trim()) );
            try
            {
                this.ip_txt.Enabled = false;
                this.port_txt.Enabled = false;
                this.connect_btn.Enabled = false;
                this.disconnect_btn.Enabled = true;
                this.up_btn.Enabled = true;
                this.down_btn.Enabled = true;
                this.right_btn.Enabled = true;
                this.left_btn.Enabled = true;
                this.pull_btn.Enabled = true;
                this.push_btn.Enabled = true;
            }
            catch(ServerInitializeException ex)
            {
                MessageBox.Show(ex.Message, "Server Initialize Error");
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("u"); //Up
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("l"); //Left
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("r"); //Right
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("d"); //Down
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("p"); //Pull
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void pull_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emotiv.SendCommand("h"); //Push
            }
            catch (MessageSenderException ex)
            {
                MessageBox.Show(ex.Message, "Sending Command to Server Error");
            }
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                emotiv.ResetConfig();
                this.ip_txt.Enabled = true;
                this.port_txt.Enabled = true;
                this.connect_btn.Enabled = true;
                this.disconnect_btn.Enabled = false;
                this.up_btn.Enabled = false;
                this.down_btn.Enabled = false;
                this.right_btn.Enabled = false;
                this.left_btn.Enabled = false;
                this.pull_btn.Enabled = false;
                this.push_btn.Enabled = false;
            }
            catch (ServerDisconnectException ex)
            {
                MessageBox.Show(ex.Message, "Server Disconnect Error");
            }
        }
    }
}

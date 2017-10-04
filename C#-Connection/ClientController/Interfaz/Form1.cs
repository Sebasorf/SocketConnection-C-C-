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
        Client e_client;
        public Form1()
        {
            InitializeComponent();
            this.reset_btn.Enabled = false;
            this.up_btn.Enabled = false;
            this.down_btn.Enabled = false;
            this.right_btn.Enabled = false;
            this.left_btn.Enabled = false;
            this.pull_btn.Enabled = false;
            this.push_btn.Enabled = false;
        }

        private void init_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ip_txt.Text.Trim().Length == 0 && this.port_txt.Text.Trim().Length == 0)
                    e_client = new Client();
                else
                    e_client = new Client(this.ip_txt.Text.Trim(), int.Parse(this.port_txt.Text.Trim()) );
                this.ip_txt.Enabled = false;
                this.port_txt.Enabled = false;
                this.init_btn.Enabled = false;
                this.reset_btn.Enabled = true;
                this.up_btn.Enabled = true;
                this.down_btn.Enabled = true;
                this.right_btn.Enabled = true;
                this.left_btn.Enabled = true;
                this.pull_btn.Enabled = true;
                this.push_btn.Enabled = true;
            }
            catch (InitializeConnectionException ice)
            {
                MessageBox.Show(ice.Message, "Server Initialize Error");
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("u"); //Up
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("l"); //Left
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("r"); //Right
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("d"); //Down
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void push_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("p"); //Pull
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void pull_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("h"); //Push
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            e_client.ResetConfig();
            this.ip_txt.Enabled = true;
            this.port_txt.Enabled = true;
            this.init_btn.Enabled = true;
            this.reset_btn.Enabled = false;
            this.up_btn.Enabled = false;
            this.down_btn.Enabled = false;
            this.right_btn.Enabled = false;
            this.left_btn.Enabled = false;
            this.pull_btn.Enabled = false;
            this.push_btn.Enabled = false;
        }
    }
}

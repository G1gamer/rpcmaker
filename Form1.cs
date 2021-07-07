using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace G1gamer_s_RPC_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
        bool initalized = false;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (initalized == false)
            {
                MessageBox.Show("You need to load the app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{bunifuMaterialTextbox1.Text}",
                    State = $"{bunifuMaterialTextbox2.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{bunifuMaterialTextbox4.Text}",
                        LargeImageText = $"{bunifuMaterialTextbox6.Text}",
                        SmallImageKey = $"{bunifuMaterialTextbox5.Text}",
                    }
                });
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient($"{bunifuMaterialTextbox5.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.Show();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

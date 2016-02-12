using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//created by Jess Nguyen
// Feb 12, 2016
namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = "Jess";
            string inputUser = textBoxUsername.Text;
            string password = "1233";
            string inputPass = textBoxPassword.Text;

            if (username == inputUser && password == inputPass)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                LogoutScreen ls = new LogoutScreen();
                f.Controls.Add(ls);
            }
            else if (username != inputUser && password != inputPass)
            {
                labelIncorrect.Text = "Either your username or password is incorrect. Please try again.";
            }
        }
    }
}

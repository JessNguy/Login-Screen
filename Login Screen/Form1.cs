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
        LoginWindow lw = new LoginWindow();
        this.Controls.Add(lw);
        }

       
    }
}

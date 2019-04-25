using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList messages = new ArrayList();
        bool check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messages.Add("I");
            messages.Add("Love");
            messages.Add("Programming");
            messages.Add("So");
            messages.Add("Much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                Messages();
            }
            else if (check)
            {
                check = false;
                messages.Reverse();
                Messages();
            }
        }

        private void Messages()
        {
            string mess = string.Empty;

            for (int i = 0; i < messages.Count; i++)
            {
                mess += messages[i].ToString() + " ";
            }

            lblMessage.Text = mess;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                messages.Reverse();
                check = true;
                Messages();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                messages.Insert(1, txtSecondPos.Text);
                Messages();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                messages.RemoveAt(1);
                Messages();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPracticeLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (textBoxName.Text.Equals("pranta") && textBoxPassword.Equals("1234"))
            {
                new Registration();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (textBoxName.Text.Equals("pranta"))
            {

                Registration x = new Registration();
                x.ShowDialog();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginpagelabel_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {

        }

        private void EditUser_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    public partial class AddNotice : Form
    {
        public AddNotice()
        {
            InitializeComponent();
        }

        private void AddNotice_Load(object sender, EventArgs e)
        {

        }

        private void addntcBtnClk(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string date = dttextBox.Text;
            
            bool flag = false;
            if (text.Equals(""))
            {
                MessageBox.Show("Please Write Something");
            }
            else
            {
                bool m = NoticeController.AddNotice(text, date);
                if (m)
                {
                    flag = true;
                }
                else
                    flag = false;

            }
            
            if (flag)
            {
                MessageBox.Show("Notice Posted Successfully");
            }
            else
                flag = false;
        }
    }
}

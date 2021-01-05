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
using ProjectOOP2new.Controller;

namespace ProjectOOP2new.View
{
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }

        private void addnoticeBtnClk(object sender, EventArgs e)
        {
            AddNotice x = new AddNotice();
            x.ShowDialog();
        }

        private void viewntcBtnClk(object sender, EventArgs e)
        {
            ArrayList y = new ArrayList();
            y = NoticeController.ShowAllNotices();
            new ViewAllNotice(y).Show();
            
        }
    }
}

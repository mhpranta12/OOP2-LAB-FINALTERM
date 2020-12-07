using System;
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
    public partial class Registration : Form
    {
        string gender;

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(pcheckBox.Checked)
            {
                this.textBoxPassword.UseSystemPasswordChar=false;
                this.textBoxPassword.Show();
                this.textBoxReTypePassword.UseSystemPasswordChar = false;

            }
            if (this.comboBox1.SelectedIndex.Equals(0))
            {
                derrorlabel.Show();
            }
            else
            {
                derrorlabel.Hide();
            }
            if (this.comboBox2.SelectedIndex.Equals(0))
            {
                merrorlabel.Show();
            }
            else
            {
                merrorlabel.Hide();
            }
            if (this.comboBox3.SelectedIndex.Equals(0))
            {
                yerrorlabel.Show();
            }
            else
            {
                yerrorlabel.Hide();
            }


            if (this.textBoxFirstname.Text.Equals(""))
            {
                fnameerror.Show();
            }
            else
            {
                fnameerror.Hide();
            }

            if (this.textBoxLastname.Text.Equals(""))
            {
                lnameerror.Show();
            }
            else
            {
                lnameerror.Hide();
            }


            if (this.textBoxEmail.Text!=this.textBoxReTypeEmail.Text)
            {
                emailerror.Show();
              
            }
            else
            {
                emailerror.Hide();
            }
            if (this.pcheckBox.Checked)
            {
               
            }
            if (this.textBoxReTypePassword.Text!=this.textBoxPassword.Text)
            {
                perror.Show(); 
            }
            else
            {
                perror.Hide();
            }
             if (this.radioButtonFemale.Checked || this.radioButtonMale.Checked)
            {
                if (this.radioButtonMale.Checked)
                {
                     gender = this.radioButtonMale.Text;
                }
                else if (this.radioButtonFemale.Checked)
                {
                   gender = this.radioButtonFemale.Text;
                }
            }
            else
            {
                MessageBox.Show("Plz Select Gender");
            }
            if (this.textBoxFirstname.Text != null && this.textBoxLastname.Text != null
                && this.comboBox1.SelectedIndex != 0
                && this.comboBox2.SelectedIndex != 0
                && this.comboBox3.SelectedIndex != 0
                && this.textBoxReTypePassword.Text.Equals(this.textBoxPassword.Text)
                && this.textBoxEmail.Text.Equals(this.textBoxReTypeEmail.Text)
               )

            {


                rt1.Text = "Name : " + this.textBoxFirstname.Text +" "+this.textBoxLastname.Text+ "\nEmail : "+this.textBoxEmail.Text+"\nPassword : " + this.textBoxPassword.Text+"\nGender : "+this.gender+ " "+"\nDate of birth : "+this.comboBox1.Text+" " +this.comboBox2.Text+""+this.comboBox3.Text+"\nSecurity question  : "+this.comboBoxSecurityquestion.Text+"\nAnswer :  "+this.textBoxSecurityanswer.Text+"\nAddress :"+this.comboBoxCity.Text+ ","+this.textBoxState.Text+"\n"+this.phncombo.Text+" No :"+this.textBoxPhn.Text+"\n ";






            }
            
        }

        private void Checked(object sender, EventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = false;
            
            this.textBoxReTypePassword.UseSystemPasswordChar = false;
        }
    }
}

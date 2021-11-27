using CalThreeLayer.BUS_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PL
{
    public partial class Login : Form
    {
        private controlForm dieuhuong = new controlForm();

        public Login()
        {
            InitializeComponent();
        }

        public controlForm controlForm
        {
            get => default;
            set
            {
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginfromFORMLOGIN(object sender, EventArgs e)
        {
            try
            {
                int checkview = 0;
                checkview = dieuhuong.LoginfromFORMLOGIN(txt_Email.Text, txt_Password.Text);
                if (checkview == 1)
                {

                    MessageBox.Show("DANG NHAP THANH CONG ");
                    this.Hide();
                    CALCULATOR f2 = new CALCULATOR();
                    f2.ShowDialog();
                    f2 = null;
                    this.Show();

                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterfromFORMLOGIN(object sender, EventArgs e)
        {
            try
            {
                int checkview = 0;
                checkview = dieuhuong.RegisterfromFORMLOGIN(txt_Email.Text, txt_Password.Text);
                if (checkview == 1)
                {
                    MessageBox.Show("DANG KY THANH CONG");
                }
                else
                {
                    MessageBox.Show(" DANG KY THAT BAI EMAIL NAY DA DC DANG KY");
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void ChangefromFORMLOGIN(object sender, EventArgs e)
        {
            try
            {
                int checkview = 0;
                checkview = dieuhuong.ChangefromFORMLOGIN(txt_Email.Text, txt_Password.Text);
                if (checkview == 1)
                {
                    MessageBox.Show("THAY DOI MAU KHAU THANH CONG");
                }
                else
                {
                    MessageBox.Show("THAY DOI MAT KHAU THAT BAI ");
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

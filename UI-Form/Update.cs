using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;

namespace UI_Form
{
    public partial class Update : Form
    {
        UserBO obj_bo = new UserBO();
        
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        public void Search_Click(object sender, EventArgs e)
        {
            String AccountNumber="";
            bool Check=false;
            AccountNumber = updsearce.Text;
            string[] info= obj_bo.SearceForUpdate(AccountNumber);
            if (info == null)
                Check = false;
            else if (info.Length>0)
                Check = true;
            if (Check==true)
            {
           
                updsearce.ResetText();
                No.ResetText();
                Yes.Text = "Your Account Found";
                lableshow.Visible = true;
               // Show.Visible = true;
                UpdateAccount l = new UpdateAccount();
                l.txtAccount.Text = info[0];
                l.txtAccount.Enabled = false;
                l.txtUsername.Text = info[1];
                l.txtAge.Text = info[2];
                l.comGender.Text= info[3];
                l.txtEmail.Text = info[4];
                l.txtCont.Text = info[5];
                l.txtOcc.Text = info[6];
                l.txtAdd.Text = info[7];
                l.comBranch.Text = info[8];
                l.txtbalance.Text=info[9];
                l.Show();
  
            }
            else
            {
                updsearce.ResetText();
                Yes.ResetText();
                No.Text = "Your Account Not Found";
                lableshow.Visible = false;
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            UpdateAccount l = new UpdateAccount();
            
            l.Show();
        }

        private void updsearce_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

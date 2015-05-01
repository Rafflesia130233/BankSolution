using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
using Entity;


namespace UI_Form
{
    public partial class Create : Form

    {
        UserBO obj_bo = new UserBO();
        public Create()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            try
            {

                User obj_User = new User();
                
                obj_User.name = txtUsername.Text;
                obj_User.age = txtAge.Text;
                obj_User.gender = comGender.Text;
                obj_User.occupation = txtOcc.Text;
                obj_User.address = txtAdd.Text;
                obj_User.email = txtEmail.Text;
                obj_User.contact = txtCont.Text;
                obj_User.account_number = comAcnum.Text;
                obj_User.bank_branch = comBranch.Text;
                obj_User.bank_balance = txtbalance.Text;
                obj_bo.saveUserInfo(obj_User);

                //MessageBox.Show("Account Created Successfully");
                if (txtUsername.Text == "" || txtAge.Text == "" || comGender.Text == "" || txtAdd.Text == "" || txtEmail.Text == "" || txtCont.Text == "" || comAcnum.Text == "" || comBranch.Text == "")
                {
                    MessageBox.Show("pls. complete the information.");
                }
                else
                {
                    MessageBox.Show("Account Created Successfully");
                }

                txtUsername.ResetText();
                txtAge.ResetText();
                comGender.ResetText();
                txtOcc.ResetText();
                txtAdd.ResetText();
                txtEmail.ResetText();
                txtCont.ResetText();
                comAcnum.ResetText();
                comBranch.ResetText();
                txtbalance.ResetText();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Somethings Wrong");
            }
        }

        private void comAcnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String mss = comAcnum.Text;
            bool a = obj_bo.Searce(comAcnum.Text);
            if(a==true)
            {
               //comAcnum.     
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        
    

        public void txtbalance_TextChanged(object sender, EventArgs e)
        {
            String balance = txtbalance.Text;
            Char[] t = balance.ToCharArray();
            int u;
            for (u = 0; u < t.Length; u++)
            {
                if (t[u] < 48 || t[u] > 57)
                {
                    MessageBox.Show("Invalid Input");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;

namespace UI_Form
{
    public partial class UpdateAccount : Form
    {
        UserBO ob = new UserBO();
        String b;
        public UpdateAccount()
        {
            InitializeComponent();
        }
        public String returnAccountnumber()
        { return this.txtAccount.Text; }

        private void createAcc_Click(object sender, EventArgs e)
        {
            string path = "E:\\All file for project\\BankNew.txt";
            String updateInfo= this.txtAccount.Text+";"+this.txtUsername.Text+";"+this.txtAge.Text+";"
                +this.comGender.Text+";"+this.txtEmail.Text+";"+this.txtCont.Text+";"
                    + this.txtOcc.Text + ";" + this.txtAdd.Text + ";" + this.comBranch.Text + ";" + this.txtbalance.Text+ ";";
          
            string[] arrLine = File.ReadAllLines(path);
           
            for (int i = 0; i < arrLine.Length; i++)
            {
                if (arrLine[i].Contains(this.txtAccount.Text))
                {
                    arrLine[i] = updateInfo;
                    ob.saveUpdatedInfo(updateInfo);
                    break;
                }
            }
            
            try
            {
                File.WriteAllLines(path, arrLine);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
           
            MessageBox.Show("Account Information has been updated Successfully");
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeBlalance k = new ChangeBlalance();
            k.Show();
        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {

        }
        public String returnbalance()
        {return this.b;}
       
       

    }
}
    


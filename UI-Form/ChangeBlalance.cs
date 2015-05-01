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
    public partial class ChangeBlalance : Form
    {
        UserBO obj_bo = new UserBO();
        UpdateAccount obU = new UpdateAccount();

        public ChangeBlalance()
        {
            
            InitializeComponent();
            String A = obU.txtbalance.Text;
            AccountTxt.Text = obU.returnAccountnumber();
        }
        
        private void DipositeB_Click(object sender, EventArgs e)
        {
            string[] info= obj_bo.SearceForUpdate(AccountTxt.Text);
            String acf=info[9];
            try
            {
                Int32 r = Convert.ToInt32(acf);
                String dtaka = txtDpo.Text;
                Int32 dtka = Convert.ToInt32(dtaka);
                Int32 newB = obj_bo.Deposite(r,dtka);
                MessageBox.Show("Your new balance would be " + newB);
                obU.txtbalance.ResetText();
                obU.txtbalance.Text = Convert.ToString(newB);
            }
            catch { MessageBox.Show("Your new balance is not a elligible balance "); }
             
           
        }

        private void WithdrawB_Click(object sender, EventArgs e)
        {
            string[] info = obj_bo.SearceForUpdate(AccountTxt.Text);
            String acf = info[9];
            try
            {
                Int32 r = Convert.ToInt32(acf);
                String dtaka = txtwit.Text;
                Int32 dtka = Convert.ToInt32(dtaka);
                Int32 newB = obj_bo.Withdraw(r, dtka);
                MessageBox.Show("Your new balance would be " + newB);
                obU.txtbalance.Text = Convert.ToString(newB); ;
            }
            catch { MessageBox.Show("Your new balance is not a elligible balance "); }
        }

        private void InterestB_Click(object sender, EventArgs e)
        {
            string[] info = obj_bo.SearceForUpdate(AccountTxt.Text);
            String acf = info[9];
            try
            {
                Int32 r = Convert.ToInt32(acf);
               
                Int32 newB = obj_bo.Interest(r);
                MessageBox.Show("With our 10% interest U will recive " + newB +" taka at the end of this year"); 
                obU.txtbalance.Text=Convert.ToString(newB);
            }
            catch { MessageBox.Show("Your new balance is not a elligible balance "); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ChangeBlalance_Load(object sender, EventArgs e)
        {

        }
    }
}

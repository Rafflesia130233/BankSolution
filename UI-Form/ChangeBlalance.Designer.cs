namespace UI_Form
{
    partial class ChangeBlalance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DipositeB = new System.Windows.Forms.Button();
            this.WithdrawB = new System.Windows.Forms.Button();
            this.InterestB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDpo = new System.Windows.Forms.TextBox();
            this.txtwit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountTxt = new System.Windows.Forms.TextBox();
            this.Current = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DipositeB
            // 
            this.DipositeB.Location = new System.Drawing.Point(114, 191);
            this.DipositeB.Name = "DipositeB";
            this.DipositeB.Size = new System.Drawing.Size(75, 23);
            this.DipositeB.TabIndex = 0;
            this.DipositeB.Text = "Diposite";
            this.DipositeB.UseVisualStyleBackColor = true;
            this.DipositeB.Click += new System.EventHandler(this.DipositeB_Click);
            // 
            // WithdrawB
            // 
            this.WithdrawB.Location = new System.Drawing.Point(115, 276);
            this.WithdrawB.Name = "WithdrawB";
            this.WithdrawB.Size = new System.Drawing.Size(75, 23);
            this.WithdrawB.TabIndex = 1;
            this.WithdrawB.Text = "Withdraw";
            this.WithdrawB.UseVisualStyleBackColor = true;
            this.WithdrawB.Click += new System.EventHandler(this.WithdrawB_Click);
            // 
            // InterestB
            // 
            this.InterestB.Location = new System.Drawing.Point(114, 347);
            this.InterestB.Name = "InterestB";
            this.InterestB.Size = new System.Drawing.Size(75, 23);
            this.InterestB.TabIndex = 2;
            this.InterestB.Text = "Get Interest";
            this.InterestB.UseVisualStyleBackColor = true;
            this.InterestB.Click += new System.EventHandler(this.InterestB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Enter Your Choice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ammount you want to depoite";
            // 
            // txtDpo
            // 
            this.txtDpo.Location = new System.Drawing.Point(91, 162);
            this.txtDpo.Name = "txtDpo";
            this.txtDpo.Size = new System.Drawing.Size(124, 20);
            this.txtDpo.TabIndex = 5;
            // 
            // txtwit
            // 
            this.txtwit.Location = new System.Drawing.Point(91, 250);
            this.txtwit.Name = "txtwit";
            this.txtwit.Size = new System.Drawing.Size(124, 20);
            this.txtwit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ammount you want to withdraw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "To see ur balance with interest";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AccountTxt
            // 
            this.AccountTxt.Location = new System.Drawing.Point(78, 96);
            this.AccountTxt.Name = "AccountTxt";
            this.AccountTxt.Size = new System.Drawing.Size(155, 20);
            this.AccountTxt.TabIndex = 9;
            this.AccountTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Current
            // 
            this.Current.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current.Location = new System.Drawing.Point(38, 70);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(243, 23);
            this.Current.TabIndex = 10;
            this.Current.Text = "Please inter ur account number again";
            // 
            // ChangeBlalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 402);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.AccountTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtwit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterestB);
            this.Controls.Add(this.WithdrawB);
            this.Controls.Add(this.DipositeB);
            this.Name = "ChangeBlalance";
            this.Text = "ChangeBlalance";
            this.Load += new System.EventHandler(this.ChangeBlalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DipositeB;
        private System.Windows.Forms.Button WithdrawB;
        private System.Windows.Forms.Button InterestB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDpo;
        private System.Windows.Forms.TextBox txtwit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Current;
        public System.Windows.Forms.TextBox AccountTxt;
    }
}
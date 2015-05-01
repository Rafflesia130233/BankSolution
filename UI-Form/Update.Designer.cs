namespace UI_Form
{
    partial class Update
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
            this.updsearce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.lableshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updsearce
            // 
            this.updsearce.Location = new System.Drawing.Point(146, 79);
            this.updsearce.Name = "updsearce";
            this.updsearce.Size = new System.Drawing.Size(183, 20);
            this.updsearce.TabIndex = 0;
            this.updsearce.TextChanged += new System.EventHandler(this.updsearce_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Uour Account Number";
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(199, 115);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.Location = new System.Drawing.Point(192, 151);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(0, 13);
            this.Yes.TabIndex = 3;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(180, 171);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(0, 13);
            this.No.TabIndex = 4;
            // 
            // Show
            // 
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(199, 234);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 5;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Visible = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // lableshow
            // 
            this.lableshow.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableshow.Location = new System.Drawing.Point(103, 209);
            this.lableshow.Name = "lableshow";
            this.lableshow.Size = new System.Drawing.Size(281, 23);
            this.lableshow.TabIndex = 6;
            this.lableshow.Text = "Show Your Account Information for updating";
            this.lableshow.Visible = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(451, 275);
            this.Controls.Add(this.lableshow);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updsearce);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Yes;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label lableshow;
        public System.Windows.Forms.TextBox updsearce;
    }
}
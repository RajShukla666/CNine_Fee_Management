namespace CNINE_Fee_Management
{
    partial class Settings
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataSourceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ISCB = new System.Windows.Forms.CheckBox();
            this.PassWordErorLable = new System.Windows.Forms.Label();
            this.UserNameErorLable = new System.Windows.Forms.Label();
            this.DataBaseErorLable = new System.Windows.Forms.Label();
            this.DataSourceErorLable = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(250, 562);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1189, 562);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1189, 45);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ISCB);
            this.panel2.Controls.Add(this.DatabaseTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DataSourceTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SaveBtn);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PassWordErorLable);
            this.panel2.Controls.Add(this.UserNameErorLable);
            this.panel2.Controls.Add(this.DataBaseErorLable);
            this.panel2.Controls.Add(this.DataSourceErorLable);
            this.panel2.Size = new System.Drawing.Size(250, 517);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1189, 517);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Gold;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 3;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.SaveBtn.Location = new System.Drawing.Point(31, 269);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(192, 43);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(15, 203);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(228, 26);
            this.PasswordTxt.TabIndex = 3;
            this.PasswordTxt.UseSystemPasswordChar = true;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(15, 145);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(228, 26);
            this.UsernameTxt.TabIndex = 2;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // DatabaseTxt
            // 
            this.DatabaseTxt.Location = new System.Drawing.Point(15, 92);
            this.DatabaseTxt.Name = "DatabaseTxt";
            this.DatabaseTxt.Size = new System.Drawing.Size(228, 26);
            this.DatabaseTxt.TabIndex = 1;
            this.DatabaseTxt.TextChanged += new System.EventHandler(this.DatabaseTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Database";
            // 
            // DataSourceTxt
            // 
            this.DataSourceTxt.Location = new System.Drawing.Point(15, 34);
            this.DataSourceTxt.Name = "DataSourceTxt";
            this.DataSourceTxt.Size = new System.Drawing.Size(228, 26);
            this.DataSourceTxt.TabIndex = 0;
            this.DataSourceTxt.TextChanged += new System.EventHandler(this.DataSourceTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "DataSource";
            // 
            // ISCB
            // 
            this.ISCB.AutoSize = true;
            this.ISCB.Location = new System.Drawing.Point(15, 235);
            this.ISCB.Name = "ISCB";
            this.ISCB.Size = new System.Drawing.Size(155, 22);
            this.ISCB.TabIndex = 4;
            this.ISCB.Text = "Integrated Security";
            this.ISCB.UseVisualStyleBackColor = true;
            this.ISCB.CheckedChanged += new System.EventHandler(this.ISCB_CheckedChanged);
            // 
            // PassWordErorLable
            // 
            this.PassWordErorLable.AutoSize = true;
            this.PassWordErorLable.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordErorLable.Location = new System.Drawing.Point(216, 179);
            this.PassWordErorLable.Name = "PassWordErorLable";
            this.PassWordErorLable.Size = new System.Drawing.Size(26, 29);
            this.PassWordErorLable.TabIndex = 21;
            this.PassWordErorLable.Text = "*";
            this.PassWordErorLable.Visible = false;
            // 
            // UserNameErorLable
            // 
            this.UserNameErorLable.AutoSize = true;
            this.UserNameErorLable.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameErorLable.Location = new System.Drawing.Point(216, 123);
            this.UserNameErorLable.Name = "UserNameErorLable";
            this.UserNameErorLable.Size = new System.Drawing.Size(26, 29);
            this.UserNameErorLable.TabIndex = 20;
            this.UserNameErorLable.Text = "*";
            this.UserNameErorLable.Visible = false;
            // 
            // DataBaseErorLable
            // 
            this.DataBaseErorLable.AutoSize = true;
            this.DataBaseErorLable.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBaseErorLable.Location = new System.Drawing.Point(216, 68);
            this.DataBaseErorLable.Name = "DataBaseErorLable";
            this.DataBaseErorLable.Size = new System.Drawing.Size(26, 29);
            this.DataBaseErorLable.TabIndex = 19;
            this.DataBaseErorLable.Text = "*";
            this.DataBaseErorLable.Visible = false;
            // 
            // DataSourceErorLable
            // 
            this.DataSourceErorLable.AutoSize = true;
            this.DataSourceErorLable.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSourceErorLable.Location = new System.Drawing.Point(217, 12);
            this.DataSourceErorLable.Name = "DataSourceErorLable";
            this.DataSourceErorLable.Size = new System.Drawing.Size(26, 29);
            this.DataSourceErorLable.TabIndex = 18;
            this.DataSourceErorLable.Text = "*";
            this.DataSourceErorLable.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 562);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ISCB;
        private System.Windows.Forms.TextBox DatabaseTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DataSourceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PassWordErorLable;
        private System.Windows.Forms.Label UserNameErorLable;
        private System.Windows.Forms.Label DataBaseErorLable;
        private System.Windows.Forms.Label DataSourceErorLable;
    }
}
namespace CNINE_Fee_Management
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameErorLable = new System.Windows.Forms.Label();
            this.PasswordErorLable = new System.Windows.Forms.Label();
            this.ExttBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(250, 574);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Size = new System.Drawing.Size(250, 45);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(250, 0);
            this.RightPanel.Size = new System.Drawing.Size(1192, 574);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Size = new System.Drawing.Size(1192, 45);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExttBtn);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.PasswordTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.UsernameTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PasswordErorLable);
            this.panel2.Controls.Add(this.UsernameErorLable);
            this.panel2.Size = new System.Drawing.Size(250, 529);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Size = new System.Drawing.Size(1192, 529);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(16, 29);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(228, 26);
            this.UsernameTxt.TabIndex = 1;
            this.UsernameTxt.Text = "Admin";
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(16, 87);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(228, 26);
            this.PasswordTxt.TabIndex = 3;
            this.PasswordTxt.Text = "bmsBalrampur2020";
            this.PasswordTxt.UseSystemPasswordChar = true;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Gold;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 3;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.LoginBtn.Location = new System.Drawing.Point(34, 119);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(192, 36);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 0;
            // 
            // UsernameErorLable
            // 
            this.UsernameErorLable.AutoSize = true;
            this.UsernameErorLable.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErorLable.Location = new System.Drawing.Point(221, 7);
            this.UsernameErorLable.Name = "UsernameErorLable";
            this.UsernameErorLable.Size = new System.Drawing.Size(26, 29);
            this.UsernameErorLable.TabIndex = 7;
            this.UsernameErorLable.Text = "*";
            this.UsernameErorLable.Visible = false;
            // 
            // PasswordErorLable
            // 
            this.PasswordErorLable.AutoSize = true;
            this.PasswordErorLable.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErorLable.Location = new System.Drawing.Point(221, 63);
            this.PasswordErorLable.Name = "PasswordErorLable";
            this.PasswordErorLable.Size = new System.Drawing.Size(26, 29);
            this.PasswordErorLable.TabIndex = 8;
            this.PasswordErorLable.Text = "*";
            this.PasswordErorLable.Visible = false;
            // 
            // ExttBtn
            // 
            this.ExttBtn.BackColor = System.Drawing.Color.Orange;
            this.ExttBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExttBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ExttBtn.FlatAppearance.BorderSize = 2;
            this.ExttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExttBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExttBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ExttBtn.Image = global::CNINE_Fee_Management.Properties.Resources.BackButton;
            this.ExttBtn.Location = new System.Drawing.Point(0, 486);
            this.ExttBtn.Name = "ExttBtn";
            this.ExttBtn.Size = new System.Drawing.Size(250, 43);
            this.ExttBtn.TabIndex = 5;
            this.ExttBtn.Text = "E&xit";
            this.ExttBtn.UseVisualStyleBackColor = false;
            this.ExttBtn.Click += new System.EventHandler(this.ExttBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Headliner No. 45", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1192, 529);
            this.button1.TabIndex = 1;
            this.button1.Text = "CNine";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("StyleFormal", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Welcome,";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogIn
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 574);
            this.ControlBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExttBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PasswordErorLable;
        private System.Windows.Forms.Label UsernameErorLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}
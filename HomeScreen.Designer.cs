namespace CNINE_Fee_Management
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StaffBtn = new System.Windows.Forms.Button();
            this.FeeBtn = new System.Windows.Forms.Button();
            this.StudentBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(250, 781);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(250, 45);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(250, 0);
            this.RightPanel.Size = new System.Drawing.Size(1257, 781);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Size = new System.Drawing.Size(1257, 45);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Violet;
            this.panel2.Size = new System.Drawing.Size(250, 736);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Size = new System.Drawing.Size(1257, 736);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.StaffBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FeeBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StudentBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1257, 711);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.Salmon;
            this.StaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffBtn.FlatAppearance.BorderSize = 7;
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StaffBtn.Location = new System.Drawing.Point(3, 3);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Size = new System.Drawing.Size(1251, 231);
            this.StaffBtn.TabIndex = 0;
            this.StaffBtn.Text = "Staff";
            this.StaffBtn.UseVisualStyleBackColor = false;
            this.StaffBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeeBtn
            // 
            this.FeeBtn.BackColor = System.Drawing.Color.Gold;
            this.FeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FeeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeeBtn.FlatAppearance.BorderSize = 5;
            this.FeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeeBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FeeBtn.Location = new System.Drawing.Point(3, 240);
            this.FeeBtn.Name = "FeeBtn";
            this.FeeBtn.Size = new System.Drawing.Size(1251, 231);
            this.FeeBtn.TabIndex = 1;
            this.FeeBtn.Text = "Fee Management";
            this.FeeBtn.UseVisualStyleBackColor = false;
            this.FeeBtn.Click += new System.EventHandler(this.FeeBtn_Click);
            // 
            // StudentBtn
            // 
            this.StudentBtn.BackColor = System.Drawing.Color.Cyan;
            this.StudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentBtn.FlatAppearance.BorderSize = 3;
            this.StudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.StudentBtn.Location = new System.Drawing.Point(3, 477);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(1251, 231);
            this.StudentBtn.TabIndex = 2;
            this.StudentBtn.Text = "Student Detail";
            this.StudentBtn.UseVisualStyleBackColor = false;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1257, 25);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Screen";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 781);
            this.ControlBox = false;
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StaffBtn;
        private System.Windows.Forms.Button FeeBtn;
        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Panel panel5;
    }
}
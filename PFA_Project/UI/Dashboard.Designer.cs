namespace PFA_Project.UI
{
    partial class Dashboard
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
            panel2 = new Panel();
            lblExp1 = new Label();
            lblExp = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblFund = new Label();
            label1 = new Label();
            panelUser = new Panel();
            labelName = new Label();
            labelCountUser = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(lblExp1);
            panel2.Controls.Add(lblExp);
            panel2.Location = new Point(260, 306);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 85);
            panel2.TabIndex = 15;
            // 
            // lblExp1
            // 
            lblExp1.AutoSize = true;
            lblExp1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExp1.ForeColor = SystemColors.GradientActiveCaption;
            lblExp1.Location = new Point(14, 29);
            lblExp1.Margin = new Padding(4, 0, 4, 0);
            lblExp1.Name = "lblExp1";
            lblExp1.Size = new Size(203, 29);
            lblExp1.TabIndex = 1;
            lblExp1.Text = "Total Expentidure";
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblExp.ForeColor = SystemColors.ButtonFace;
            lblExp.Location = new Point(225, 25);
            lblExp.Margin = new Padding(4, 0, 4, 0);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(33, 36);
            lblExp.TabIndex = 0;
            lblExp.Text = "0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblFund);
            panel1.Location = new Point(260, 211);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 85);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(4, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 29);
            label2.TabIndex = 1;
            label2.Text = "Total Funds";
            // 
            // lblFund
            // 
            lblFund.AutoSize = true;
            lblFund.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFund.ForeColor = SystemColors.ButtonFace;
            lblFund.Location = new Point(203, 20);
            lblFund.Margin = new Padding(4, 0, 4, 0);
            lblFund.Name = "lblFund";
            lblFund.Size = new Size(33, 36);
            lblFund.TabIndex = 0;
            lblFund.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(274, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 39);
            label1.TabIndex = 16;
            label1.Text = "DASHBOARD";
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.None;
            panelUser.BackColor = Color.SteelBlue;
            panelUser.Controls.Add(labelName);
            panelUser.Controls.Add(labelCountUser);
            panelUser.Location = new Point(260, 116);
            panelUser.Margin = new Padding(4, 5, 4, 5);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(280, 85);
            panelUser.TabIndex = 13;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.GradientActiveCaption;
            labelName.Location = new Point(4, 26);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(137, 29);
            labelName.TabIndex = 1;
            labelName.Text = "Total Users";
            // 
            // labelCountUser
            // 
            labelCountUser.AutoSize = true;
            labelCountUser.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountUser.ForeColor = SystemColors.ButtonFace;
            labelCountUser.Location = new Point(203, 20);
            labelCountUser.Margin = new Padding(4, 0, 4, 0);
            labelCountUser.Name = "labelCountUser";
            labelCountUser.Size = new Size(33, 36);
            labelCountUser.TabIndex = 0;
            labelCountUser.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panelUser);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblExp1;
        private Label lblExp;
        private Panel panel1;
        private Label label2;
        private Label lblFund;
        private Label label1;
        private Panel panelUser;
        private Label labelName;
        private Label labelCountUser;
    }
}
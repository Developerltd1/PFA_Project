namespace PFA_Project.UI
{
    partial class frmFunds
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
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
       
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbFundType = new ComboBox();
            lblFundType = new Label();
            dgvDonors = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblAmount = new Label();
            txtDonorID = new TextBox();
            lblDonorID = new Label();
            txtAmount = new TextBox();
            txtDetails = new TextBox();
            lblAddress = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(502, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 1;
            label1.Text = "Runds Received Form";
            // 
            // cmbFundType
            // 
            cmbFundType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFundType.FormattingEnabled = true;
            cmbFundType.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbFundType.Location = new Point(219, 131);
            cmbFundType.Margin = new Padding(4, 5, 4, 5);
            cmbFundType.Name = "cmbFundType";
            cmbFundType.Size = new Size(451, 29);
            cmbFundType.TabIndex = 72;
            // 
            // lblFundType
            // 
            lblFundType.AutoSize = true;
            lblFundType.Location = new Point(40, 130);
            lblFundType.Margin = new Padding(4, 0, 4, 0);
            lblFundType.Name = "lblFundType";
            lblFundType.Size = new Size(76, 20);
            lblFundType.TabIndex = 71;
            lblFundType.Text = "Fund Type";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(13, 350);
            dgvDonors.Margin = new Padding(4, 5, 4, 5);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(1209, 376);
            dgvDonors.TabIndex = 69;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGoldenrod;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(939, 220);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 65);
            btnClear.TabIndex = 68;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(778, 221);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 65);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(939, 138);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 65);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(778, 138);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 65);
            btnAdd.TabIndex = 65;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(40, 175);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(59, 19);
            lblAmount.TabIndex = 61;
            lblAmount.Text = "Amount";
            // 
            // txtDonorID
            // 
            txtDonorID.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            txtDonorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonorID.Location = new Point(219, 83);
            txtDonorID.Margin = new Padding(4, 5, 4, 5);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.ReadOnly = true;
            txtDonorID.Size = new Size(451, 29);
            txtDonorID.TabIndex = 56;
            // 
            // lblDonorID
            // 
            lblDonorID.AutoSize = true;
            lblDonorID.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDonorID.Location = new Point(36, 88);
            lblDonorID.Margin = new Padding(4, 0, 4, 0);
            lblDonorID.Name = "lblDonorID";
            lblDonorID.Size = new Size(0, 19);
            lblDonorID.TabIndex = 55;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(219, 175);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(451, 29);
            txtAmount.TabIndex = 73;
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetails.Location = new Point(219, 221);
            txtDetails.Margin = new Padding(4, 5, 4, 5);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(451, 101);
            txtDetails.TabIndex = 75;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(42, 226);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(50, 19);
            lblAddress.TabIndex = 74;
            lblAddress.Text = "Details";
            // 
            // frmFunds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 740);
            Controls.Add(txtDetails);
            Controls.Add(lblAddress);
            Controls.Add(txtAmount);
            Controls.Add(cmbFundType);
            Controls.Add(lblFundType);
            Controls.Add(dgvDonors);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblAmount);
            Controls.Add(txtDonorID);
            Controls.Add(lblDonorID);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmFunds";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ComboBox cmbBloodGroup;
        private Label lblBloodGroup;
        private ComboBox cmbFundType;
        private Label lblFundType;
        private DataGridView dgvDonors;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtDetails;
        private Label lblAddress;
        private TextBox txtContact;
        private Label lblAmount;
        private TextBox txtDonorID;
        private Label lblDonorID;
        private TextBox txtAmount;
    }
}
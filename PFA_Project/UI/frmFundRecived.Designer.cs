namespace PFA_Project.UI
{
    partial class frmFundRecived
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
            groupBox2 = new GroupBox();
            txtExpID = new TextBox();
            txtFundTypeID = new TextBox();
            lblAmount = new Label();
            txtDetails = new TextBox();
            btnAdd = new Button();
            lblAddress = new Label();
            btnUpdate = new Button();
            txtAmount = new TextBox();
            btnDelete = new Button();
            cmbFundType = new ComboBox();
            btnClear = new Button();
            lblFundType = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dgvExpentidure = new DataGridView();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpentidure).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtExpID);
            groupBox2.Controls.Add(txtFundTypeID);
            groupBox2.Controls.Add(lblAmount);
            groupBox2.Controls.Add(txtDetails);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(lblAddress);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(cmbFundType);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(lblFundType);
            groupBox2.Location = new Point(7, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1211, 303);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opration Panel";
            // 
            // txtExpID
            // 
            txtExpID.Anchor = AnchorStyles.None;
            txtExpID.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            txtExpID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpID.Location = new Point(224, 35);
            txtExpID.Margin = new Padding(5);
            txtExpID.Name = "txtExpID";
            txtExpID.ReadOnly = true;
            txtExpID.Size = new Size(138, 29);
            txtExpID.TabIndex = 56;
            txtExpID.Visible = false;
            // 
            // txtFundTypeID
            // 
            txtFundTypeID.Anchor = AnchorStyles.None;
            txtFundTypeID.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            txtFundTypeID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFundTypeID.Location = new Point(372, 35);
            txtFundTypeID.Margin = new Padding(5);
            txtFundTypeID.Name = "txtFundTypeID";
            txtFundTypeID.ReadOnly = true;
            txtFundTypeID.Size = new Size(138, 29);
            txtFundTypeID.TabIndex = 77;
            txtFundTypeID.Visible = false;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.None;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(74, 127);
            lblAmount.Margin = new Padding(5, 0, 5, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(66, 19);
            lblAmount.TabIndex = 61;
            lblAmount.Text = "Amount: ";
            // 
            // txtDetails
            // 
            txtDetails.Anchor = AnchorStyles.None;
            txtDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetails.Location = new Point(224, 173);
            txtDetails.Margin = new Padding(5);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(491, 101);
            txtDetails.TabIndex = 75;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(738, 87);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 86);
            btnAdd.TabIndex = 65;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(76, 179);
            lblAddress.Margin = new Padding(5, 0, 5, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 19);
            lblAddress.TabIndex = 74;
            lblAddress.Text = "Details: ";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(944, 87);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(195, 86);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(224, 127);
            txtAmount.Margin = new Padding(5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(491, 29);
            txtAmount.TabIndex = 73;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(738, 182);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(196, 82);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbFundType
            // 
            cmbFundType.Anchor = AnchorStyles.None;
            cmbFundType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFundType.FormattingEnabled = true;
            cmbFundType.Location = new Point(224, 83);
            cmbFundType.Margin = new Padding(5);
            cmbFundType.Name = "cmbFundType";
            cmbFundType.Size = new Size(491, 29);
            cmbFundType.TabIndex = 72;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.DarkGoldenrod;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(944, 181);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(195, 82);
            btnClear.TabIndex = 68;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblFundType
            // 
            lblFundType.Anchor = AnchorStyles.None;
            lblFundType.AutoSize = true;
            lblFundType.Location = new Point(74, 83);
            lblFundType.Margin = new Padding(5, 0, 5, 0);
            lblFundType.Name = "lblFundType";
            lblFundType.Size = new Size(83, 20);
            lblFundType.TabIndex = 71;
            lblFundType.Text = "Fund Type: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(7, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1211, 360);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Display Panel";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dgvExpentidure);
            groupBox3.Location = new Point(6, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1195, 302);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            // 
            // dgvExpentidure
            // 
            dgvExpentidure.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpentidure.Dock = DockStyle.Fill;
            dgvExpentidure.Location = new Point(3, 23);
            dgvExpentidure.Margin = new Padding(5);
            dgvExpentidure.Name = "dgvExpentidure";
            dgvExpentidure.RowHeadersWidth = 51;
            dgvExpentidure.Size = new Size(1189, 276);
            dgvExpentidure.TabIndex = 69;
            dgvExpentidure.CellClick += dgvExpentidure_CellClick;
            dgvExpentidure.CellContentClick += dgvExpentidure_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 81;
            label1.Text = "Fund Recived Form";
            // 
            // frmFundRecived
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 740);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmFundRecived";
            Text = "frmFundRecived";
            WindowState = FormWindowState.Maximized;
            Load += frmFundRecived_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpentidure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtExpID;
        private TextBox txtFundTypeID;
        private Label lblAmount;
        private TextBox txtDetails;
        private Button btnAdd;
        private Label lblAddress;
        private Button btnUpdate;
        private TextBox txtAmount;
        private Button btnDelete;
        private ComboBox cmbFundType;
        private Button btnClear;
        private Label lblFundType;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dgvExpentidure;
        private Label label1;
    }
}
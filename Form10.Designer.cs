namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form10
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
            btnBack = new Button();
            txtName = new TextBox();
            txtSpecialty = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            dgvData = new DataGridView();
            label4 = new Label();
            txtFees = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(796, 553);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 451);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(214, 532);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(150, 31);
            txtSpecialty.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 457);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 3;
            label1.Text = "Trainer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 532);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 4;
            label2.Text = "Specialty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 376);
            label3.Name = "label3";
            label3.Size = new Size(28, 25);
            label3.TabIndex = 5;
            label3.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(214, 373);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 6;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(29, 46);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.Size = new Size(910, 309);
            dgvData.TabIndex = 7;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 495);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 8;
            label4.Text = "Fees(per session)";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(586, 489);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(150, 31);
            txtFees.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SpringGreen;
            btnAdd.Location = new Point(796, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 50);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(796, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 50);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(796, 495);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 50);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Location = new Point(639, 558);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 50);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 628);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtFees);
            Controls.Add(label4);
            Controls.Add(dgvData);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSpecialty);
            Controls.Add(txtName);
            Controls.Add(btnBack);
            Name = "Form10";
            Text = "Manage Fitness Trainers";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txtName;
        private TextBox txtSpecialty;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private DataGridView dgvData;
        private Label label4;
        private TextBox txtFees;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
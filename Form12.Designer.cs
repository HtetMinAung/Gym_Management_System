namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form12
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
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            dgvData = new DataGridView();
            txttype = new TextBox();
            txtGymTime = new TextBox();
            txtEquipment = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtId = new TextBox();
            btnClear = new Button();
            cboIntensity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(783, 458);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 476);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 30;
            label3.Text = "Equipment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 394);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 28;
            label2.Text = "Intensity level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 495);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 27;
            label7.Text = "Gym time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 409);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 24;
            label1.Text = "Types of Workout";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 12);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.Size = new Size(939, 269);
            dgvData.TabIndex = 31;
            dgvData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txttype
            // 
            txttype.Location = new Point(215, 406);
            txttype.Name = "txttype";
            txttype.Size = new Size(150, 31);
            txttype.TabIndex = 32;
            // 
            // txtGymTime
            // 
            txtGymTime.Location = new Point(215, 492);
            txtGymTime.Name = "txtGymTime";
            txtGymTime.Size = new Size(150, 31);
            txtGymTime.TabIndex = 33;
            // 
            // txtEquipment
            // 
            txtEquipment.Location = new Point(559, 476);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(150, 31);
            txtEquipment.TabIndex = 35;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SpringGreen;
            btnInsert.Location = new Point(783, 328);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 36;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(783, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(783, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 328);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 39;
            label4.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(215, 331);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 40;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(783, 513);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cboIntensity
            // 
            cboIntensity.FormattingEnabled = true;
            cboIntensity.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
            cboIntensity.Location = new Point(559, 391);
            cboIntensity.Name = "cboIntensity";
            cboIntensity.Size = new Size(150, 33);
            cboIntensity.TabIndex = 42;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 585);
            Controls.Add(cboIntensity);
            Controls.Add(btnClear);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtEquipment);
            Controls.Add(txtGymTime);
            Controls.Add(txttype);
            Controls.Add(dgvData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "Form12";
            Text = "Manage Training Sessions";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private DataGridView dgvData;
        private TextBox txttype;
        private TextBox txtGymTime;
        private TextBox txtEquipment;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private TextBox txtId;
        private Button btnClear;
        private ComboBox cboIntensity;
    }
}
namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form9
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
            cboSpecialty = new ComboBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(680, 304);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 65);
            btnBack.TabIndex = 0;
            btnBack.Text = "Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 206);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 3;
            label3.Text = "Specialty";
            // 
            // cboSpecialty
            // 
            cboSpecialty.FormattingEnabled = true;
            cboSpecialty.Items.AddRange(new object[] { "Cardio", "Functional Training", "Resistance Training", "Yoga" });
            cboSpecialty.Location = new Point(344, 206);
            cboSpecialty.Name = "cboSpecialty";
            cboSpecialty.Size = new Size(232, 33);
            cboSpecialty.TabIndex = 5;
            cboSpecialty.Text = "Choose trainer specialty";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(680, 194);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 76);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(680, 88);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 72);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(159, 403);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.Size = new Size(708, 217);
            dgvData.TabIndex = 32;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 681);
            Controls.Add(dgvData);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(cboSpecialty);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Name = "Form9";
            Text = "Fitness Trainers";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label3;
        private ComboBox cboSpecialty;
        private Button btnRefresh;
        private Button btnSearch;
        private DataGridView dgvData;
    }
}
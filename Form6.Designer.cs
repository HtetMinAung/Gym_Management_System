namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form6
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
            label1 = new Label();
            cboType = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            cboInlvl = new ComboBox();
            btnSearch = new Button();
            dgvData = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 75);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Types of Workout";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Cardio", "Yoga", "Functional training", "resistance Training" });
            cboType.Location = new Point(309, 67);
            cboType.Name = "cboType";
            cboType.Size = new Size(236, 33);
            cboType.TabIndex = 1;
            cboType.Text = "Choose A Workout Plan";
            // 
            // button1
            // 
            button1.Location = new Point(816, 224);
            button1.Name = "button1";
            button1.Size = new Size(112, 72);
            button1.TabIndex = 19;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 172);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 20;
            label2.Text = "Intensity level";
            // 
            // cboInlvl
            // 
            cboInlvl.FormattingEnabled = true;
            cboInlvl.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced" });
            cboInlvl.Location = new Point(309, 164);
            cboInlvl.Name = "cboInlvl";
            cboInlvl.Size = new Size(236, 33);
            cboInlvl.TabIndex = 21;
            cboInlvl.Text = "Choose your level";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(816, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 72);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(34, 377);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.RowTemplate.Height = 33;
            dgvData.Size = new Size(1089, 289);
            dgvData.TabIndex = 27;
            // 
            // button2
            // 
            button2.Location = new Point(816, 121);
            button2.Name = "button2";
            button2.Size = new Size(112, 76);
            button2.TabIndex = 28;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 678);
            Controls.Add(button2);
            Controls.Add(dgvData);
            Controls.Add(btnSearch);
            Controls.Add(cboInlvl);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(cboType);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Training Sessions";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboType;
        private Button button1;
        private Label label2;
        private ComboBox cboInlvl;
        private Button btnSearch;
        private DataGridView dgvData;
        private Button button2;
    }
}
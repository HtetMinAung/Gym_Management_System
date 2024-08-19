namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form7
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnShow = new Button();
            txtconfidential = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(604, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Software", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 27);
            label1.Name = "label1";
            label1.Size = new Size(429, 54);
            label1.TabIndex = 1;
            label1.Text = "Member information";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Cyan;
            btnBack.Location = new Point(848, 490);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 396);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 490);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 393);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtID
            // 
            txtID.Location = new Point(214, 390);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(214, 490);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(585, 387);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.Location = new Point(848, 326);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 46);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(848, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 47);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(585, 445);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(150, 32);
            btnShow.TabIndex = 13;
            btnShow.Text = "Show anyway";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtconfidential
            // 
            txtconfidential.BackColor = Color.Red;
            txtconfidential.Location = new Point(585, 390);
            txtconfidential.Name = "txtconfidential";
            txtconfidential.Size = new Size(150, 31);
            txtconfidential.TabIndex = 14;
            txtconfidential.Text = "Confidential";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 657);
            Controls.Add(txtconfidential);
            Controls.Add(btnShow);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form7";
            Text = "Manage Members";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnShow;
        private TextBox txtconfidential;
    }
}
namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form4
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
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnReturn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.ControlText;
            txtUsername.Location = new Point(123, 184);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(348, 42);
            txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(123, 122);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 5;
            label2.Text = "Create Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(123, 261);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 6;
            label3.Text = "Create Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.Location = new Point(123, 323);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(348, 47);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(123, 414);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 8;
            label1.Text = "Confirm Password";
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.ForeColor = SystemColors.ControlText;
            txtConfirm.Location = new Point(123, 464);
            txtConfirm.Multiline = true;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(348, 47);
            txtConfirm.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(586, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(279, 50);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SeaGreen;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(586, 414);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(279, 54);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Go to Login Page";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Software", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(193, 9);
            label4.Name = "label4";
            label4.Size = new Size(530, 54);
            label4.TabIndex = 12;
            label4.Text = "New Member Registration";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 600);
            Controls.Add(label4);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Name = "Form4";
            Text = "Sign up Page";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnReturn;
        private Label label4;
    }
}
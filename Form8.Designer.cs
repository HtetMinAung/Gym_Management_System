namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form8
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
            dgv1 = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            cboHeightin = new ComboBox();
            cboHeightft = new ComboBox();
            txtkg = new Label();
            label13 = new Label();
            txtWeight = new TextBox();
            txtAge = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            label6 = new Label();
            cboDuration = new ComboBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            rtBAddress = new RichTextBox();
            rdbF = new RadioButton();
            rdbM = new RadioButton();
            txtName = new TextBox();
            btnUpdate = new Button();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(0, 93);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 62;
            dgv1.RowTemplate.Height = 33;
            dgv1.Size = new Size(1506, 264);
            dgv1.TabIndex = 0;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Software", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(501, 54);
            label1.TabIndex = 2;
            label1.Text = "Enrollment information";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Location = new Point(1151, 542);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cboHeightin
            // 
            cboHeightin.FormattingEnabled = true;
            cboHeightin.Items.AddRange(new object[] { "00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" });
            cboHeightin.Location = new Point(785, 461);
            cboHeightin.Name = "cboHeightin";
            cboHeightin.Size = new Size(58, 33);
            cboHeightin.TabIndex = 63;
            // 
            // cboHeightft
            // 
            cboHeightft.FormattingEnabled = true;
            cboHeightft.Items.AddRange(new object[] { "4", "5", "6", "7" });
            cboHeightft.Location = new Point(700, 461);
            cboHeightft.Name = "cboHeightft";
            cboHeightft.Size = new Size(58, 33);
            cboHeightft.TabIndex = 62;
            // 
            // txtkg
            // 
            txtkg.AutoSize = true;
            txtkg.Location = new Point(838, 557);
            txtkg.Name = "txtkg";
            txtkg.Size = new Size(42, 25);
            txtkg.TabIndex = 61;
            txtkg.Text = "(kg)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(805, 557);
            label13.Name = "label13";
            label13.Size = new Size(27, 25);
            label13.TabIndex = 60;
            label13.Text = "lb";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(714, 554);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(81, 31);
            txtWeight.TabIndex = 59;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(279, 632);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(86, 31);
            txtAge.TabIndex = 58;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(854, 465);
            label12.Name = "label12";
            label12.Size = new Size(26, 25);
            label12.TabIndex = 57;
            label12.Text = "in";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(756, 465);
            label11.Name = "label11";
            label11.Size = new Size(24, 25);
            label11.TabIndex = 56;
            label11.Text = "ft";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(617, 554);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 55;
            label10.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 462);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 54;
            label7.Text = "Height";
            // 
            // txtID
            // 
            txtID.Location = new Point(279, 389);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(196, 31);
            txtID.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 395);
            label6.Name = "label6";
            label6.Size = new Size(28, 25);
            label6.TabIndex = 52;
            label6.Text = "Id";
            // 
            // cboDuration
            // 
            cboDuration.FormattingEnabled = true;
            cboDuration.Items.AddRange(new object[] { "1month", "3months", "6months", "1year" });
            cboDuration.Location = new Point(634, 869);
            cboDuration.Name = "cboDuration";
            cboDuration.Size = new Size(182, 33);
            cboDuration.TabIndex = 51;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(279, 805);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 31);
            txtEmail.TabIndex = 50;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(279, 721);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(196, 31);
            txtMobile.TabIndex = 49;
            // 
            // rtBAddress
            // 
            rtBAddress.Location = new Point(718, 632);
            rtBAddress.Name = "rtBAddress";
            rtBAddress.Size = new Size(240, 114);
            rtBAddress.TabIndex = 48;
            rtBAddress.Text = "";
            // 
            // rdbF
            // 
            rdbF.AutoSize = true;
            rdbF.Location = new Point(382, 537);
            rdbF.Name = "rdbF";
            rdbF.Size = new Size(93, 29);
            rdbF.TabIndex = 47;
            rdbF.TabStop = true;
            rdbF.Text = "Female";
            rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            rdbM.AutoSize = true;
            rdbM.Location = new Point(290, 535);
            rdbM.Name = "rdbM";
            rdbM.Size = new Size(75, 29);
            rdbM.TabIndex = 46;
            rdbM.TabStop = true;
            rdbM.Text = "Male";
            rdbM.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(279, 456);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 31);
            txtName.TabIndex = 45;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SeaGreen;
            btnUpdate.Location = new Point(1151, 465);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 54);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(446, 872);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 43;
            label9.Text = "Member Duration";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 632);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 42;
            label8.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 805);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 41;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 721);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 40;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 632);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 39;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 535);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 38;
            label2.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(189, 456);
            label14.Name = "label14";
            label14.Size = new Size(59, 25);
            label14.TabIndex = 37;
            label14.Text = "Name";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(1151, 627);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(112, 57);
            btnMenu.TabIndex = 64;
            btnMenu.Text = "Main Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnMenu);
            Controls.Add(cboHeightin);
            Controls.Add(cboHeightft);
            Controls.Add(txtkg);
            Controls.Add(label13);
            Controls.Add(txtWeight);
            Controls.Add(txtAge);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(cboDuration);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(rtBAddress);
            Controls.Add(rdbF);
            Controls.Add(rdbM);
            Controls.Add(txtName);
            Controls.Add(btnUpdate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dgv1);
            Name = "Form8";
            Text = "Admin Control for Enrollment";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Label label1;
        private Button btnDelete;
        private ComboBox cboHeightin;
        private ComboBox cboHeightft;
        private Label txtkg;
        private Label label13;
        private TextBox txtWeight;
        private TextBox txtAge;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private TextBox txtID;
        private Label label6;
        private ComboBox cboDuration;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private RichTextBox rtBAddress;
        private RadioButton rdbF;
        private RadioButton rdbM;
        private TextBox txtName;
        private Button btnUpdate;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label14;
        private Button btnMenu;
    }
}
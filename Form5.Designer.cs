namespace COS210_Assignment_by_Htet_Min_Aung
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnTrainers = new FontAwesome.Sharp.IconButton();
            btnEnroll = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panelMenu = new Panel();
            btnTS = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(890, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(64, 64, 64);
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 75;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 377);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 20, 0);
            btnExit.Size = new Size(214, 102);
            btnExit.TabIndex = 5;
            btnExit.Text = "Logout";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnTrainers
            // 
            btnTrainers.BackColor = Color.FromArgb(64, 64, 64);
            btnTrainers.Dock = DockStyle.Top;
            btnTrainers.FlatAppearance.BorderSize = 0;
            btnTrainers.FlatStyle = FlatStyle.Flat;
            btnTrainers.ForeColor = SystemColors.ButtonFace;
            btnTrainers.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            btnTrainers.IconColor = Color.Black;
            btnTrainers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnTrainers.IconSize = 75;
            btnTrainers.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrainers.Location = new Point(0, 283);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Padding = new Padding(5, 0, 20, 0);
            btnTrainers.Size = new Size(214, 94);
            btnTrainers.TabIndex = 4;
            btnTrainers.Text = "Fitness Trainers";
            btnTrainers.TextAlign = ContentAlignment.MiddleLeft;
            btnTrainers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrainers.UseVisualStyleBackColor = false;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(64, 64, 64);
            btnEnroll.Dock = DockStyle.Top;
            btnEnroll.FlatAppearance.BorderSize = 0;
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.ForeColor = SystemColors.ButtonFace;
            btnEnroll.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            btnEnroll.IconColor = Color.Black;
            btnEnroll.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnEnroll.IconSize = 75;
            btnEnroll.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnroll.Location = new Point(0, 179);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Padding = new Padding(5, 0, 20, 0);
            btnEnroll.Size = new Size(214, 104);
            btnEnroll.TabIndex = 3;
            btnEnroll.Text = "Enroll";
            btnEnroll.TextAlign = ContentAlignment.MiddleLeft;
            btnEnroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(64, 64, 64);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(214, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnTrainers);
            panelMenu.Controls.Add(btnEnroll);
            panelMenu.Controls.Add(btnTS);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ControlText;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 523);
            panelMenu.TabIndex = 1;
            // 
            // btnTS
            // 
            btnTS.BackColor = Color.FromArgb(64, 64, 64);
            btnTS.Dock = DockStyle.Top;
            btnTS.FlatAppearance.BorderSize = 0;
            btnTS.FlatStyle = FlatStyle.Flat;
            btnTS.ForeColor = SystemColors.ButtonFace;
            btnTS.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            btnTS.IconColor = Color.Black;
            btnTS.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnTS.IconSize = 75;
            btnTS.ImageAlign = ContentAlignment.MiddleLeft;
            btnTS.Location = new Point(0, 80);
            btnTS.Name = "btnTS";
            btnTS.Padding = new Padding(5, 0, 20, 0);
            btnTS.Size = new Size(214, 99);
            btnTS.TabIndex = 2;
            btnTS.Text = "Training Sessions";
            btnTS.TextAlign = ContentAlignment.MiddleLeft;
            btnTS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTS.UseVisualStyleBackColor = false;
            btnTS.Click += btnTS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Software", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(344, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 44);
            label2.TabIndex = 2;
            label2.Text = "Welcome to our Gym";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 523);
            Controls.Add(label2);
            Controls.Add(panelMenu);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Member HomeScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnTrainers;
        private FontAwesome.Sharp.IconButton btnEnroll;
        private Panel panelLogo;
        private Panel panelMenu;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnTS;
    }
}
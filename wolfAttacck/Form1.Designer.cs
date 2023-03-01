namespace wolfAttacck
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.pgbWolfman = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOurHealth = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pgbWolfman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "etnic group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "branch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "weapon:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(175, 417);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(126, 30);
            this.txtWeapon.TabIndex = 1;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "warrior",
            "mage",
            "archer",
            "wizard"});
            this.cmbBranch.Location = new System.Drawing.Point(175, 328);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 33);
            this.cmbBranch.TabIndex = 2;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "human",
            "monster"});
            this.cmbRace.Location = new System.Drawing.Point(175, 238);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 33);
            this.cmbRace.TabIndex = 2;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(344, 407);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(146, 50);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "choose";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // pgbWolfman
            // 
            this.pgbWolfman.Image = global::wolfAttacck.Properties.Resources.dragon1;
            this.pgbWolfman.Location = new System.Drawing.Point(759, 143);
            this.pgbWolfman.Name = "pgbWolfman";
            this.pgbWolfman.Size = new System.Drawing.Size(429, 231);
            this.pgbWolfman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgbWolfman.TabIndex = 4;
            this.pgbWolfman.TabStop = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.DarkRed;
            this.lblHealth.Location = new System.Drawing.Point(820, 76);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(330, 33);
            this.lblHealth.TabIndex = 5;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(888, 407);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(146, 50);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Our health:";
            // 
            // lblOurHealth
            // 
            this.lblOurHealth.BackColor = System.Drawing.Color.DarkRed;
            this.lblOurHealth.Location = new System.Drawing.Point(170, 76);
            this.lblOurHealth.Name = "lblOurHealth";
            this.lblOurHealth.Size = new System.Drawing.Size(250, 25);
            this.lblOurHealth.TabIndex = 7;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(888, 545);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(146, 50);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblOurHealth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pgbWolfman);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pgbWolfman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.PictureBox pgbWolfman;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOurHealth;
        private System.Windows.Forms.Button btnRestart;
    }
}


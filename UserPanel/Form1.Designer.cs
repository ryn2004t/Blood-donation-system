namespace UserPanel
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.donorinfo = new System.Windows.Forms.TabPage();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.gender1 = new System.Windows.Forms.ComboBox();
            this.blood = new System.Windows.Forms.ComboBox();
            this.age1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hospital = new System.Windows.Forms.TabPage();
            this.placebox = new System.Windows.Forms.GroupBox();
            this.gm = new System.Windows.Forms.CheckBox();
            this.jb = new System.Windows.Forms.CheckBox();
            this.jn = new System.Windows.Forms.CheckBox();
            this.an = new System.Windows.Forms.CheckBox();
            this.sp = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link2 = new System.Windows.Forms.LinkLabel();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.dsc = new System.Windows.Forms.RadioButton();
            this.redcross = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.donorinfo.SuspendLayout();
            this.hospital.SuspendLayout();
            this.placebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to User Panel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(31, 9, 0, 9);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUpdateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveUpdateToolStripMenuItem
            // 
            this.saveUpdateToolStripMenuItem.Name = "saveUpdateToolStripMenuItem";
            this.saveUpdateToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.saveUpdateToolStripMenuItem.Text = "Save update";
            this.saveUpdateToolStripMenuItem.Click += new System.EventHandler(this.saveUpdateToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.donorinfo);
            this.tabControl1.Controls.Add(this.hospital);
            this.tabControl1.Controls.Add(this.save);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 187);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 435);
            this.tabControl1.TabIndex = 2;
            // 
            // donorinfo
            // 
            this.donorinfo.Controls.Add(this.date);
            this.donorinfo.Controls.Add(this.gender1);
            this.donorinfo.Controls.Add(this.blood);
            this.donorinfo.Controls.Add(this.age1);
            this.donorinfo.Controls.Add(this.label6);
            this.donorinfo.Controls.Add(this.label5);
            this.donorinfo.Controls.Add(this.label4);
            this.donorinfo.Controls.Add(this.label2);
            this.donorinfo.Location = new System.Drawing.Point(4, 34);
            this.donorinfo.Name = "donorinfo";
            this.donorinfo.Padding = new System.Windows.Forms.Padding(3);
            this.donorinfo.Size = new System.Drawing.Size(1168, 397);
            this.donorinfo.TabIndex = 0;
            this.donorinfo.Text = "Donor Info ";
            this.donorinfo.UseVisualStyleBackColor = true;
            this.donorinfo.Click += new System.EventHandler(this.donorinfo_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(224, 112);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(570, 30);
            this.date.TabIndex = 9;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // gender1
            // 
            this.gender1.FormattingEnabled = true;
            this.gender1.Location = new System.Drawing.Point(224, 266);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(570, 33);
            this.gender1.TabIndex = 8;
            // 
            // blood
            // 
            this.blood.FormattingEnabled = true;
            this.blood.Location = new System.Drawing.Point(224, 37);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(570, 33);
            this.blood.TabIndex = 7;
            this.blood.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // age1
            // 
            this.age1.Location = new System.Drawing.Point(224, 181);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(570, 30);
            this.age1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.age1, "age must be 18 -> 55");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bloog Group";
            // 
            // hospital
            // 
            this.hospital.Controls.Add(this.placebox);
            this.hospital.Controls.Add(this.pictureBox2);
            this.hospital.Controls.Add(this.pictureBox1);
            this.hospital.Controls.Add(this.link2);
            this.hospital.Controls.Add(this.link1);
            this.hospital.Controls.Add(this.dsc);
            this.hospital.Controls.Add(this.redcross);
            this.hospital.Location = new System.Drawing.Point(4, 34);
            this.hospital.Name = "hospital";
            this.hospital.Padding = new System.Windows.Forms.Padding(3);
            this.hospital.Size = new System.Drawing.Size(1168, 397);
            this.hospital.TabIndex = 1;
            this.hospital.Text = "Hospital";
            this.hospital.UseVisualStyleBackColor = true;
            this.hospital.Click += new System.EventHandler(this.hospital_Click);
            // 
            // placebox
            // 
            this.placebox.Controls.Add(this.gm);
            this.placebox.Controls.Add(this.jb);
            this.placebox.Controls.Add(this.jn);
            this.placebox.Controls.Add(this.an);
            this.placebox.Controls.Add(this.sp);
            this.placebox.Location = new System.Drawing.Point(857, 21);
            this.placebox.Name = "placebox";
            this.placebox.Size = new System.Drawing.Size(304, 370);
            this.placebox.TabIndex = 8;
            this.placebox.TabStop = false;
            this.placebox.Text = "Choose a Place";
            // 
            // gm
            // 
            this.gm.AutoSize = true;
            this.gm.Location = new System.Drawing.Point(25, 113);
            this.gm.Name = "gm";
            this.gm.Size = new System.Drawing.Size(134, 29);
            this.gm.TabIndex = 4;
            this.gm.Text = "Gemmayz";
            this.gm.UseVisualStyleBackColor = true;
            // 
            // jb
            // 
            this.jb.AutoSize = true;
            this.jb.Location = new System.Drawing.Point(25, 273);
            this.jb.Name = "jb";
            this.jb.Size = new System.Drawing.Size(84, 29);
            this.jb.TabIndex = 3;
            this.jb.Text = "Jbeil";
            this.jb.UseVisualStyleBackColor = true;
            // 
            // jn
            // 
            this.jn.AutoSize = true;
            this.jn.Location = new System.Drawing.Point(25, 220);
            this.jn.Name = "jn";
            this.jn.Size = new System.Drawing.Size(115, 29);
            this.jn.TabIndex = 2;
            this.jn.Text = "Jounieh";
            this.jn.UseVisualStyleBackColor = true;
            // 
            // an
            // 
            this.an.AutoSize = true;
            this.an.Location = new System.Drawing.Point(25, 170);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(116, 29);
            this.an.TabIndex = 1;
            this.an.Text = "Antelias";
            this.an.UseVisualStyleBackColor = true;
            // 
            // sp
            // 
            this.sp.AutoSize = true;
            this.sp.Location = new System.Drawing.Point(25, 55);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(107, 29);
            this.sp.TabIndex = 0;
            this.sp.Text = "Spears";
            this.sp.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // link2
            // 
            this.link2.AutoSize = true;
            this.link2.Location = new System.Drawing.Point(384, 369);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(311, 25);
            this.link2.TabIndex = 4;
            this.link2.TabStop = true;
            this.link2.Text = "https://www.redcrossblood.org/";
            this.link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link2_LinkClicked);
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.Location = new System.Drawing.Point(19, 369);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(320, 25);
            this.link1.TabIndex = 3;
            this.link1.TabStop = true;
            this.link1.Text = "https://dsclebanon.org/en/about";
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // dsc
            // 
            this.dsc.AutoSize = true;
            this.dsc.Location = new System.Drawing.Point(24, 47);
            this.dsc.Name = "dsc";
            this.dsc.Size = new System.Drawing.Size(179, 29);
            this.dsc.TabIndex = 2;
            this.dsc.TabStop = true;
            this.dsc.Text = " DSC Lebanon";
            this.dsc.UseVisualStyleBackColor = true;
            // 
            // redcross
            // 
            this.redcross.AutoSize = true;
            this.redcross.Location = new System.Drawing.Point(389, 47);
            this.redcross.Name = "redcross";
            this.redcross.Size = new System.Drawing.Size(239, 29);
            this.redcross.TabIndex = 1;
            this.redcross.TabStop = true;
            this.redcross.Text = "Lebanese Red Cross";
            this.redcross.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Controls.Add(this.dataGridView1);
            this.save.Location = new System.Drawing.Point(4, 34);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(1168, 397);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Age warning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.donorinfo.ResumeLayout(false);
            this.donorinfo.PerformLayout();
            this.hospital.ResumeLayout(false);
            this.hospital.PerformLayout();
            this.placebox.ResumeLayout(false);
            this.placebox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.save.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage donorinfo;
        private System.Windows.Forms.TabPage hospital;
        private System.Windows.Forms.TabPage save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gender1;
        private System.Windows.Forms.ComboBox blood;
        private System.Windows.Forms.TextBox age1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton redcross;
        private System.Windows.Forms.RadioButton dsc;
        private System.Windows.Forms.LinkLabel link2;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox placebox;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.CheckBox gm;
        private System.Windows.Forms.CheckBox jb;
        private System.Windows.Forms.CheckBox jn;
        private System.Windows.Forms.CheckBox an;
        private System.Windows.Forms.CheckBox sp;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem saveUpdateToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}


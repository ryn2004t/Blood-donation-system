namespace Adminpanel
{
    partial class Donations
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
            System.Windows.Forms.Label donation_idLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label blood_typeLabel;
            System.Windows.Forms.Label donation_dateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donations));
            this.bloodDonationDataSet = new Adminpanel.BloodDonationDataSet();
            this.donationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationsTableAdapter = new Adminpanel.BloodDonationDataSetTableAdapters.donationsTableAdapter();
            this.tableAdapterManager = new Adminpanel.BloodDonationDataSetTableAdapters.TableAdapterManager();
            this.donationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.donationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.donationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donation_idTextBox = new System.Windows.Forms.TextBox();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.blood_typeTextBox = new System.Windows.Forms.TextBox();
            this.donation_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            donation_idLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            blood_typeLabel = new System.Windows.Forms.Label();
            donation_dateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingNavigator)).BeginInit();
            this.donationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // donation_idLabel
            // 
            donation_idLabel.AutoSize = true;
            donation_idLabel.Location = new System.Drawing.Point(21, 73);
            donation_idLabel.Name = "donation_idLabel";
            donation_idLabel.Size = new System.Drawing.Size(91, 20);
            donation_idLabel.TabIndex = 2;
            donation_idLabel.Text = "donation id:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(21, 105);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(60, 20);
            user_idLabel.TabIndex = 4;
            user_idLabel.Text = "user id:";
            // 
            // blood_typeLabel
            // 
            blood_typeLabel.AutoSize = true;
            blood_typeLabel.Location = new System.Drawing.Point(21, 137);
            blood_typeLabel.Name = "blood_typeLabel";
            blood_typeLabel.Size = new System.Drawing.Size(86, 20);
            blood_typeLabel.TabIndex = 6;
            blood_typeLabel.Text = "blood type:";
            // 
            // donation_dateLabel
            // 
            donation_dateLabel.AutoSize = true;
            donation_dateLabel.Location = new System.Drawing.Point(21, 170);
            donation_dateLabel.Name = "donation_dateLabel";
            donation_dateLabel.Size = new System.Drawing.Size(111, 20);
            donation_dateLabel.TabIndex = 8;
            donation_dateLabel.Text = "donation date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(21, 201);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(63, 20);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "gender:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(21, 233);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(40, 20);
            ageLabel.TabIndex = 12;
            ageLabel.Text = "age:";
            // 
            // bloodDonationDataSet
            // 
            this.bloodDonationDataSet.DataSetName = "BloodDonationDataSet";
            this.bloodDonationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donationsBindingSource
            // 
            this.donationsBindingSource.DataMember = "donations";
            this.donationsBindingSource.DataSource = this.bloodDonationDataSet;
            // 
            // donationsTableAdapter
            // 
            this.donationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.donationsTableAdapter = this.donationsTableAdapter;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Adminpanel.BloodDonationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // donationsBindingNavigator
            // 
            this.donationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.donationsBindingNavigator.BindingSource = this.donationsBindingSource;
            this.donationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.donationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.donationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.donationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.donationsBindingNavigatorSaveItem});
            this.donationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.donationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.donationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.donationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.donationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.donationsBindingNavigator.Name = "donationsBindingNavigator";
            this.donationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.donationsBindingNavigator.Size = new System.Drawing.Size(1477, 33);
            this.donationsBindingNavigator.TabIndex = 0;
            this.donationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // donationsBindingNavigatorSaveItem
            // 
            this.donationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.donationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("donationsBindingNavigatorSaveItem.Image")));
            this.donationsBindingNavigatorSaveItem.Name = "donationsBindingNavigatorSaveItem";
            this.donationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.donationsBindingNavigatorSaveItem.Text = "Save Data";
            this.donationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.donationsBindingNavigatorSaveItem_Click);
            // 
            // donationsDataGridView
            // 
            this.donationsDataGridView.AutoGenerateColumns = false;
            this.donationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.donationsDataGridView.DataSource = this.donationsBindingSource;
            this.donationsDataGridView.Location = new System.Drawing.Point(172, 301);
            this.donationsDataGridView.Name = "donationsDataGridView";
            this.donationsDataGridView.RowHeadersWidth = 62;
            this.donationsDataGridView.RowTemplate.Height = 28;
            this.donationsDataGridView.Size = new System.Drawing.Size(1068, 283);
            this.donationsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "donation_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "donation_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "user_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "blood_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "blood_type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "donation_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "donation_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "gender";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn6.HeaderText = "age";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // donation_idTextBox
            // 
            this.donation_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationsBindingSource, "donation_id", true));
            this.donation_idTextBox.Location = new System.Drawing.Point(138, 70);
            this.donation_idTextBox.Name = "donation_idTextBox";
            this.donation_idTextBox.Size = new System.Drawing.Size(847, 26);
            this.donation_idTextBox.TabIndex = 3;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationsBindingSource, "user_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(138, 102);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(847, 26);
            this.user_idTextBox.TabIndex = 5;
            // 
            // blood_typeTextBox
            // 
            this.blood_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationsBindingSource, "blood_type", true));
            this.blood_typeTextBox.Location = new System.Drawing.Point(138, 134);
            this.blood_typeTextBox.Name = "blood_typeTextBox";
            this.blood_typeTextBox.Size = new System.Drawing.Size(847, 26);
            this.blood_typeTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.blood_typeTextBox, "A+ / A- / B+ / B- /AB+ / AB- / O+ / O-");
            // 
            // donation_dateDateTimePicker
            // 
            this.donation_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.donationsBindingSource, "donation_date", true));
            this.donation_dateDateTimePicker.Location = new System.Drawing.Point(138, 164);
            this.donation_dateDateTimePicker.Name = "donation_dateDateTimePicker";
            this.donation_dateDateTimePicker.Size = new System.Drawing.Size(847, 26);
            this.donation_dateDateTimePicker.TabIndex = 9;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationsBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(138, 198);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(847, 26);
            this.genderTextBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.genderTextBox, "Male / Female");
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationsBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(138, 230);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(847, 26);
            this.ageTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.ageTextBox, "not negative number");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 668);
            this.Controls.Add(donation_idLabel);
            this.Controls.Add(this.donation_idTextBox);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(blood_typeLabel);
            this.Controls.Add(this.blood_typeTextBox);
            this.Controls.Add(donation_dateLabel);
            this.Controls.Add(this.donation_dateDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.donationsDataGridView);
            this.Controls.Add(this.donationsBindingNavigator);
            this.Name = "Donations";
            this.Text = "Donations";
            this.Load += new System.EventHandler(this.Donations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingNavigator)).EndInit();
            this.donationsBindingNavigator.ResumeLayout(false);
            this.donationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BloodDonationDataSet bloodDonationDataSet;
        private System.Windows.Forms.BindingSource donationsBindingSource;
        private BloodDonationDataSetTableAdapters.donationsTableAdapter donationsTableAdapter;
        private BloodDonationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator donationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton donationsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView donationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox donation_idTextBox;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox blood_typeTextBox;
        private System.Windows.Forms.DateTimePicker donation_dateDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
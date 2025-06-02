namespace Adminpanel
{
    partial class hospitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitals));
            System.Windows.Forms.Label hospital_idLabel;
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label hospital_nameLabel;
            System.Windows.Forms.Label locationLabel;
            this.bloodDonationDataSet = new Adminpanel.BloodDonationDataSet();
            this.hospitalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalsTableAdapter = new Adminpanel.BloodDonationDataSetTableAdapters.hospitalsTableAdapter();
            this.tableAdapterManager = new Adminpanel.BloodDonationDataSetTableAdapters.TableAdapterManager();
            this.hospitalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hospitalsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hospitalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital_idTextBox = new System.Windows.Forms.TextBox();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.hospital_nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            hospital_idLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            hospital_nameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingNavigator)).BeginInit();
            this.hospitalsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bloodDonationDataSet
            // 
            this.bloodDonationDataSet.DataSetName = "BloodDonationDataSet";
            this.bloodDonationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalsBindingSource
            // 
            this.hospitalsBindingSource.DataMember = "hospitals";
            this.hospitalsBindingSource.DataSource = this.bloodDonationDataSet;
            // 
            // hospitalsTableAdapter
            // 
            this.hospitalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.donationsTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = this.hospitalsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Adminpanel.BloodDonationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // hospitalsBindingNavigator
            // 
            this.hospitalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hospitalsBindingNavigator.BindingSource = this.hospitalsBindingSource;
            this.hospitalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hospitalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hospitalsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.hospitalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hospitalsBindingNavigatorSaveItem});
            this.hospitalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hospitalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hospitalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hospitalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hospitalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hospitalsBindingNavigator.Name = "hospitalsBindingNavigator";
            this.hospitalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hospitalsBindingNavigator.Size = new System.Drawing.Size(1378, 33);
            this.hospitalsBindingNavigator.TabIndex = 0;
            this.hospitalsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // hospitalsBindingNavigatorSaveItem
            // 
            this.hospitalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hospitalsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hospitalsBindingNavigatorSaveItem.Image")));
            this.hospitalsBindingNavigatorSaveItem.Name = "hospitalsBindingNavigatorSaveItem";
            this.hospitalsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hospitalsBindingNavigatorSaveItem.Text = "Save Data";
            this.hospitalsBindingNavigatorSaveItem.Click += new System.EventHandler(this.hospitalsBindingNavigatorSaveItem_Click);
            // 
            // hospitalsDataGridView
            // 
            this.hospitalsDataGridView.AutoGenerateColumns = false;
            this.hospitalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospitalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hospitalsDataGridView.DataSource = this.hospitalsBindingSource;
            this.hospitalsDataGridView.Location = new System.Drawing.Point(229, 217);
            this.hospitalsDataGridView.Name = "hospitalsDataGridView";
            this.hospitalsDataGridView.RowHeadersWidth = 62;
            this.hospitalsDataGridView.RowTemplate.Height = 28;
            this.hospitalsDataGridView.Size = new System.Drawing.Size(950, 262);
            this.hospitalsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "hospital_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "hospital_id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hospital_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "hospital_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn4.HeaderText = "location";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // hospital_idLabel
            // 
            hospital_idLabel.AutoSize = true;
            hospital_idLabel.Location = new System.Drawing.Point(40, 74);
            hospital_idLabel.Name = "hospital_idLabel";
            hospital_idLabel.Size = new System.Drawing.Size(84, 20);
            hospital_idLabel.TabIndex = 2;
            hospital_idLabel.Text = "hospital id:";
            // 
            // hospital_idTextBox
            // 
            this.hospital_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "hospital_id", true));
            this.hospital_idTextBox.Location = new System.Drawing.Point(158, 71);
            this.hospital_idTextBox.Name = "hospital_idTextBox";
            this.hospital_idTextBox.Size = new System.Drawing.Size(736, 26);
            this.hospital_idTextBox.TabIndex = 3;
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(40, 106);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(60, 20);
            user_idLabel.TabIndex = 4;
            user_idLabel.Text = "user id:";
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "user_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(158, 103);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(736, 26);
            this.user_idTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.user_idTextBox, "insert a valid user_id");
            // 
            // hospital_nameLabel
            // 
            hospital_nameLabel.AutoSize = true;
            hospital_nameLabel.Location = new System.Drawing.Point(40, 138);
            hospital_nameLabel.Name = "hospital_nameLabel";
            hospital_nameLabel.Size = new System.Drawing.Size(112, 20);
            hospital_nameLabel.TabIndex = 6;
            hospital_nameLabel.Text = "hospital name:";
            // 
            // hospital_nameTextBox
            // 
            this.hospital_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "hospital_name", true));
            this.hospital_nameTextBox.Location = new System.Drawing.Point(158, 135);
            this.hospital_nameTextBox.Name = "hospital_nameTextBox";
            this.hospital_nameTextBox.Size = new System.Drawing.Size(736, 26);
            this.hospital_nameTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.hospital_nameTextBox, "insert only (DSC Lebanon or Red Cross)");
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(40, 170);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(68, 20);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(158, 167);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(736, 26);
            this.locationTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.locationTextBox, "insert only(Spears - Gemmayze- Antelias -  Jounieh - Jbeil)");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // hospitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 548);
            this.Controls.Add(hospital_idLabel);
            this.Controls.Add(this.hospital_idTextBox);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(hospital_nameLabel);
            this.Controls.Add(this.hospital_nameTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.hospitalsDataGridView);
            this.Controls.Add(this.hospitalsBindingNavigator);
            this.Name = "hospitals";
            this.Text = "hospitals";
            this.Load += new System.EventHandler(this.hospitals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingNavigator)).EndInit();
            this.hospitalsBindingNavigator.ResumeLayout(false);
            this.hospitalsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BloodDonationDataSet bloodDonationDataSet;
        private System.Windows.Forms.BindingSource hospitalsBindingSource;
        private BloodDonationDataSetTableAdapters.hospitalsTableAdapter hospitalsTableAdapter;
        private BloodDonationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hospitalsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hospitalsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hospitalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox hospital_idTextBox;
        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox hospital_nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
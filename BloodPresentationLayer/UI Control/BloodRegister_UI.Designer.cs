
namespace BloodPresentationLayer.UI_Control
{
	partial class BloodRegister_UI
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodRegister_UI));
			this.informationBloodGroupBox = new System.Windows.Forms.GroupBox();
			this.dateTimeBox = new ShafaCommon.UIControls.EditView.EditDateTime();
			this.editDateTime1 = new ShafaCommon.UIControls.EditView.EditDateTime();
			this.sectionTextComboBox = new ShafaCommon.UIControls.EditView.EditTextComboBox();
			this.bloodSerialTextBox = new ShafaCommon.UIControls.EditView.EditTextBox();
			this.bloodGroupComboBox = new ShafaCommon.UIControls.EditView.EditComboBox();
			this.searchSerialGroupBox = new System.Windows.Forms.GroupBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.bloodListdataGridView = new System.Windows.Forms.DataGridView();
			this.bloodSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bloodGorupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bloodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.srearchSerialTextBox = new ShafaCommon.UIControls.EditView.EditTextBox();
			this.informationBloodGroupBox.SuspendLayout();
			this.searchSerialGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bloodListdataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// informationBloodGroupBox
			// 
			this.informationBloodGroupBox.Controls.Add(this.dateTimeBox);
			this.informationBloodGroupBox.Controls.Add(this.editDateTime1);
			this.informationBloodGroupBox.Controls.Add(this.sectionTextComboBox);
			this.informationBloodGroupBox.Controls.Add(this.bloodSerialTextBox);
			this.informationBloodGroupBox.Controls.Add(this.bloodGroupComboBox);
			this.informationBloodGroupBox.Location = new System.Drawing.Point(323, 12);
			this.informationBloodGroupBox.Name = "informationBloodGroupBox";
			this.informationBloodGroupBox.Size = new System.Drawing.Size(296, 139);
			this.informationBloodGroupBox.TabIndex = 0;
			this.informationBloodGroupBox.TabStop = false;
			this.informationBloodGroupBox.Text = "اطلاعات خون";
			// 
			// dateTimeBox
			// 
			this.dateTimeBox.Caption = "تاریخ ثبت:";
			this.dateTimeBox.CaptionAutoSizeEdit = false;
			this.dateTimeBox.CaptionAutoSizeView = false;
			this.dateTimeBox.CaptionHeight = 22;
			this.dateTimeBox.CaptionWidth = 72;
			this.dateTimeBox.Code = 0;
			this.dateTimeBox.FieldName = null;
			this.dateTimeBox.IsCheckParentVisible = false;
			this.dateTimeBox.IsDateOnly = true;
			this.dateTimeBox.Location = new System.Drawing.Point(100, 107);
			this.dateTimeBox.Mode = ShafaCommon.Types.FormMode.Edit;
			this.dateTimeBox.Name = "dateTimeBox";
			this.dateTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateTimeBox.Size = new System.Drawing.Size(190, 22);
			this.dateTimeBox.TabIndex = 4;
			this.dateTimeBox.Value = "0000/00/00 00:00";
			this.dateTimeBox.ValueWidth = 118;
			// 
			// editDateTime1
			// 
			this.editDateTime1.CalenderVisible = false;
			this.editDateTime1.Caption = "Label:";
			this.editDateTime1.CaptionAutoSizeEdit = false;
			this.editDateTime1.CaptionAutoSizeView = false;
			this.editDateTime1.CaptionHeight = 25;
			this.editDateTime1.CaptionWidth = 72;
			this.editDateTime1.Code = 0;
			this.editDateTime1.FieldName = null;
			this.editDateTime1.IsCheckParentVisible = false;
			this.editDateTime1.Location = new System.Drawing.Point(100, 107);
			this.editDateTime1.Mode = ShafaCommon.Types.FormMode.View;
			this.editDateTime1.Name = "editDateTime1";
			this.editDateTime1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.editDateTime1.Size = new System.Drawing.Size(190, 25);
			this.editDateTime1.TabIndex = 3;
			this.editDateTime1.Value = "0000/00/00 00:00";
			this.editDateTime1.ValueWidth = 118;
			// 
			// sectionTextComboBox
			// 
			this.sectionTextComboBox.Caption = "بخش:";
			this.sectionTextComboBox.CaptionAutoSizeEdit = false;
			this.sectionTextComboBox.CaptionAutoSizeView = false;
			this.sectionTextComboBox.CaptionHeight = 25;
			this.sectionTextComboBox.CaptionWidth = 72;
			this.sectionTextComboBox.Code = 0;
			this.sectionTextComboBox.DataSource = null;
			this.sectionTextComboBox.FieldName = null;
			this.sectionTextComboBox.IsCheckParentVisible = false;
			this.sectionTextComboBox.IsSearchMiddle = false;
			this.sectionTextComboBox.Location = new System.Drawing.Point(43, 76);
			this.sectionTextComboBox.Mode = ShafaCommon.Types.FormMode.Edit;
			this.sectionTextComboBox.Name = "sectionTextComboBox";
			this.sectionTextComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.sectionTextComboBox.Size = new System.Drawing.Size(247, 25);
			this.sectionTextComboBox.TabIndex = 2;
			this.sectionTextComboBox.Value = "";
			this.sectionTextComboBox.ValueWidth = 45;
			// 
			// bloodSerialTextBox
			// 
			this.bloodSerialTextBox.AllowDigit = ShafaCommon.Types.AllowState.Allow;
			this.bloodSerialTextBox.AllowEnglish = false;
			this.bloodSerialTextBox.AllowMinusChar = false;
			this.bloodSerialTextBox.AllowPunctuation = false;
			this.bloodSerialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bloodSerialTextBox.Caption = "سریال خون:";
			this.bloodSerialTextBox.CaptionAutoSizeEdit = false;
			this.bloodSerialTextBox.CaptionAutoSizeView = false;
			this.bloodSerialTextBox.CaptionHeight = 22;
			this.bloodSerialTextBox.CaptionWidth = 72;
			this.bloodSerialTextBox.Code = 0;
			this.bloodSerialTextBox.FieldName = null;
			this.bloodSerialTextBox.IsCheckParentVisible = false;
			this.bloodSerialTextBox.IsPassword = false;
			this.bloodSerialTextBox.Location = new System.Drawing.Point(6, 20);
			this.bloodSerialTextBox.MaxLength = 32767;
			this.bloodSerialTextBox.MinLength = ((short)(2));
			this.bloodSerialTextBox.Mode = ShafaCommon.Types.FormMode.Edit;
			this.bloodSerialTextBox.MultiLine = false;
			this.bloodSerialTextBox.Name = "bloodSerialTextBox";
			this.bloodSerialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bloodSerialTextBox.Size = new System.Drawing.Size(284, 22);
			this.bloodSerialTextBox.TabIndex = 1;
			this.bloodSerialTextBox.TextboxBackcolor = System.Drawing.Color.Empty;
			this.bloodSerialTextBox.TextBoxBorder = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bloodSerialTextBox.TextBoxRightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bloodSerialTextBox.Value = "";
			this.bloodSerialTextBox.ValueHeight = 21;
			this.bloodSerialTextBox.ValueWidth = 212;
			// 
			// bloodGroupComboBox
			// 
			this.bloodGroupComboBox.Caption = "گروه خون:";
			this.bloodGroupComboBox.CaptionAutoSizeEdit = false;
			this.bloodGroupComboBox.CaptionAutoSizeView = false;
			this.bloodGroupComboBox.CaptionHeight = 22;
			this.bloodGroupComboBox.CaptionWidth = 72;
			this.bloodGroupComboBox.Code = 0;
			this.bloodGroupComboBox.DataSource = null;
			this.bloodGroupComboBox.FieldName = null;
			this.bloodGroupComboBox.IsCheckParentVisible = false;
			this.bloodGroupComboBox.Location = new System.Drawing.Point(90, 48);
			this.bloodGroupComboBox.Mode = ShafaCommon.Types.FormMode.Edit;
			this.bloodGroupComboBox.Name = "bloodGroupComboBox";
			this.bloodGroupComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bloodGroupComboBox.Size = new System.Drawing.Size(200, 22);
			this.bloodGroupComboBox.TabIndex = 0;
			this.bloodGroupComboBox.Value = "";
			this.bloodGroupComboBox.ValueWidth = 128;
			// 
			// searchSerialGroupBox
			// 
			this.searchSerialGroupBox.Controls.Add(this.srearchSerialTextBox);
			this.searchSerialGroupBox.Location = new System.Drawing.Point(21, 12);
			this.searchSerialGroupBox.Name = "searchSerialGroupBox";
			this.searchSerialGroupBox.Size = new System.Drawing.Size(296, 64);
			this.searchSerialGroupBox.TabIndex = 1;
			this.searchSerialGroupBox.TabStop = false;
			this.searchSerialGroupBox.Text = "جستجو";
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.Silver;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
			this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Location = new System.Drawing.Point(222, 128);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(95, 23);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "ذخیره اطلاعات";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.BackColor = System.Drawing.Color.Silver;
			this.searchButton.FlatAppearance.BorderSize = 0;
			this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
			this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchButton.Location = new System.Drawing.Point(121, 128);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 23);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "جستجو";
			this.searchButton.UseVisualStyleBackColor = false;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Silver;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
			this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(21, 128);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(95, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "انصراف";
			this.cancelButton.UseVisualStyleBackColor = false;
			// 
			// bloodListdataGridView
			// 
			this.bloodListdataGridView.AllowUserToAddRows = false;
			this.bloodListdataGridView.AllowUserToDeleteRows = false;
			this.bloodListdataGridView.AllowUserToResizeColumns = false;
			this.bloodListdataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bloodListdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.bloodListdataGridView.AutoGenerateColumns = false;
			this.bloodListdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.bloodListdataGridView.BackgroundColor = System.Drawing.Color.White;
			this.bloodListdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bloodListdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.bloodListdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bloodListdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.bloodListdataGridView.ColumnHeadersHeight = 30;
			this.bloodListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.bloodListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bloodSerialDataGridViewTextBoxColumn,
            this.bloodGorupDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.editDateDataGridViewTextBoxColumn});
			this.bloodListdataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.bloodListdataGridView.DataSource = this.bloodBindingSource;
			this.bloodListdataGridView.EnableHeadersVisualStyles = false;
			this.bloodListdataGridView.Location = new System.Drawing.Point(21, 172);
			this.bloodListdataGridView.Name = "bloodListdataGridView";
			this.bloodListdataGridView.ReadOnly = true;
			this.bloodListdataGridView.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.bloodListdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.bloodListdataGridView.RowTemplate.Height = 25;
			this.bloodListdataGridView.RowTemplate.ReadOnly = true;
			this.bloodListdataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.bloodListdataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.bloodListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.bloodListdataGridView.Size = new System.Drawing.Size(598, 318);
			this.bloodListdataGridView.TabIndex = 3;
			this.bloodListdataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.BloodListdataGridView_RowsAdded);
			this.bloodListdataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.BloodListdataGridView_RowsRemoved);
			// 
			// bloodSerialDataGridViewTextBoxColumn
			// 
			this.bloodSerialDataGridViewTextBoxColumn.DataPropertyName = "BloodSerial";
			this.bloodSerialDataGridViewTextBoxColumn.HeaderText = "سریال خون";
			this.bloodSerialDataGridViewTextBoxColumn.Name = "bloodSerialDataGridViewTextBoxColumn";
			this.bloodSerialDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bloodGorupDataGridViewTextBoxColumn
			// 
			this.bloodGorupDataGridViewTextBoxColumn.DataPropertyName = "BloodGorup";
			this.bloodGorupDataGridViewTextBoxColumn.HeaderText = "گروه خون";
			this.bloodGorupDataGridViewTextBoxColumn.Name = "bloodGorupDataGridViewTextBoxColumn";
			this.bloodGorupDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sectionDataGridViewTextBoxColumn
			// 
			this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
			this.sectionDataGridViewTextBoxColumn.HeaderText = "بخش";
			this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
			this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registerDateDataGridViewTextBoxColumn
			// 
			this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
			this.registerDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
			this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// editDateDataGridViewTextBoxColumn
			// 
			this.editDateDataGridViewTextBoxColumn.DataPropertyName = "EditDate";
			this.editDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ویرایش";
			this.editDateDataGridViewTextBoxColumn.Name = "editDateDataGridViewTextBoxColumn";
			this.editDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBloodToolStripMenuItem,
            this.deletBloodToolStripMenuItem,
            this.allClearToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(201, 70);
			// 
			// editBloodToolStripMenuItem
			// 
			this.editBloodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBloodToolStripMenuItem.Image")));
			this.editBloodToolStripMenuItem.Name = "editBloodToolStripMenuItem";
			this.editBloodToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.editBloodToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.editBloodToolStripMenuItem.Text = "ویرایش خون";
			this.editBloodToolStripMenuItem.ToolTipText = "ویرایش یک رکورد از بانک";
			this.editBloodToolStripMenuItem.Click += new System.EventHandler(this.EditBloodToolStripMenuItem_Click);
			// 
			// deletBloodToolStripMenuItem
			// 
			this.deletBloodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletBloodToolStripMenuItem.Image")));
			this.deletBloodToolStripMenuItem.Name = "deletBloodToolStripMenuItem";
			this.deletBloodToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deletBloodToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.deletBloodToolStripMenuItem.Text = "حذف خون";
			this.deletBloodToolStripMenuItem.ToolTipText = "حذف یک رکورد از بانک";
			// 
			// allClearToolStripMenuItem
			// 
			this.allClearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allClearToolStripMenuItem.Image")));
			this.allClearToolStripMenuItem.Name = "allClearToolStripMenuItem";
			this.allClearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
			this.allClearToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.allClearToolStripMenuItem.Text = "حذف کامل";
			this.allClearToolStripMenuItem.ToolTipText = "حذف کامل اطلاعات سامانه";
			// 
			// bloodBindingSource
			// 
			this.bloodBindingSource.DataSource = typeof(DAL.Model.Blood);
			// 
			// srearchSerialTextBox
			// 
			this.srearchSerialTextBox.AllowDigit = ShafaCommon.Types.AllowState.Allow;
			this.srearchSerialTextBox.AllowEnglish = false;
			this.srearchSerialTextBox.AllowMinusChar = false;
			this.srearchSerialTextBox.AllowPunctuation = false;
			this.srearchSerialTextBox.Caption = "سریال خون:";
			this.srearchSerialTextBox.CaptionAutoSizeEdit = false;
			this.srearchSerialTextBox.CaptionAutoSizeView = false;
			this.srearchSerialTextBox.CaptionHeight = 22;
			this.srearchSerialTextBox.CaptionWidth = 72;
			this.srearchSerialTextBox.Code = 0;
			this.srearchSerialTextBox.FieldName = null;
			this.srearchSerialTextBox.IsCheckParentVisible = false;
			this.srearchSerialTextBox.IsPassword = false;
			this.srearchSerialTextBox.Location = new System.Drawing.Point(6, 25);
			this.srearchSerialTextBox.MaxLength = 32767;
			this.srearchSerialTextBox.MinLength = ((short)(2));
			this.srearchSerialTextBox.Mode = ShafaCommon.Types.FormMode.View;
			this.srearchSerialTextBox.MultiLine = false;
			this.srearchSerialTextBox.Name = "srearchSerialTextBox";
			this.srearchSerialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.srearchSerialTextBox.Size = new System.Drawing.Size(284, 22);
			this.srearchSerialTextBox.TabIndex = 0;
			this.srearchSerialTextBox.TextboxBackcolor = System.Drawing.Color.Empty;
			this.srearchSerialTextBox.TextBoxBorder = System.Windows.Forms.BorderStyle.Fixed3D;
			this.srearchSerialTextBox.TextBoxRightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.srearchSerialTextBox.Value = "";
			this.srearchSerialTextBox.ValueHeight = 21;
			this.srearchSerialTextBox.ValueWidth = 212;
			// 
			// BloodRegister_UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bloodListdataGridView);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.searchSerialGroupBox);
			this.Controls.Add(this.informationBloodGroupBox);
			this.MinimumSize = new System.Drawing.Size(640, 510);
			this.Name = "BloodRegister_UI";
			this.Size = new System.Drawing.Size(640, 510);
			this.informationBloodGroupBox.ResumeLayout(false);
			this.searchSerialGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bloodListdataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox informationBloodGroupBox;
		private ShafaCommon.UIControls.EditView.EditDateTime editDateTime1;
		private ShafaCommon.UIControls.EditView.EditTextComboBox sectionTextComboBox;
		private ShafaCommon.UIControls.EditView.EditTextBox bloodSerialTextBox;
		private ShafaCommon.UIControls.EditView.EditComboBox bloodGroupComboBox;
		private System.Windows.Forms.GroupBox searchSerialGroupBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.DataGridView bloodListdataGridView;
		private System.Windows.Forms.BindingSource bloodBindingSource;
		private ShafaCommon.UIControls.EditView.EditDateTime dateTimeBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem editBloodToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deletBloodToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allClearToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn bloodSerialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bloodGorupDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
		private ShafaCommon.UIControls.EditView.EditTextBox srearchSerialTextBox;
	}
}

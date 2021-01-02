namespace BloodPresentationLayer.UI_Control
{
	public partial class BloodRegister_UI : ShafaCommon.Templates.ShafaBaseControl
	{
		#region Properties
		public bool _IsNew { get; set; }
		public string BloodSerial 
		{ 
			get
			{
				return bloodSerialTextBox.Value;
			}
			set
			{
				bloodSerialTextBox.Value = value;
			}
		}
		public string BloodGroup 
		{
			get
			{
				return bloodGroupComboBox.Value;
			}
			set
			{
				bloodGroupComboBox.Value = value;
			}
		}
		public short Section 
		{
			get
			{
				return (short)sectionTextComboBox.Code;
			}
			set
			{
				sectionTextComboBox.Code = value;
			}
		}
		public ShafaCommon.Types.ShafaDateType RegisterDate 
		{
			get
			{
				return dateTimeBox.DateTime;
			}
			set
			{

			}
		}
		public ShafaCommon.Types.ShafaDateType EditDate 
		{
			get
			{
				return ShafaCommon.Types.ShafaDateType.Today;
			}
			set
			{
				dateTimeBox.DateTime = value;
			}
		}

		private BLL.BloodBLL blood =
			new BLL.BloodBLL();

		#endregion /Properties
		public BloodRegister_UI()
		{
			InitializeComponent();
			_IsNew = true;
			bloodListdataGridView.DataSource = blood.GetALLBloodViews();
			bloodGroupComboBox.DataSource = GetBloodGroupDataSource();
			sectionTextComboBox.DataSource = GetSectionDataSource();
			CheckRecord();
		}

		//-------------------------------------------

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			//BLL.BloodBLL blood = new BLL.BloodBLL();

			string message = null;

			if (_IsNew)
			{
				blood.SaveDataBlood(bloodSerial: BloodSerial, bloodGroup: BloodGroup, section: Section.ToString(), registerDate: RegisterDate, message: out message);
				bloodListdataGridView.DataSource = blood.GetALLBloodViews();
				return;
			}
			else
			{
				_IsNew = true;				
				blood.EditDataBlood(bloodSerial: BloodSerial, bloodGroup: BloodGroup, section: Section.ToString(), editDate:EditDate, message: out message);				
				return;
			}
		}
		#endregion /SaveButton_Click

		#region EditBloodToolStripMenuItem_Click
		private void EditBloodToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			_IsNew = false;
			saveButton.Text = "ویرایش خون";
			dateTimeBox.Enabled = false;
			this.BloodSerial = bloodListdataGridView.CurrentRow.Cells[0].Value.ToString();
			this.BloodGroup = bloodListdataGridView.CurrentRow.Cells[1].Value.ToString();
			this.Section = short.Parse(bloodListdataGridView.CurrentRow.Cells[2].Value.ToString());
			this.EditDate = new ShafaCommon.Types.ShafaDateType(bloodListdataGridView.CurrentRow.Cells[0].Value.ToString());
			this.BloodSerial = bloodListdataGridView.CurrentRow.Cells[0].Value.ToString();
		}
		#endregion EditBloodToolStripMenuItem_Click

		//--------------------------------------------

		#region Founctions

		#region GetBloodGroupDataSource
		private ShafaLib.dsShafa.BaseDataTableDataTable GetBloodGroupDataSource()
		{
			var table = new ShafaLib.dsShafa.BaseDataTableDataTable();

			table.AddBaseDataTableRow(0, string.Empty);
			table.AddBaseDataTableRow(1, "O+");
			table.AddBaseDataTableRow(2, "O-");
			table.AddBaseDataTableRow(3, "A+");
			table.AddBaseDataTableRow(4, "A-");
			table.AddBaseDataTableRow(5, "AB+");
			table.AddBaseDataTableRow(6, "AB-");

			return table;
		}
		#endregion /GetBloodGroupDataSource

		#region GetSectionDataSource
		private ShafaLib.dsShafa.BaseDataTableDataTable GetSectionDataSource()
		{
			var table = new ShafaLib.dsShafa.BaseDataTableDataTable();

			table.AddBaseDataTableRow(0, string.Empty);
			table.AddBaseDataTableRow(1, Properties.Resources.stringSection1);
			table.AddBaseDataTableRow(2, Properties.Resources.stringSection2);
			table.AddBaseDataTableRow(3, Properties.Resources.stringSection3);
			table.AddBaseDataTableRow(4, Properties.Resources.stringSection4);
			table.AddBaseDataTableRow(5, Properties.Resources.stringSection5);

			return table;
		}

		#endregion GetSectionDataSource 

		#region RestControl
		private void RestControl()
		{
			bloodSerialTextBox.ResetText();
			bloodGroupComboBox.ResetText();
			sectionTextComboBox.ResetText();
			dateTimeBox.ResetText();
			saveButton.Text = "ذخیره اطلاعات";
			bloodListdataGridView.DataSource = blood.GetALLBloodViews();
			dateTimeBox.Enabled = true;
		}




		#endregion /RestControl

		#region CheckRecord
		private void CheckRecord()
		{
			if (bloodListdataGridView.Rows.Count > 0)
			{
				editBloodToolStripMenuItem.Enabled = true;
				deletBloodToolStripMenuItem.Enabled = true;
				return;
			}
			if (bloodListdataGridView.Rows.Count >= 5)
			{
				editBloodToolStripMenuItem.Enabled = true;
				deletBloodToolStripMenuItem.Enabled = true;
				allClearToolStripMenuItem.Enabled = true;
				return;
			}
			else
			{
				editBloodToolStripMenuItem.Enabled = false;
				deletBloodToolStripMenuItem.Enabled = false;
				allClearToolStripMenuItem.Enabled = false;
				return;
			}
		}

		#endregion /CheckRecord

		#endregion /Founctions

		private void BloodListdataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			CheckRecord();
		}

		private void BloodListdataGridView_RowsRemoved(object sender, System.Windows.Forms.DataGridViewRowsRemovedEventArgs e)
		{
			CheckRecord();
		}
	}
}

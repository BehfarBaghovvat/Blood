using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodPresentationLayer
{
	public partial class Form1 : ShafaCommon.Templates.ShafaBaseForm 
	{
		#region Properties
		BLL.BloodBLL bloodBLL = new BLL.BloodBLL();
		#endregion /Properties
		public Form1()
		{
			InitializeComponent();
			
			
		
		}
		private ShafaLib.dsShafa.BaseDataTableDataTable GetBloodGroupDataSource()
		{
			var table = new ShafaLib.dsShafa.BaseDataTableDataTable();

			table.AddBaseDataTableRow(0, "O+");
			table.AddBaseDataTableRow(1, "O-");
			table.AddBaseDataTableRow(2, "A+");
			table.AddBaseDataTableRow(3, "A-");

			return table;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//short section =(short)editTextComboBox1.Code;
			//MessageBox.Show($"{section}");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{			

		}

		private void editDateTime1_Load(object sender, EventArgs e)
		{

		}
	}
}


namespace BloodPresentationLayer
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
			ShafaCommon.Types.ShafaDateType shafaDateType1 = new ShafaCommon.Types.ShafaDateType();
			ShafaCommon.Types.ShafaDateType shafaDateType2 = new ShafaCommon.Types.ShafaDateType();
			this.bloodRegister_UI1 = new BloodPresentationLayer.UI_Control.BloodRegister_UI();
			this.SuspendLayout();
			// 
			// bloodRegister_UI1
			// 
			this.bloodRegister_UI1._IsNew = true;
			this.bloodRegister_UI1.BloodGroup = "";
			this.bloodRegister_UI1.BloodSerial = "";
			shafaDateType1.Date = "1399/10/13";
			shafaDateType1.DateShort = "99/10/13";
			shafaDateType1.DateTime = "1399/10/13 19:25";
			shafaDateType1.Day = ((short)(13));
			shafaDateType1.Hour = ((short)(19));
			shafaDateType1.IsValid = true;
			shafaDateType1.Minute = ((short)(25));
			shafaDateType1.Mon = ((short)(10));
			shafaDateType1.Time = "19:25";
			shafaDateType1.Year = ((short)(99));
			shafaDateType1.YearFull = 1399;
			this.bloodRegister_UI1.EditDate = shafaDateType1;
			this.bloodRegister_UI1.Location = new System.Drawing.Point(16, 42);
			this.bloodRegister_UI1.MinimumSize = new System.Drawing.Size(640, 510);
			this.bloodRegister_UI1.Name = "bloodRegister_UI1";
			shafaDateType2.Date = "0000/00/00";
			shafaDateType2.DateShort = "00/00/00";
			shafaDateType2.DateTime = "0000/00/00 00:00";
			shafaDateType2.Day = ((short)(0));
			shafaDateType2.Hour = ((short)(0));
			shafaDateType2.IsValid = false;
			shafaDateType2.Minute = ((short)(0));
			shafaDateType2.Mon = ((short)(0));
			shafaDateType2.Time = "00:00";
			shafaDateType2.Year = ((short)(0));
			shafaDateType2.YearFull = 0;
			this.bloodRegister_UI1.RegisterDate = shafaDateType2;
			this.bloodRegister_UI1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bloodRegister_UI1.Section = ((short)(0));
			this.bloodRegister_UI1.Size = new System.Drawing.Size(640, 510);
			this.bloodRegister_UI1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 585);
			this.Controls.Add(this.bloodRegister_UI1);
			this.MinimumSize = new System.Drawing.Size(660, 500);
			this.Name = "Form1";
			this.Text = "سامانه ثبت خون در بانک خون بیمارستان بقیه الله";
			this.ResumeLayout(false);

		}

		#endregion

		private UI_Control.BloodRegister_UI bloodRegister_UI1;
	}
}


using System;
using System.Linq;

namespace BLL
{
	public class BloodBLL
	{
		#region AddDataBlood
		public void SaveDataBlood(string bloodSerial, string bloodGroup, string section, ShafaCommon.Types.ShafaDateType registerDate, out string message)
		{
			message = string.Empty;

			DAL.Model.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new DAL.Model.DatabaseContext();

				#region Validation
				if (string.IsNullOrWhiteSpace(bloodSerial))
				{
					message =
						BloodBusinessLogicalLayer.Properties.Resources.validationBloodSerial;
				}
				if (string.IsNullOrWhiteSpace(bloodGroup))
				{
					if (string.IsNullOrWhiteSpace(message) == false)
					{
						message +=
							System.Environment.NewLine;
					}
					message +=
						BloodBusinessLogicalLayer.Properties.Resources.validationBloodGroup;
					return;
				}
				if (string.IsNullOrWhiteSpace(section.ToString()))
				{
					if (string.IsNullOrWhiteSpace(message) == false)
					{
						message +=
							System.Environment.NewLine;
					}
					message +=
						BloodBusinessLogicalLayer.Properties.Resources.validationSection;
					return;
				}
				if (string.IsNullOrWhiteSpace(registerDate.ToString()))
				{
					if (string.IsNullOrWhiteSpace(message) == false)
					{
						message +=
							System.Environment.NewLine;
					}
					message +=
						BloodBusinessLogicalLayer.Properties.Resources.validationRegisterDate;
				}

				if (string.IsNullOrWhiteSpace(message) == false)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(message);
					return;
				}
				#endregion /Validation

				DAL.Model.Blood blood =
					databaseContext.Bloods
					.Where(current => string.Compare(current.BloodSerial, bloodSerial) == 0)
					.FirstOrDefault();

				if (blood != null)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringFoundBlood);
					return;
				}
				else
				{
					blood =
						new DAL.Model.Blood
						{
							BloodSerial = bloodSerial,
							BloodGorup = bloodGroup,
							Section = section,
							RegisterDate = registerDate.ToString(),
							EditDate = string.Empty,
						};
				}
				databaseContext.Bloods.Add(blood);
				databaseContext.SaveChanges();

				ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringSaveBlood);
			}
			catch (Exception ex)
			{
				ShafaCommon.Common.ExceptionManager.ManageException(ex);
			}
		}
		#endregion /AddDataBlood

		#region DeletDataBlood
		public void DeletDataBlood(string bloodSerial, out string message)
		{
			message = string.Empty;

			DAL.Model.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new DAL.Model.DatabaseContext();

				#region Validation
				if (string.IsNullOrWhiteSpace(bloodSerial))
				{
					message =
						BloodBusinessLogicalLayer.Properties.Resources.validationBloodSerial;
				}

				if (string.IsNullOrWhiteSpace(message) == false)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(message);
					return;
				}
				#endregion /Validation

				DAL.Model.Blood blood =
					databaseContext.Bloods
					.Where(current => string.Compare(current.BloodSerial, bloodSerial) == 0)
					.FirstOrDefault();

				if (blood == null)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringNotFoundBlood);
					return;
				}
				else
				{
					databaseContext.Bloods.Remove(blood);
					databaseContext.SaveChanges();
				}


				ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringFoundBlood);
			}
			catch (Exception ex)
			{
				ShafaCommon.Common.ExceptionManager.ManageException(ex);
			}
		}
		#endregion /DeletDataBlood

		#region EditDataBlood
		public void EditDataBlood(string bloodSerial, string bloodGroup, string section, ShafaCommon.Types.ShafaDateType editDate, out string message)
		{
			message = string.Empty;

			DAL.Model.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new DAL.Model.DatabaseContext();

				#region Validation
				if (string.IsNullOrWhiteSpace(bloodSerial))
				{
					message =
						BloodBusinessLogicalLayer.Properties.Resources.validationBloodSerial;
				}

				if (string.IsNullOrWhiteSpace(message) == false)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(message);
					return;
				}
				#endregion /Validation

				DAL.Model.Blood blood =
					databaseContext.Bloods
					.Where(current => string.Compare(current.BloodSerial, bloodSerial) == 0)
					.FirstOrDefault();

				if (blood == null)
				{
					ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringNotFoundBlood);
					return;
				}
				else
				{
					blood.BloodSerial = bloodSerial;
					blood.BloodGorup = bloodGroup;
					blood.Section = section;
					blood.EditDate = editDate.ToString();
				}

				databaseContext.SaveChanges();

				ShafaCommon.Common.MessageManager.ShowMessageBox
						(BloodBusinessLogicalLayer.Properties.Resources.stringEditBlood);
			}
			catch (Exception ex)
			{
				ShafaCommon.Common.ExceptionManager.ManageException(ex);
			}
		}
		#endregion /EditDataBlood

		#region GetALLBloodViews
		public System.Collections.Generic.List<ViewModel.BloodViewModel> GetALLBloodViews()
		{
			DAL.Model.DatabaseContext databaseContext = null;

			databaseContext =
				new DAL.Model.DatabaseContext();

			return databaseContext.Bloods.Select(value => new ViewModel.BloodViewModel
			{
				BloodID = value.BloodID,
				BloodSerial = value.BloodSerial,
				BloodGorup = value.BloodGorup,
				Section= value.Section,
				RegisterDate = value.RegisterDate,
				EditDate = value.EditDate,
			}
			).ToList();
		}
		#endregion /GetALLBloodViews

		#region GetBetweenRegisterDate
		public System.Collections.Generic.List<ViewModel.BloodViewModel> GetBetweenRegisterDate(System.DateTime firstDate, System.DateTime lastDate)
		{
			DAL.Model.DatabaseContext databaseContext = null;

			databaseContext =
				new DAL.Model.DatabaseContext();

			return databaseContext.Bloods.Where(current => string.Compare(current.RegisterDate.ToString(), firstDate.ToString()) >= 0 && string.Compare(current.RegisterDate.ToString(), lastDate.ToString()) <= 0).Select(value => new ViewModel.BloodViewModel
			{
				BloodID = value.BloodID,
				BloodSerial = value.BloodSerial,
				BloodGorup = value.BloodGorup,
				Section = value.Section,
				RegisterDate = value.RegisterDate,
			}
			).ToList();
		}
		#endregion /GetBetweenRegisterDate			

		#region GetSimilarSerial
		private System.Collections.Generic.List<DAL.Model.Blood> GetSimilarSerial(string bloodSerial)
		{
			DAL.Model.DatabaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new DAL.Model.DatabaseContext();

				System.Collections.Generic.List<DAL.Model.Blood> bloods = null;

				if (string.IsNullOrWhiteSpace(bloodSerial))
				{
					return bloods =
						dataBaseContext.Bloods
						.OrderBy(current => current.BloodSerial)
						.ToList();
				
				}
				else
				{
					return bloods =
						dataBaseContext.Bloods
						.Where(current => current.BloodSerial.Contains(bloodSerial))
						.OrderBy(current => current.BloodSerial)
						.ToList();
				}

				
			}
			catch (System.Exception ex)
			{
				throw (ShafaCommon.Common.ExceptionManagerUtility.AddInnerException(ex, BloodBusinessLogicalLayer.Properties.Resources.errGetBlood));
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
			
		}
		#endregion /GetSimilarSerial

		#region GetSingleBlood
		public System.Collections.Generic.List<ViewModel.BloodViewModel> GetSingleBlood(string bloodSerial)
		{
			DAL.Model.DatabaseContext databaseContext = null;

			databaseContext =
				new DAL.Model.DatabaseContext();

			return databaseContext.Bloods.Where(current => string.Compare(current.BloodSerial, bloodSerial) == 0).Select(value => new ViewModel.BloodViewModel
			{
				BloodID = value.BloodID,
				BloodSerial = value.BloodSerial,
				BloodGorup = value.BloodGorup,
				Section = value.Section,
				RegisterDate = value.RegisterDate,
			}
			).ToList();
		}
		#endregion /GetSingleBlood


	}
}

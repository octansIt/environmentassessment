using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseAssignmentManager : ViewBase
	{
		public LicenseAssignmentManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public LicenseManagerLicenseInfo UpdateAssignedLicense(string entity, string licenseKey, string entityDisplayName)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateAssignedLicenseRequestType updateAssignedLicenseRequestType = new UpdateAssignedLicenseRequestType();
				updateAssignedLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateAssignedLicenseRequestType.entity = entity;
				updateAssignedLicenseRequestType.licenseKey = licenseKey;
				updateAssignedLicenseRequestType.entityDisplayName = entityDisplayName;
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(this.VimServiceProxy.UpdateAssignedLicense(new UpdateAssignedLicenseRequest(updateAssignedLicenseRequestType)).UpdateAssignedLicenseResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveAssignedLicense(string entityId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RemoveAssignedLicenseRequestType removeAssignedLicenseRequestType = new RemoveAssignedLicenseRequestType();
				removeAssignedLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeAssignedLicenseRequestType.entityId = entityId;
				this.VimServiceProxy.RemoveAssignedLicense(new RemoveAssignedLicenseRequest(removeAssignedLicenseRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public LicenseAssignmentManagerLicenseAssignment[] QueryAssignedLicenses(string entityId)
		{
			LicenseAssignmentManagerLicenseAssignment[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryAssignedLicensesRequestType queryAssignedLicensesRequestType = new QueryAssignedLicensesRequestType();
				queryAssignedLicensesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAssignedLicensesRequestType.entityId = entityId;
				result = (LicenseAssignmentManagerLicenseAssignment[])VIConvert.ToVim(this.VimServiceProxy.QueryAssignedLicenses(new QueryAssignedLicensesRequest(queryAssignedLicensesRequestType)).QueryAssignedLicensesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

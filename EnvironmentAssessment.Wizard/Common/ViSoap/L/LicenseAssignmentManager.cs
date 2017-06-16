using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateAssignedLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), entity, licenseKey, entityDisplayName));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveAssignedLicense(string entityId)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RemoveAssignedLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), entityId);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public LicenseAssignmentManagerLicenseAssignment[] QueryAssignedLicenses(string entityId)
		{
			LicenseAssignmentManagerLicenseAssignment[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (LicenseAssignmentManagerLicenseAssignment[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAssignedLicenses((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), entityId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

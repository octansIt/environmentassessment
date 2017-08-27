using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostImageConfigManager : ViewBase
	{
		public HostImageConfigManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string HostImageConfigGetAcceptance()
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				HostImageConfigGetAcceptanceRequestType hostImageConfigGetAcceptanceRequestType = new HostImageConfigGetAcceptanceRequestType();
				hostImageConfigGetAcceptanceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.HostImageConfigGetAcceptance(new HostImageConfigGetAcceptanceRequest(hostImageConfigGetAcceptanceRequestType)).HostImageConfigGetAcceptanceResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public HostImageProfileSummary HostImageConfigGetProfile()
		{
			HostImageProfileSummary result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				HostImageConfigGetProfileRequestType hostImageConfigGetProfileRequestType = new HostImageConfigGetProfileRequestType();
				hostImageConfigGetProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostImageProfileSummary)VIConvert.ToVim(this.VimServiceProxy.HostImageConfigGetProfile(new HostImageConfigGetProfileRequest(hostImageConfigGetProfileRequestType)).HostImageConfigGetProfileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateHostImageAcceptanceLevel(string newAcceptanceLevel)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UpdateHostImageAcceptanceLevelRequestType updateHostImageAcceptanceLevelRequestType = new UpdateHostImageAcceptanceLevelRequestType();
				updateHostImageAcceptanceLevelRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateHostImageAcceptanceLevelRequestType.newAcceptanceLevel = newAcceptanceLevel;
				this.VimServiceProxy.UpdateHostImageAcceptanceLevel(new UpdateHostImageAcceptanceLevelRequest(updateHostImageAcceptanceLevelRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public SoftwarePackage[] fetchSoftwarePackages()
		{
			SoftwarePackage[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				fetchSoftwarePackagesRequestType fetchSoftwarePackagesRequestType = new fetchSoftwarePackagesRequestType();
				fetchSoftwarePackagesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (SoftwarePackage[])VIConvert.ToVim(this.VimServiceProxy.fetchSoftwarePackages(new fetchSoftwarePackagesRequest(fetchSoftwarePackagesRequestType)).fetchSoftwarePackagesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DateTime installDate()
		{
			DateTime returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				installDateRequestType installDateRequestType = new installDateRequestType();
				installDateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.installDate(new installDateRequest(installDateRequestType)).installDateResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}

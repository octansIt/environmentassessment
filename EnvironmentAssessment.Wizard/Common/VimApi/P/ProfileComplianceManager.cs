using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileComplianceManager : ViewBase
	{
		public ProfileComplianceManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CheckCompliance_Task(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckComplianceRequestType checkComplianceRequestType = new CheckComplianceRequestType();
				checkComplianceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkComplianceRequestType.profile = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(profile);
				checkComplianceRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckCompliance_Task(new CheckCompliance_TaskRequest(checkComplianceRequestType)).CheckCompliance_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ComplianceResult[] CheckCompliance(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ComplianceResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckCompliance_Task(profile, entity);
				result = (ComplianceResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ComplianceResult[] QueryComplianceStatus(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ComplianceResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryComplianceStatusRequestType queryComplianceStatusRequestType = new QueryComplianceStatusRequestType();
				queryComplianceStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryComplianceStatusRequestType.profile = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(profile);
				queryComplianceStatusRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				result = (ComplianceResult[])VIConvert.ToVim(this.VimServiceProxy.QueryComplianceStatus(new QueryComplianceStatusRequest(queryComplianceStatusRequestType)).QueryComplianceStatusResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ClearComplianceStatus(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ClearComplianceStatusRequestType clearComplianceStatusRequestType = new ClearComplianceStatusRequestType();
				clearComplianceStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				clearComplianceStatusRequestType.profile = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(profile);
				clearComplianceStatusRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				this.VimServiceProxy.ClearComplianceStatus(new ClearComplianceStatusRequest(clearComplianceStatusRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ProfileExpressionMetadata[] QueryExpressionMetadata(string[] expressionName, ManagedObjectReference profile)
		{
			ProfileExpressionMetadata[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryExpressionMetadataRequestType queryExpressionMetadataRequestType = new QueryExpressionMetadataRequestType();
				queryExpressionMetadataRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryExpressionMetadataRequestType.expressionName = expressionName;
				queryExpressionMetadataRequestType.profile = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(profile);
				result = (ProfileExpressionMetadata[])VIConvert.ToVim(this.VimServiceProxy.QueryExpressionMetadata(new QueryExpressionMetadataRequest(queryExpressionMetadataRequestType)).QueryExpressionMetadataResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

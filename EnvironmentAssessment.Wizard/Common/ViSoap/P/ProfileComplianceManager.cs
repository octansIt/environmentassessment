using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ProfileComplianceManager : ViewBase
	{
		public ProfileComplianceManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CheckCompliance_Task(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckCompliance_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(profile), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ComplianceResult[] CheckCompliance(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ComplianceResult[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckCompliance_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(profile), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity)));
				result = (ComplianceResult[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ComplianceResult[] QueryComplianceStatus(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			ComplianceResult[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ComplianceResult[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryComplianceStatus((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(profile), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ClearComplianceStatus(ManagedObjectReference[] profile, ManagedObjectReference[] entity)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).ClearComplianceStatus((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(profile), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ProfileExpressionMetadata[] QueryExpressionMetadata(string[] expressionName, ManagedObjectReference profile)
		{
			ProfileExpressionMetadata[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ProfileExpressionMetadata[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryExpressionMetadata((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), expressionName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(profile)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

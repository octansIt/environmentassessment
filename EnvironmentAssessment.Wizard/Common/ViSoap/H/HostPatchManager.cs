using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostPatchManager : ViewBase
	{
		public HostPatchManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CheckHostPatch_Task(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult CheckHostPatch(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CheckHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ScanHostPatch_Task(HostPatchManagerLocator repository, string[] updateID)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ScanHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerLocator)VIConvert.ToWsdlType(repository), updateID));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerStatus[] ScanHostPatch(HostPatchManagerLocator repository, string[] updateID)
		{
			HostPatchManagerStatus[] result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ScanHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerLocator)VIConvert.ToWsdlType(repository), updateID));
				result = (HostPatchManagerStatus[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ScanHostPatchV2_Task(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ScanHostPatchV2_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult ScanHostPatchV2(string[] metaUrls, string[] bundleUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ScanHostPatchV2_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference StageHostPatch_Task(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).StageHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, vibUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult StageHostPatch(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).StageHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, vibUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference InstallHostPatch_Task(HostPatchManagerLocator repository, string updateID, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InstallHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerLocator)VIConvert.ToWsdlType(repository), updateID, force.GetValueOrDefault(), force.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void InstallHostPatch(HostPatchManagerLocator repository, string updateID, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InstallHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerLocator)VIConvert.ToWsdlType(repository), updateID, force.GetValueOrDefault(), force.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference InstallHostPatchV2_Task(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InstallHostPatchV2_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, vibUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult InstallHostPatchV2(string[] metaUrls, string[] bundleUrls, string[] vibUrls, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InstallHostPatchV2_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), metaUrls, bundleUrls, vibUrls, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference UninstallHostPatch_Task(string[] bulletinIds, HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UninstallHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), bulletinIds, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult UninstallHostPatch(string[] bulletinIds, HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UninstallHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), bulletinIds, (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference QueryHostPatch_Task(HostPatchManagerPatchManagerOperationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).QueryHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostPatchManagerResult QueryHostPatch(HostPatchManagerPatchManagerOperationSpec spec)
		{
			HostPatchManagerResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).QueryHostPatch_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostPatchManagerPatchManagerOperationSpec)VIConvert.ToWsdlType(spec)));
				result = (HostPatchManagerResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

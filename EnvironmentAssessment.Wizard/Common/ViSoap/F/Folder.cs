using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class Folder : ManagedEntity
	{
		protected string[] _childType;
		protected ManagedObjectReference[] _childEntity;
		public string[] ChildType
		{
			get
			{
				return this._childType;
			}
		}
		public ManagedObjectReference[] ChildEntity
		{
			get
			{
				return this._childEntity;
			}
		}
		public new Folder_LinkedView LinkedView
		{
			get
			{
				return (Folder_LinkedView)this._linkedView;
			}
		}
		public Folder(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateFolder(string name)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateFolder((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference MoveIntoFolder_Task(ManagedObjectReference[] list)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveIntoFolder_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(list)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void MoveIntoFolder(ManagedObjectReference[] list)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveIntoFolder_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(list)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CreateVM_Task(VirtualMachineConfigSpec config, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateVM(VirtualMachineConfigSpec config, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterVM_Task(string path, string name, bool asTemplate, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RegisterVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), path, name, asTemplate, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterVM(string path, string name, bool asTemplate, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RegisterVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), path, name, asTemplate, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateCluster(string name, ClusterConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateCluster((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ClusterConfigSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateClusterEx(string name, ClusterConfigSpecEx spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateClusterEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ClusterConfigSpecEx)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference AddStandaloneHost_Task(HostConnectSpec spec, ComputeResourceConfigSpec compResSpec, bool addConnected, string license)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddStandaloneHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(spec), (VimApi_60.ComputeResourceConfigSpec)VIConvert.ToWsdlType(compResSpec), addConnected, license));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference AddStandaloneHost(HostConnectSpec spec, ComputeResourceConfigSpec compResSpec, bool addConnected, string license)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddStandaloneHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(spec), (VimApi_60.ComputeResourceConfigSpec)VIConvert.ToWsdlType(compResSpec), addConnected, license));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDatacenter(string name)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateDatacenter((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference UnregisterAndDestroy_Task()
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UnregisterAndDestroy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UnregisterAndDestroy()
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UnregisterAndDestroy_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CreateDVS_Task(DVSCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateDVS_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DVSCreateSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDVS(DVSCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateDVS_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DVSCreateSpec)VIConvert.ToWsdlType(spec)));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateStoragePod(string name)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateStoragePod((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

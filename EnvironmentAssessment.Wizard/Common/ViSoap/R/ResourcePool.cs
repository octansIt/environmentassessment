using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ResourcePool : ManagedEntity
	{
		protected ResourcePoolSummary _summary;
		protected ResourcePoolRuntimeInfo _runtime;
		protected ManagedObjectReference _owner;
		protected ManagedObjectReference[] _resourcePool;
		protected ManagedObjectReference[] _vm;
		protected ResourceConfigSpec _config;
		protected ResourceConfigSpec[] _childConfiguration;
		public ResourcePoolSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public ResourcePoolRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public ManagedObjectReference Owner
		{
			get
			{
				return this._owner;
			}
		}
		public ManagedObjectReference[] resourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public ResourceConfigSpec Config
		{
			get
			{
				return this._config;
			}
		}
		public ResourceConfigSpec[] ChildConfiguration
		{
			get
			{
				return this._childConfiguration;
			}
		}
		public new ResourcePool_LinkedView LinkedView
		{
			get
			{
				return (ResourcePool_LinkedView)this._linkedView;
			}
		}
		public ResourcePool(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateConfig(string name, ResourceConfigSpec config)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ResourceConfigSpec)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void MoveIntoResourcePool(ManagedObjectReference[] list)
		{
			try
			{
				((VimService)this.Client.VimService).MoveIntoResourcePool((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(list));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateChildResourceConfiguration(ResourceConfigSpec[] spec)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateChildResourceConfiguration((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ResourceConfigSpec[])VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CreateResourcePool(string name, ResourceConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateResourcePool((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ResourceConfigSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DestroyChildren()
		{
			try
			{
				((VimService)this.Client.VimService).DestroyChildren((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CreateVApp(string name, ResourceConfigSpec resSpec, VAppConfigSpec configSpec, ManagedObjectReference vmFolder)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateVApp((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ResourceConfigSpec)VIConvert.ToWsdlType(resSpec), (VimApi_60.VAppConfigSpec)VIConvert.ToWsdlType(configSpec), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vmFolder)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateChildVM_Task(VirtualMachineConfigSpec config, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateChildVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateChildVM(VirtualMachineConfigSpec config, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateChildVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterChildVM_Task(string path, string name, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RegisterChildVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), path, name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterChildVM(string path, string name, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).RegisterChildVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), path, name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ImportVApp(ImportSpec spec, ManagedObjectReference folder, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ImportVApp((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ImportSpec)VIConvert.ToWsdlType(spec), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(folder), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ResourceConfigOption QueryResourceConfigOption()
		{
			ResourceConfigOption result;
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
				result = (ResourceConfigOption)VIConvert.ToVim(((VimService)this.Client.VimService).QueryResourceConfigOption((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RefreshRuntime()
		{
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
				((VimService)this.Client.VimService).RefreshRuntime((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

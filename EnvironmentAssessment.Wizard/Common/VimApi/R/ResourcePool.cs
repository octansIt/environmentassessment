using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public ResourcePool(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateConfig(string name, ResourceConfigSpec config)
		{
			try
			{
				UpdateConfigRequestType updateConfigRequestType = new UpdateConfigRequestType();
				updateConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateConfigRequestType.name = name;
				updateConfigRequestType.config = (VimApi_65.ResourceConfigSpec)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateConfig(new UpdateConfigRequest(updateConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MoveIntoResourcePool(ManagedObjectReference[] list)
		{
			try
			{
				MoveIntoResourcePoolRequestType moveIntoResourcePoolRequestType = new MoveIntoResourcePoolRequestType();
				moveIntoResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveIntoResourcePoolRequestType.list = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(list);
				this.VimServiceProxy.MoveIntoResourcePool(new MoveIntoResourcePoolRequest(moveIntoResourcePoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateChildResourceConfiguration(ResourceConfigSpec[] spec)
		{
			try
			{
				UpdateChildResourceConfigurationRequestType updateChildResourceConfigurationRequestType = new UpdateChildResourceConfigurationRequestType();
				updateChildResourceConfigurationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateChildResourceConfigurationRequestType.spec = (VimApi_65.ResourceConfigSpec[])VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.UpdateChildResourceConfiguration(new UpdateChildResourceConfigurationRequest(updateChildResourceConfigurationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateResourcePool(string name, ResourceConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateResourcePoolRequestType createResourcePoolRequestType = new CreateResourcePoolRequestType();
				createResourcePoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createResourcePoolRequestType.name = name;
				createResourcePoolRequestType.spec = (VimApi_65.ResourceConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateResourcePool(new CreateResourcePoolRequest(createResourcePoolRequestType)).CreateResourcePoolResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DestroyChildren()
		{
			try
			{
				DestroyChildrenRequestType destroyChildrenRequestType = new DestroyChildrenRequestType();
				destroyChildrenRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyChildren(new DestroyChildrenRequest(destroyChildrenRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateVApp(string name, ResourceConfigSpec resSpec, VAppConfigSpec configSpec, ManagedObjectReference vmFolder)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateVAppRequestType createVAppRequestType = new CreateVAppRequestType();
				createVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createVAppRequestType.name = name;
				createVAppRequestType.resSpec = (VimApi_65.ResourceConfigSpec)VIConvert.ToWsdlType(resSpec);
				createVAppRequestType.configSpec = (VimApi_65.VAppConfigSpec)VIConvert.ToWsdlType(configSpec);
				createVAppRequestType.vmFolder = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vmFolder);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateVApp(new CreateVAppRequest(createVAppRequestType)).CreateVAppResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateChildVM_Task(VirtualMachineConfigSpec config, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateChildVMRequestType createChildVMRequestType = new CreateChildVMRequestType();
				createChildVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createChildVMRequestType.config = (VimApi_65.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config);
				createChildVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateChildVM_Task(new CreateChildVM_TaskRequest(createChildVMRequestType)).CreateChildVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateChildVM(VirtualMachineConfigSpec config, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CreateChildVM_Task(config, host);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterChildVM_Task(string path, string name, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
                RegisterChildVMRequestType registerChildVMRequestType = new RegisterChildVMRequestType();
				registerChildVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerChildVMRequestType.path = path;
				registerChildVMRequestType.name = name;
				registerChildVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RegisterChildVM_Task(new RegisterChildVM_TaskRequest(registerChildVMRequestType)).RegisterChildVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterChildVM(string path, string name, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
                ManagedObjectReference taskReference = this.RegisterChildVM_Task(path, name, host);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ImportVApp(ImportSpec spec, ManagedObjectReference folder, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ImportVAppRequestType importVAppRequestType = new ImportVAppRequestType();
				importVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				importVAppRequestType.spec = (VimApi_65.ImportSpec)VIConvert.ToWsdlType(spec);
				importVAppRequestType.folder = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(folder);
				importVAppRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ImportVApp(new ImportVAppRequest(importVAppRequestType)).ImportVAppResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ResourceConfigOption QueryResourceConfigOption()
		{
			ResourceConfigOption result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				QueryResourceConfigOptionRequestType queryResourceConfigOptionRequestType = new QueryResourceConfigOptionRequestType();
				queryResourceConfigOptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ResourceConfigOption)VIConvert.ToVim(this.VimServiceProxy.QueryResourceConfigOption(new QueryResourceConfigOptionRequest(queryResourceConfigOptionRequestType)).QueryResourceConfigOptionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RefreshRuntime()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
                RefreshRuntimeRequestType refreshRuntimeRequestType = new RefreshRuntimeRequestType();
				refreshRuntimeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshRuntime(new RefreshRuntimeRequest(refreshRuntimeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

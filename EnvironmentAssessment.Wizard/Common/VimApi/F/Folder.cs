using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				CreateFolderRequestType createFolderRequestType = new CreateFolderRequestType();
				createFolderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createFolderRequestType.name = name;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateFolder(new CreateFolderRequest(createFolderRequestType)).CreateFolderResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference MoveIntoFolder_Task(ManagedObjectReference[] list)
		{
			ManagedObjectReference result;
			try
			{
				MoveIntoFolderRequestType moveIntoFolderRequestType = new MoveIntoFolderRequestType();
				moveIntoFolderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveIntoFolderRequestType.list = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(list);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MoveIntoFolder_Task(new MoveIntoFolder_TaskRequest(moveIntoFolderRequestType)).MoveIntoFolder_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MoveIntoFolder(ManagedObjectReference[] list)
		{
			try
			{
				ManagedObjectReference taskReference = this.MoveIntoFolder_Task(list);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateVM_Task(VirtualMachineConfigSpec config, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				CreateVMRequestType createVMRequestType = new CreateVMRequestType();
				createVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createVMRequestType.config = (VimApi_65.VirtualMachineConfigSpec)VIConvert.ToWsdlType(config);
				createVMRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				createVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateVM_Task(new CreateVM_TaskRequest(createVMRequestType)).CreateVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateVM(VirtualMachineConfigSpec config, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.CreateVM_Task(config, pool, host);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterVM_Task(string path, string name, bool asTemplate, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				RegisterVMRequestType registerVMRequestType = new RegisterVMRequestType();
				registerVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerVMRequestType.path = path;
				registerVMRequestType.name = name;
				registerVMRequestType.asTemplate = asTemplate;
				registerVMRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				registerVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RegisterVM_Task(new RegisterVM_TaskRequest(registerVMRequestType)).RegisterVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RegisterVM(string path, string name, bool asTemplate, ManagedObjectReference pool, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.RegisterVM_Task(path, name, asTemplate, pool, host);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateCluster(string name, ClusterConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateClusterRequestType createClusterRequestType = new CreateClusterRequestType();
				createClusterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createClusterRequestType.name = name;
				createClusterRequestType.spec = (VimApi_65.ClusterConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateCluster(new CreateClusterRequest(createClusterRequestType)).CreateClusterResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateClusterEx(string name, ClusterConfigSpecEx spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateClusterExRequestType createClusterExRequestType = new CreateClusterExRequestType();
				createClusterExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createClusterExRequestType.name = name;
				createClusterExRequestType.spec = (VimApi_65.ClusterConfigSpecEx)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateClusterEx(new CreateClusterExRequest(createClusterExRequestType)).CreateClusterExResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference AddStandaloneHost_Task(HostConnectSpec spec, ComputeResourceConfigSpec compResSpec, bool addConnected, string license)
		{
			ManagedObjectReference result;
			try
			{
				AddStandaloneHostRequestType addStandaloneHostRequestType = new AddStandaloneHostRequestType();
				addStandaloneHostRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addStandaloneHostRequestType.spec = (VimApi_65.HostConnectSpec)VIConvert.ToWsdlType(spec);
				addStandaloneHostRequestType.compResSpec = (VimApi_65.ComputeResourceConfigSpec)VIConvert.ToWsdlType(compResSpec);
				addStandaloneHostRequestType.addConnected = addConnected;
				addStandaloneHostRequestType.license = license;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AddStandaloneHost_Task(new AddStandaloneHost_TaskRequest(addStandaloneHostRequestType)).AddStandaloneHost_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference AddStandaloneHost(HostConnectSpec spec, ComputeResourceConfigSpec compResSpec, bool addConnected, string license)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.AddStandaloneHost_Task(spec, compResSpec, addConnected, license);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDatacenter(string name)
		{
			ManagedObjectReference result;
			try
			{
				CreateDatacenterRequestType createDatacenterRequestType = new CreateDatacenterRequestType();
				createDatacenterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDatacenterRequestType.name = name;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateDatacenter(new CreateDatacenterRequest(createDatacenterRequestType)).CreateDatacenterResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UnregisterAndDestroy_Task()
		{
			ManagedObjectReference result;
			try
			{
				UnregisterAndDestroyRequestType unregisterAndDestroyRequestType = new UnregisterAndDestroyRequestType();
				unregisterAndDestroyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UnregisterAndDestroy_Task(new UnregisterAndDestroy_TaskRequest(unregisterAndDestroyRequestType)).UnregisterAndDestroy_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UnregisterAndDestroy()
		{
			try
			{
				ManagedObjectReference taskReference = this.UnregisterAndDestroy_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateDVS_Task(DVSCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateDVSRequestType createDVSRequestType = new CreateDVSRequestType();
				createDVSRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDVSRequestType.spec = (VimApi_65.DVSCreateSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateDVS_Task(new CreateDVS_TaskRequest(createDVSRequestType)).CreateDVS_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateDVS(DVSCreateSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CreateDVS_Task(spec);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateStoragePod(string name)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				CreateStoragePodRequestType createStoragePodRequestType = new CreateStoragePodRequestType();
				createStoragePodRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createStoragePodRequestType.name = name;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateStoragePod(new CreateStoragePodRequest(createStoragePodRequestType)).CreateStoragePodResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

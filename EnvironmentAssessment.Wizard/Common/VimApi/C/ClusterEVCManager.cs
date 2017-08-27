
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterEVCManager : ExtensibleManagedObject
	{
		protected ManagedObjectReference _managedCluster;
		protected ClusterEVCManagerEVCState _evcState;
		protected ClusterEVCManager_LinkedView _linkedView;
		public ManagedObjectReference ManagedCluster
		{
			get
			{
				return this._managedCluster;
			}
		}
		public ClusterEVCManagerEVCState EvcState
		{
			get
			{
				return this._evcState;
			}
		}
		public ClusterEVCManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ClusterEVCManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ConfigureEvcMode_Task(string evcModeKey)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client,VimVersion.Vim60);
				ConfigureEvcModeRequestType configureEvcModeRequestType = new ConfigureEvcModeRequestType();
				configureEvcModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureEvcModeRequestType.evcModeKey = evcModeKey;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConfigureEvcMode_Task(new ConfigureEvcMode_TaskRequest(configureEvcModeRequestType)).ConfigureEvcMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConfigureEvcMode(string evcModeKey)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.ConfigureEvcMode_Task(evcModeKey);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DisableEvcMode_Task()
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                DisableEvcModeRequestType disableEvcModeRequestType = new DisableEvcModeRequestType();
				disableEvcModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DisableEvcMode_Task(new DisableEvcMode_TaskRequest(disableEvcModeRequestType)).DisableEvcMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DisableEvcMode()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.DisableEvcMode_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CheckConfigureEvcMode_Task(string evcModeKey)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                CheckConfigureEvcModeRequestType checkConfigureEvcModeRequestType = new CheckConfigureEvcModeRequestType();
				checkConfigureEvcModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkConfigureEvcModeRequestType.evcModeKey = evcModeKey;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckConfigureEvcMode_Task(new CheckConfigureEvcMode_TaskRequest(checkConfigureEvcModeRequestType)).CheckConfigureEvcMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterEVCManagerCheckResult[] CheckConfigureEvcMode(string evcModeKey)
		{
			ClusterEVCManagerCheckResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.CheckConfigureEvcMode_Task(evcModeKey);
				result = (ClusterEVCManagerCheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CheckAddHostEvc_Task(HostConnectSpec cnxSpec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                CheckAddHostEvcRequestType checkAddHostEvcRequestType = new CheckAddHostEvcRequestType();
				checkAddHostEvcRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkAddHostEvcRequestType.cnxSpec = (VimApi_65.HostConnectSpec)VIConvert.ToWsdlType(cnxSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckAddHostEvc_Task(new CheckAddHostEvc_TaskRequest(checkAddHostEvcRequestType)).CheckAddHostEvc_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterEVCManagerCheckResult[] CheckAddHostEvc(HostConnectSpec cnxSpec)
		{
			ClusterEVCManagerCheckResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.CheckAddHostEvc_Task(cnxSpec);
				result = (ClusterEVCManagerCheckResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

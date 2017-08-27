using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualPortgroup : Network
	{
		protected string _key;
		protected DVPortgroupConfigInfo _config;
		protected string[] _portKeys;
		public string Key
		{
			get
			{
				return this._key;
			}
		}
		public DVPortgroupConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public string[] PortKeys
		{
			get
			{
				return this._portKeys;
			}
		}
		public new DistributedVirtualPortgroup_LinkedView LinkedView
		{
			get
			{
				return (DistributedVirtualPortgroup_LinkedView)this._linkedView;
			}
		}
		public DistributedVirtualPortgroup(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ReconfigureDVPortgroup_Task(DVPortgroupConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ReconfigureDVPortgroupRequestType reconfigureDVPortgroupRequestType = new ReconfigureDVPortgroupRequestType();
				reconfigureDVPortgroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureDVPortgroupRequestType.spec = (VimApi_65.DVPortgroupConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureDVPortgroup_Task(new ReconfigureDVPortgroup_TaskRequest(reconfigureDVPortgroupRequestType)).ReconfigureDVPortgroup_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureDVPortgroup(DVPortgroupConfigSpec spec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ReconfigureDVPortgroup_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DVPortgroupRollback_Task(EntityBackupConfig entityBackup)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				DVPortgroupRollbackRequestType dVPortgroupRollbackRequestType = new DVPortgroupRollbackRequestType();
				dVPortgroupRollbackRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dVPortgroupRollbackRequestType.entityBackup = (VimApi_65.EntityBackupConfig)VIConvert.ToWsdlType(entityBackup);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DVPortgroupRollback_Task(new DVPortgroupRollback_TaskRequest(dVPortgroupRollbackRequestType)).DVPortgroupRollback_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DVPortgroupConfigSpec DVPortgroupRollback(EntityBackupConfig entityBackup)
		{
			DVPortgroupConfigSpec result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.DVPortgroupRollback_Task(entityBackup);
				result = (DVPortgroupConfigSpec)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

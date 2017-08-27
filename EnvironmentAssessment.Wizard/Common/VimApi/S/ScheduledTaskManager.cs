using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ScheduledTaskManager : ViewBase
	{
		protected ManagedObjectReference[] _scheduledTask;
		protected ScheduledTaskDescription _description;
		protected ScheduledTaskManager_LinkedView _linkedView;
		public ManagedObjectReference[] ScheduledTask
		{
			get
			{
				return this._scheduledTask;
			}
		}
		public ScheduledTaskDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public ScheduledTaskManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ScheduledTaskManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateScheduledTask(ManagedObjectReference entity, ScheduledTaskSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateScheduledTaskRequestType createScheduledTaskRequestType = new CreateScheduledTaskRequestType();
				createScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createScheduledTaskRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				createScheduledTaskRequestType.spec = (VimApi_65.ScheduledTaskSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateScheduledTask(new CreateScheduledTaskRequest(createScheduledTaskRequestType)).CreateScheduledTaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] RetrieveEntityScheduledTask(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
				RetrieveEntityScheduledTaskRequestType retrieveEntityScheduledTaskRequestType = new RetrieveEntityScheduledTaskRequestType();
				retrieveEntityScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveEntityScheduledTaskRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.RetrieveEntityScheduledTask(new RetrieveEntityScheduledTaskRequest(retrieveEntityScheduledTaskRequestType)).RetrieveEntityScheduledTaskResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateObjectScheduledTask(ManagedObjectReference obj, ScheduledTaskSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateObjectScheduledTaskRequestType createObjectScheduledTaskRequestType = new CreateObjectScheduledTaskRequestType();
				createObjectScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createObjectScheduledTaskRequestType.obj = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(obj);
				createObjectScheduledTaskRequestType.spec = (VimApi_65.ScheduledTaskSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateObjectScheduledTask(new CreateObjectScheduledTaskRequest(createObjectScheduledTaskRequestType)).CreateObjectScheduledTaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] RetrieveObjectScheduledTask(ManagedObjectReference obj)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RetrieveObjectScheduledTaskRequestType retrieveObjectScheduledTaskRequestType = new RetrieveObjectScheduledTaskRequestType();
				retrieveObjectScheduledTaskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveObjectScheduledTaskRequestType.obj = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(obj);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.RetrieveObjectScheduledTask(new RetrieveObjectScheduledTaskRequest(retrieveObjectScheduledTaskRequestType)).RetrieveObjectScheduledTaskResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

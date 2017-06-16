using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ScheduledTaskManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateScheduledTask(ManagedObjectReference entity, ScheduledTaskSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), (VimApi_60.ScheduledTaskSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] RetrieveEntityScheduledTask(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveEntityScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateObjectScheduledTask(ManagedObjectReference obj, ScheduledTaskSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateObjectScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(obj), (VimApi_60.ScheduledTaskSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] RetrieveObjectScheduledTask(ManagedObjectReference obj)
		{
			ManagedObjectReference[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveObjectScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(obj)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

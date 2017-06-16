using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class EventManager : ViewBase
	{
		protected EventDescription _description;
		protected Event _latestEvent;
		protected int _maxCollector;
		public EventDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public Event LatestEvent
		{
			get
			{
				return this._latestEvent;
			}
		}
		public int MaxCollector
		{
			get
			{
				return this._maxCollector;
			}
		}
		public EventManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public EventArgDesc[] RetrieveArgumentDescription(string eventTypeId)
		{
			EventArgDesc[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (EventArgDesc[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveArgumentDescription((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), eventTypeId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference CreateCollectorForEvents(EventFilterSpec filter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateCollectorForEvents((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.EventFilterSpec)VIConvert.ToWsdlType(filter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void LogUserEvent(ManagedObjectReference entity, string msg)
		{
			try
			{
				((VimService)this.Client.VimService).LogUserEvent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), msg);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public Event[] QueryEvents(EventFilterSpec filter)
		{
			Event[] result;
			try
			{
				result = (Event[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryEvents((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.EventFilterSpec)VIConvert.ToWsdlType(filter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void PostEvent(Event eventToPost, TaskInfo taskInfo)
		{
			try
			{
				((VimService)this.Client.VimService).PostEvent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.Event)VIConvert.ToWsdlType(eventToPost), (VimApi_60.TaskInfo)VIConvert.ToWsdlType(taskInfo));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

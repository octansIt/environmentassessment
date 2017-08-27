using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RetrieveArgumentDescriptionRequestType retrieveArgumentDescriptionRequestType = new RetrieveArgumentDescriptionRequestType();
				retrieveArgumentDescriptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveArgumentDescriptionRequestType.eventTypeId = eventTypeId;
				result = (EventArgDesc[])VIConvert.ToVim(this.VimServiceProxy.RetrieveArgumentDescription(new RetrieveArgumentDescriptionRequest(retrieveArgumentDescriptionRequestType)).RetrieveArgumentDescriptionResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateCollectorForEvents(EventFilterSpec filter)
		{
			ManagedObjectReference result;
			try
			{
				CreateCollectorForEventsRequestType createCollectorForEventsRequestType = new CreateCollectorForEventsRequestType();
				createCollectorForEventsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createCollectorForEventsRequestType.filter = (VimApi_65.EventFilterSpec)VIConvert.ToWsdlType(filter);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateCollectorForEvents(new CreateCollectorForEventsRequest(createCollectorForEventsRequestType)).CreateCollectorForEventsResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void LogUserEvent(ManagedObjectReference entity, string msg)
		{
			try
			{
				LogUserEventRequestType logUserEventRequestType = new LogUserEventRequestType();
				logUserEventRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				logUserEventRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				logUserEventRequestType.msg = msg;
				this.VimServiceProxy.LogUserEvent(new LogUserEventRequest(logUserEventRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public Event[] QueryEvents(EventFilterSpec filter)
		{
			Event[] result;
			try
			{
				QueryEventsRequestType queryEventsRequestType = new QueryEventsRequestType();
				queryEventsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryEventsRequestType.filter = (VimApi_65.EventFilterSpec)VIConvert.ToWsdlType(filter);
				result = (Event[])VIConvert.ToVim(this.VimServiceProxy.QueryEvents(new QueryEventsRequest(queryEventsRequestType)).QueryEventsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PostEvent(Event eventToPost, TaskInfo taskInfo)
		{
			try
			{
				PostEventRequestType postEventRequestType = new PostEventRequestType();
				postEventRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				postEventRequestType.eventToPost = (VimApi_65.Event)VIConvert.ToWsdlType(eventToPost);
				postEventRequestType.taskInfo = (VimApi_65.TaskInfo)VIConvert.ToWsdlType(taskInfo);
				this.VimServiceProxy.PostEvent(new PostEventRequest(postEventRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class EventHistoryCollector : HistoryCollector
	{
		protected Event[] _latestPage;
		public Event[] LatestPage
		{
			get
			{
				return this._latestPage;
			}
		}
		public EventHistoryCollector(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public Event[] ReadNextEvents(int maxCount)
		{
			Event[] result;
			try
			{
				ReadNextEventsRequestType readNextEventsRequestType = new ReadNextEventsRequestType();
				readNextEventsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				readNextEventsRequestType.maxCount = maxCount;
				result = (Event[])VIConvert.ToVim(this.VimServiceProxy.ReadNextEvents(new ReadNextEventsRequest(readNextEventsRequestType)).ReadNextEventsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public Event[] ReadPreviousEvents(int maxCount)
		{
			Event[] result;
			try
			{
				ReadPreviousEventsRequestType readPreviousEventsRequestType = new ReadPreviousEventsRequestType();
				readPreviousEventsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				readPreviousEventsRequestType.maxCount = maxCount;
				result = (Event[])VIConvert.ToVim(this.VimServiceProxy.ReadPreviousEvents(new ReadPreviousEventsRequest(readPreviousEventsRequestType)).ReadPreviousEventsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

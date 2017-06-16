using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public EventHistoryCollector(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public Event[] ReadNextEvents(int maxCount)
		{
			Event[] result;
			try
			{
				result = (Event[])VIConvert.ToVim(((VimService)this.Client.VimService).ReadNextEvents((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), maxCount));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public Event[] ReadPreviousEvents(int maxCount)
		{
			Event[] result;
			try
			{
				result = (Event[])VIConvert.ToVim(((VimService)this.Client.VimService).ReadPreviousEvents((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), maxCount));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

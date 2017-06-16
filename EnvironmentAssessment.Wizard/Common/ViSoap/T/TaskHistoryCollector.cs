using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class TaskHistoryCollector : HistoryCollector
	{
		protected TaskInfo[] _latestPage;
		public TaskInfo[] LatestPage
		{
			get
			{
				return this._latestPage;
			}
		}
		public TaskHistoryCollector(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public TaskInfo[] ReadNextTasks(int maxCount)
		{
			TaskInfo[] result;
			try
			{
				result = (TaskInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).ReadNextTasks((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), maxCount));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public TaskInfo[] ReadPreviousTasks(int maxCount)
		{
			TaskInfo[] result;
			try
			{
				result = (TaskInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).ReadPreviousTasks((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), maxCount));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public TaskHistoryCollector(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public TaskInfo[] ReadNextTasks(int maxCount)
		{
			TaskInfo[] result;
			try
			{
				ReadNextTasksRequestType readNextTasksRequestType = new ReadNextTasksRequestType();
				readNextTasksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				readNextTasksRequestType.maxCount = maxCount;
				result = (TaskInfo[])VIConvert.ToVim(this.VimServiceProxy.ReadNextTasks(new ReadNextTasksRequest(readNextTasksRequestType)).ReadNextTasksResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public TaskInfo[] ReadPreviousTasks(int maxCount)
		{
			TaskInfo[] result;
			try
			{
				ReadPreviousTasksRequestType readPreviousTasksRequestType = new ReadPreviousTasksRequestType();
				readPreviousTasksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				readPreviousTasksRequestType.maxCount = maxCount;
				result = (TaskInfo[])VIConvert.ToVim(this.VimServiceProxy.ReadPreviousTasks(new ReadPreviousTasksRequest(readPreviousTasksRequestType)).ReadPreviousTasksResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

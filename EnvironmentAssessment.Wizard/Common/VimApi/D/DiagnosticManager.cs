using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class DiagnosticManager : ViewBase
	{
		public DiagnosticManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DiagnosticManagerLogDescriptor[] QueryDescriptions(ManagedObjectReference host)
		{
			DiagnosticManagerLogDescriptor[] result;
			try
			{
				QueryDescriptionsRequestType queryDescriptionsRequestType = new QueryDescriptionsRequestType();
				queryDescriptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDescriptionsRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (DiagnosticManagerLogDescriptor[])VIConvert.ToVim(this.VimServiceProxy.QueryDescriptions(new QueryDescriptionsRequest(queryDescriptionsRequestType)).QueryDescriptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DiagnosticManagerLogHeader BrowseDiagnosticLog(ManagedObjectReference host, string key, int? start, int? lines)
		{
			DiagnosticManagerLogHeader result;
			try
			{
				BrowseDiagnosticLogRequestType browseDiagnosticLogRequestType = new BrowseDiagnosticLogRequestType();
				browseDiagnosticLogRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				browseDiagnosticLogRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				browseDiagnosticLogRequestType.key = key;
				browseDiagnosticLogRequestType.start = start.GetValueOrDefault();
				browseDiagnosticLogRequestType.startSpecified = start.HasValue;
				browseDiagnosticLogRequestType.lines = lines.GetValueOrDefault();
				browseDiagnosticLogRequestType.linesSpecified = lines.HasValue;
				result = (DiagnosticManagerLogHeader)VIConvert.ToVim(this.VimServiceProxy.BrowseDiagnosticLog(new BrowseDiagnosticLogRequest(browseDiagnosticLogRequestType)).BrowseDiagnosticLogResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference GenerateLogBundles_Task(bool includeDefault, ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
				GenerateLogBundlesRequestType generateLogBundlesRequestType = new GenerateLogBundlesRequestType();
				generateLogBundlesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateLogBundlesRequestType.includeDefault = includeDefault;
				generateLogBundlesRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.GenerateLogBundles_Task(new GenerateLogBundles_TaskRequest(generateLogBundlesRequestType)).GenerateLogBundles_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DiagnosticManagerBundleInfo[] GenerateLogBundles(bool includeDefault, ManagedObjectReference[] host)
		{
			DiagnosticManagerBundleInfo[] result;
			try
			{
				ManagedObjectReference taskReference = this.GenerateLogBundles_Task(includeDefault, host);
				result = (DiagnosticManagerBundleInfo[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

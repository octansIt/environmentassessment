using System;
using System.Diagnostics;
using System.Reflection;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class OverheadMemoryManager : ViewBase
	{
		public OverheadMemoryManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public long LookupVmOverheadMemory(ManagedObjectReference vm, ManagedObjectReference host)
		{
			VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(vm={3}, host={4})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				vm,
				host
			});
			long num;
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				num = ((VimService)this.Client.VimService).LookupVmOverheadMemory((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vm), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host));
			}
			catch (SoapException ex)
			{
				/*VITrace.Trace.TraceEvent(TraceEventType.Error, 0, "[{0}] An exception of type '{1}' occurred in {2}.{3}\n[Message]: {4}\n[Stack]: {5}\n[Detail]: {6}", new object[]
				{
					DateTime.Now,
					ex.GetType().FullName,
					MethodBase.GetCurrentMethod().DeclaringType.Name,
					MethodBase.GetCurrentMethod().Name,
					ex.Message,
					ex.StackTrace,
					ex.Detail.InnerText
				});*/
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			/* VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}(result={3})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				num
			}); */
			return num;
		}
	}
}

using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HookManager : ViewBase
	{
		public HookManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HookManagerExtensionHookDeclResult DeclareExtensionAsHookingService(string extensionKey, string serviceIp, int servicePort, string servicePath, bool UpdateExistingDeclaration)
		{
			/* VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(extensionKey={3}, serviceIp={4}, servicePort={5}, servicePath={6}, UpdateExistingDeclaration={7})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				extensionKey,
				serviceIp,
				servicePort,
				servicePath,
				UpdateExistingDeclaration
			}); */
			HookManagerExtensionHookDeclResult result;
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HookManagerExtensionHookDeclResult)VIConvert.ToVim(((VimService)this.Client.VimService).DeclareExtensionAsHookingService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, serviceIp, servicePort, servicePath, UpdateExistingDeclaration));
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
				}); */
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			/* VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name
			}); */
			return result;
		}
		public HookManagerExtensionHookRemovalResult RemoveExtensionAsHookingService(string extensionKey)
		{
			/* VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(extensionKey={3})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				extensionKey
			}); */
			HookManagerExtensionHookRemovalResult result;
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HookManagerExtensionHookRemovalResult)VIConvert.ToVim(((VimService)this.Client.VimService).RemoveExtensionAsHookingService((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey));
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
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name
			});*/
			return result;
		}
		public HookManagerMethodHookAcquisitionResult AcquireMethodHookForExtension(string extensionKey, string vmodlMethod, HookManagerExtensionHealthRedAction redHealthPolicy, bool asyncPreCallback, HookManagerPostCallbackPolicy postCallbackPolicy, PreCallbackResult defaultPreCallbackResult, long leaseTimeMilliseconds)
		{
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(extensionKey={3}, vmodlMethod={4}, asyncPreCallback={5}, leaseTimeMilliseconds={6})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				extensionKey,
				vmodlMethod,
				asyncPreCallback,
				leaseTimeMilliseconds
			});*/
			HookManagerMethodHookAcquisitionResult result;
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HookManagerMethodHookAcquisitionResult)VIConvert.ToVim(((VimService)this.Client.VimService).AcquireMethodHookForExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, vmodlMethod, (VimApi_60.HookManagerExtensionHealthRedAction)VIConvert.ToWsdlType(redHealthPolicy), asyncPreCallback, (VimApi_60.HookManagerPostCallbackPolicy)VIConvert.ToWsdlType(postCallbackPolicy), (VimApi_60.PreCallbackResult)VIConvert.ToWsdlType(defaultPreCallbackResult), leaseTimeMilliseconds));
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
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name
			});*/
			return result;
		}
		public HookManagerMethodHookReleaseResult ReleaseMethodHookForExtension(string extensionKey, string vmodlMethod)
		{
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(extensionKey={3}, vmodlMethod={4})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				extensionKey,
				vmodlMethod
			});*/
			HookManagerMethodHookReleaseResult result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
                {
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HookManagerMethodHookReleaseResult)VIConvert.ToVim(((VimService)this.Client.VimService).ReleaseMethodHookForExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, vmodlMethod));
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
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name
			});*/
			return result;
		}
		public void UpdatePreCallbackResult(string extensionKey, PreCallbackResult resultToUpdate)
		{
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] --> {1}.{2}(extensionKey={3})", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name,
				extensionKey
			});*/
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdatePreCallbackResult((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, (VimApi_60.PreCallbackResult)VIConvert.ToWsdlType(resultToUpdate));
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
			/*VITrace.Trace.TraceEvent(TraceEventType.Verbose, 0, "[{0}] <-- {1}.{2}", new object[]
			{
				DateTime.Now,
				MethodBase.GetCurrentMethod().DeclaringType.Name,
				MethodBase.GetCurrentMethod().Name
			});*/
		}
	}
}

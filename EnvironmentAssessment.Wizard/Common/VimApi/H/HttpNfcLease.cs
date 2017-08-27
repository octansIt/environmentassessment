using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLease : ViewBase
	{
		protected int _initializeProgress;
		protected HttpNfcLeaseInfo _info;
		protected HttpNfcLeaseState _state;
		protected LocalizedMethodFault _error;
		public int InitializeProgress
		{
			get
			{
				return this._initializeProgress;
			}
		}
		public HttpNfcLeaseInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HttpNfcLeaseState State
		{
			get
			{
				return this._state;
			}
		}
		public LocalizedMethodFault Error
		{
			get
			{
				return this._error;
			}
		}
		public HttpNfcLease(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HttpNfcLeaseManifestEntry[] HttpNfcLeaseGetManifest()
		{
			HttpNfcLeaseManifestEntry[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				HttpNfcLeaseGetManifestRequestType httpNfcLeaseGetManifestRequestType = new HttpNfcLeaseGetManifestRequestType();
				httpNfcLeaseGetManifestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HttpNfcLeaseManifestEntry[])VIConvert.ToVim(this.VimServiceProxy.HttpNfcLeaseGetManifest(new HttpNfcLeaseGetManifestRequest(httpNfcLeaseGetManifestRequestType)).HttpNfcLeaseGetManifestResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HttpNfcLeaseComplete()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				HttpNfcLeaseCompleteRequestType httpNfcLeaseCompleteRequestType = new HttpNfcLeaseCompleteRequestType();
				httpNfcLeaseCompleteRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.HttpNfcLeaseComplete(new HttpNfcLeaseCompleteRequest(httpNfcLeaseCompleteRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HttpNfcLeaseAbort(LocalizedMethodFault fault)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				HttpNfcLeaseAbortRequestType httpNfcLeaseAbortRequestType = new HttpNfcLeaseAbortRequestType();
				httpNfcLeaseAbortRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				httpNfcLeaseAbortRequestType.fault = (VimApi_65.LocalizedMethodFault)VIConvert.ToWsdlType(fault);
				this.VimServiceProxy.HttpNfcLeaseAbort(new HttpNfcLeaseAbortRequest(httpNfcLeaseAbortRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HttpNfcLeaseProgress(int percent)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				HttpNfcLeaseProgressRequestType httpNfcLeaseProgressRequestType = new HttpNfcLeaseProgressRequestType();
				httpNfcLeaseProgressRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				httpNfcLeaseProgressRequestType.percent = percent;
				this.VimServiceProxy.HttpNfcLeaseProgress(new HttpNfcLeaseProgressRequest(httpNfcLeaseProgressRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public HttpNfcLease(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HttpNfcLeaseManifestEntry[] HttpNfcLeaseGetManifest()
		{
			HttpNfcLeaseManifestEntry[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HttpNfcLeaseManifestEntry[])VIConvert.ToVim(((VimService)this.Client.VimService).HttpNfcLeaseGetManifest((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void HttpNfcLeaseComplete()
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).HttpNfcLeaseComplete((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void HttpNfcLeaseAbort(LocalizedMethodFault fault)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).HttpNfcLeaseAbort((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.LocalizedMethodFault)VIConvert.ToWsdlType(fault));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void HttpNfcLeaseProgress(int percent)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).HttpNfcLeaseProgress((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), percent);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

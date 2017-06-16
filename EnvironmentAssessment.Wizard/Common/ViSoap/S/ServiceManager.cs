using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ServiceManager : ViewBase
	{
		protected ServiceManagerServiceInfo[] _service;
		public ServiceManagerServiceInfo[] Service
		{
			get
			{
				return this._service;
			}
		}
		public ServiceManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ServiceManagerServiceInfo[] QueryServiceList(string serviceName, string[] location)
		{
			ServiceManagerServiceInfo[] result;
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
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ServiceManagerServiceInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryServiceList((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), serviceName, location));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

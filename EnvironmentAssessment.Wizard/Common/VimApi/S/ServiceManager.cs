using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public ServiceManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ServiceManagerServiceInfo[] QueryServiceList(string serviceName, string[] location)
		{
			ServiceManagerServiceInfo[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryServiceListRequestType queryServiceListRequestType = new QueryServiceListRequestType();
				queryServiceListRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryServiceListRequestType.serviceName = serviceName;
				queryServiceListRequestType.location = location;
				result = (ServiceManagerServiceInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryServiceList(new QueryServiceListRequest(queryServiceListRequestType)).QueryServiceListResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

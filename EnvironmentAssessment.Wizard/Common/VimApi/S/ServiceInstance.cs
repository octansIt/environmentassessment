using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ServiceInstance : ViewBase
	{
		protected DateTime _serverClock;
		protected Capability _capability;
		protected ServiceContent _content;
		public DateTime ServerClock
		{
			get
			{
				return this._serverClock;
			}
		}
		public Capability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public ServiceContent Content
		{
			get
			{
				return this._content;
			}
		}
		public ServiceInstance(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DateTime CurrentTime()
		{
			DateTime returnval;
			try
			{
				CurrentTimeRequestType currentTimeRequestType = new CurrentTimeRequestType();
				currentTimeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.CurrentTime(new CurrentTimeRequest(currentTimeRequestType)).CurrentTimeResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public ServiceContent RetrieveServiceContent()
		{
			ServiceContent result;
			try
			{
				RetrieveServiceContentRequestType retrieveServiceContentRequestType = new RetrieveServiceContentRequestType();
				retrieveServiceContentRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ServiceContent)VIConvert.ToVim(this.VimServiceProxy.RetrieveServiceContent(new RetrieveServiceContentRequest(retrieveServiceContentRequestType)).RetrieveServiceContentResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public Event[] ValidateMigration(ManagedObjectReference[] vm, VirtualMachinePowerState? state, string[] testType, ManagedObjectReference pool, ManagedObjectReference host)
		{
			Event[] result;
			try
			{
				ValidateMigrationRequestType validateMigrationRequestType = new ValidateMigrationRequestType();
				validateMigrationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				validateMigrationRequestType.vm = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(vm);
				validateMigrationRequestType.state = (VimApi_65.VirtualMachinePowerState)VIConvert.ToWsdlType(state.GetValueOrDefault());
				validateMigrationRequestType.stateSpecified = state.HasValue;
				validateMigrationRequestType.testType = testType;
				validateMigrationRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				validateMigrationRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (Event[])VIConvert.ToVim(this.VimServiceProxy.ValidateMigration(new ValidateMigrationRequest(validateMigrationRequestType)).ValidateMigrationResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostVMotionCompatibility[] QueryVMotionCompatibility(ManagedObjectReference vm, ManagedObjectReference[] host, string[] compatibility)
		{
			HostVMotionCompatibility[] result;
			try
			{
				QueryVMotionCompatibilityRequestType queryVMotionCompatibilityRequestType = new QueryVMotionCompatibilityRequestType();
				queryVMotionCompatibilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVMotionCompatibilityRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				queryVMotionCompatibilityRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				queryVMotionCompatibilityRequestType.compatibility = compatibility;
				result = (HostVMotionCompatibility[])VIConvert.ToVim(this.VimServiceProxy.QueryVMotionCompatibility(new QueryVMotionCompatibilityRequest(queryVMotionCompatibilityRequestType)).QueryVMotionCompatibilityResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ProductComponentInfo[] RetrieveProductComponents()
		{
			ProductComponentInfo[] result;
			try
			{
				RetrieveProductComponentsRequestType retrieveProductComponentsRequestType = new RetrieveProductComponentsRequestType();
				retrieveProductComponentsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ProductComponentInfo[])VIConvert.ToVim(this.VimServiceProxy.RetrieveProductComponents(new RetrieveProductComponentsRequest(retrieveProductComponentsRequestType)).RetrieveProductComponentsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

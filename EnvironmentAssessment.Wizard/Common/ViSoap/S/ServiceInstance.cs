using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ServiceInstance(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DateTime CurrentTime()
		{
			DateTime result;
			try
			{
				result = ((VimService)this.Client.VimService).CurrentTime((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ServiceContent RetrieveServiceContent()
		{
			ServiceContent result;
			try
			{
				result = (ServiceContent)VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveServiceContent((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public Event[] ValidateMigration(ManagedObjectReference[] vm, VirtualMachinePowerState? state, string[] testType, ManagedObjectReference pool, ManagedObjectReference host)
		{
			Event[] result;
			try
			{
				result = (Event[])VIConvert.ToVim(((VimService)this.Client.VimService).ValidateMigration((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(vm), (VimApi_60.VirtualMachinePowerState)VIConvert.ToWsdlType(state.GetValueOrDefault()), state.HasValue, testType, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostVMotionCompatibility[] QueryVMotionCompatibility(ManagedObjectReference vm, ManagedObjectReference[] host, string[] compatibility)
		{
			HostVMotionCompatibility[] result;
			try
			{
				result = (HostVMotionCompatibility[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryVMotionCompatibility((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vm), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host), compatibility));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ProductComponentInfo[] RetrieveProductComponents()
		{
			ProductComponentInfo[] result;
			try
			{
				result = (ProductComponentInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveProductComponents((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

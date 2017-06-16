using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMemorySystem : ExtensibleManagedObject
	{
		protected ServiceConsoleReservationInfo _consoleReservationInfo;
		protected VirtualMachineMemoryReservationInfo _virtualMachineReservationInfo;
		public ServiceConsoleReservationInfo ConsoleReservationInfo
		{
			get
			{
				return this._consoleReservationInfo;
			}
		}
		public VirtualMachineMemoryReservationInfo VirtualMachineReservationInfo
		{
			get
			{
				return this._virtualMachineReservationInfo;
			}
		}
		public HostMemorySystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void ReconfigureServiceConsoleReservation(long cfgBytes)
		{
			try
			{
				((VimService)this.Client.VimService).ReconfigureServiceConsoleReservation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), cfgBytes);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ReconfigureVirtualMachineReservation(VirtualMachineMemoryReservationSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).ReconfigureVirtualMachineReservation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VirtualMachineMemoryReservationSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

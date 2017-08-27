using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
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
				ReconfigureServiceConsoleReservationRequestType reconfigureServiceConsoleReservationRequestType = new ReconfigureServiceConsoleReservationRequestType();
				reconfigureServiceConsoleReservationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureServiceConsoleReservationRequestType.cfgBytes = cfgBytes;
				this.VimServiceProxy.ReconfigureServiceConsoleReservation(new ReconfigureServiceConsoleReservationRequest(reconfigureServiceConsoleReservationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReconfigureVirtualMachineReservation(VirtualMachineMemoryReservationSpec spec)
		{
			try
			{
				ReconfigureVirtualMachineReservationRequestType reconfigureVirtualMachineReservationRequestType = new ReconfigureVirtualMachineReservationRequestType();
				reconfigureVirtualMachineReservationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureVirtualMachineReservationRequestType.spec = (VimApi_65.VirtualMachineMemoryReservationSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ReconfigureVirtualMachineReservation(new ReconfigureVirtualMachineReservationRequest(reconfigureVirtualMachineReservationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

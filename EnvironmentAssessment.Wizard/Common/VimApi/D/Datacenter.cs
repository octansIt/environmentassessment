using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class Datacenter : ManagedEntity
	{
		protected ManagedObjectReference _vmFolder;
		protected ManagedObjectReference _hostFolder;
		protected ManagedObjectReference _datastoreFolder;
		protected ManagedObjectReference _networkFolder;
		protected ManagedObjectReference[] _datastore;
		protected ManagedObjectReference[] _network;
		protected DatacenterConfigInfo _configuration;
		public ManagedObjectReference VmFolder
		{
			get
			{
				return this._vmFolder;
			}
		}
		public ManagedObjectReference HostFolder
		{
			get
			{
				return this._hostFolder;
			}
		}
		public ManagedObjectReference DatastoreFolder
		{
			get
			{
				return this._datastoreFolder;
			}
		}
		public ManagedObjectReference NetworkFolder
		{
			get
			{
				return this._networkFolder;
			}
		}
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public ManagedObjectReference[] Network
		{
			get
			{
				return this._network;
			}
		}
		public DatacenterConfigInfo Configuration
		{
			get
			{
				return this._configuration;
			}
		}
		public new Datacenter_LinkedView LinkedView
		{
			get
			{
				return (Datacenter_LinkedView)this._linkedView;
			}
		}
		public Datacenter(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostConnectInfo QueryConnectionInfo(string hostname, int port, string username, string password, string sslThumbprint)
		{
			HostConnectInfo result;
			try
			{
				QueryConnectionInfoRequestType queryConnectionInfoRequestType = new QueryConnectionInfoRequestType();
				queryConnectionInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConnectionInfoRequestType.hostname = hostname;
				queryConnectionInfoRequestType.port = port;
				queryConnectionInfoRequestType.username = username;
				queryConnectionInfoRequestType.password = password;
				queryConnectionInfoRequestType.sslThumbprint = sslThumbprint;
				result = (HostConnectInfo)VIConvert.ToVim(this.VimServiceProxy.QueryConnectionInfo(new QueryConnectionInfoRequest(queryConnectionInfoRequestType)).QueryConnectionInfoResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostConnectInfo QueryConnectionInfoViaSpec(HostConnectSpec spec)
		{
			HostConnectInfo result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryConnectionInfoViaSpecRequestType queryConnectionInfoViaSpecRequestType = new QueryConnectionInfoViaSpecRequestType();
				queryConnectionInfoViaSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryConnectionInfoViaSpecRequestType.spec = (VimApi_65.HostConnectSpec)VIConvert.ToWsdlType(spec);
				result = (HostConnectInfo)VIConvert.ToVim(this.VimServiceProxy.QueryConnectionInfoViaSpec(new QueryConnectionInfoViaSpecRequest(queryConnectionInfoViaSpecRequestType)).QueryConnectionInfoViaSpecResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference PowerOnMultiVM_Task(ManagedObjectReference[] vm, OptionValue[] option)
		{
			ManagedObjectReference result;
			try
			{
				PowerOnMultiVMRequestType powerOnMultiVMRequestType = new PowerOnMultiVMRequestType();
				powerOnMultiVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				powerOnMultiVMRequestType.vm = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(vm);
				powerOnMultiVMRequestType.option = (VimApi_65.OptionValue[])VIConvert.ToWsdlType(option);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerOnMultiVM_Task(new PowerOnMultiVM_TaskRequest(powerOnMultiVMRequestType)).PowerOnMultiVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ClusterPowerOnVmResult PowerOnMultiVM(ManagedObjectReference[] vm, OptionValue[] option)
		{
			ClusterPowerOnVmResult result;
			try
			{
				ManagedObjectReference taskReference = this.PowerOnMultiVM_Task(vm, option);
				result = (ClusterPowerOnVmResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VirtualMachineConfigOptionDescriptor[] queryDatacenterConfigOptionDescriptor()
		{
			VirtualMachineConfigOptionDescriptor[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				queryDatacenterConfigOptionDescriptorRequestType queryDatacenterConfigOptionDescriptorRequestType = new queryDatacenterConfigOptionDescriptorRequestType();
				queryDatacenterConfigOptionDescriptorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VirtualMachineConfigOptionDescriptor[])VIConvert.ToVim(this.VimServiceProxy.queryDatacenterConfigOptionDescriptor(new queryDatacenterConfigOptionDescriptorRequest(queryDatacenterConfigOptionDescriptorRequestType)).queryDatacenterConfigOptionDescriptorResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ReconfigureDatacenter_Task(DatacenterConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
                ReconfigureDatacenterRequestType reconfigureDatacenterRequestType = new ReconfigureDatacenterRequestType();
				reconfigureDatacenterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureDatacenterRequestType.spec = (VimApi_65.DatacenterConfigSpec)VIConvert.ToWsdlType(spec);
				reconfigureDatacenterRequestType.modify = modify;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureDatacenter_Task(new ReconfigureDatacenter_TaskRequest(reconfigureDatacenterRequestType)).ReconfigureDatacenter_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureDatacenter(DatacenterConfigSpec spec, bool modify)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
                ManagedObjectReference taskReference = this.ReconfigureDatacenter_Task(spec, modify);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

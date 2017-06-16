using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public Datacenter(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostConnectInfo QueryConnectionInfo(string hostname, int port, string username, string password, string sslThumbprint)
		{
			HostConnectInfo result;
			try
			{
				result = (HostConnectInfo)VIConvert.ToVim(((VimService)this.Client.VimService).QueryConnectionInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), hostname, port, username, password, sslThumbprint));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference PowerOnMultiVM_Task(ManagedObjectReference[] vm, OptionValue[] option)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerOnMultiVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(vm), (VimApi_60.OptionValue[])VIConvert.ToWsdlType(option)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ClusterPowerOnVmResult PowerOnMultiVM(ManagedObjectReference[] vm, OptionValue[] option)
		{
			ClusterPowerOnVmResult result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).PowerOnMultiVM_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(vm), (VimApi_60.OptionValue[])VIConvert.ToWsdlType(option)));
				result = (ClusterPowerOnVmResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VirtualMachineConfigOptionDescriptor[] queryDatacenterConfigOptionDescriptor()
		{
			VirtualMachineConfigOptionDescriptor[] result;
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
				result = (VirtualMachineConfigOptionDescriptor[])VIConvert.ToVim(((VimService)this.Client.VimService).queryDatacenterConfigOptionDescriptor((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference ReconfigureDatacenter_Task(DatacenterConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureDatacenter_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DatacenterConfigSpec)VIConvert.ToWsdlType(spec), modify));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ReconfigureDatacenter(DatacenterConfigSpec spec, bool modify)
		{
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
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureDatacenter_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DatacenterConfigSpec)VIConvert.ToWsdlType(spec), modify));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

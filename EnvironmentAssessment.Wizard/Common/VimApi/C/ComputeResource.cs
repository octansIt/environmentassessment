
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class ComputeResource : ManagedEntity
	{
		protected ManagedObjectReference _resourcePool;
		protected ManagedObjectReference[] _host;
		protected ManagedObjectReference[] _datastore;
		protected ManagedObjectReference[] _network;
		protected ComputeResourceSummary _summary;
		protected ManagedObjectReference _environmentBrowser;
		protected ComputeResourceConfigInfo _configurationEx;
		public ManagedObjectReference ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
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
		public ComputeResourceSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public ManagedObjectReference EnvironmentBrowser
		{
			get
			{
				return this._environmentBrowser;
			}
		}
		public ComputeResourceConfigInfo ConfigurationEx
		{
			get
			{
				return this._configurationEx;
			}
		}
		public new ComputeResource_LinkedView LinkedView
		{
			get
			{
				return (ComputeResource_LinkedView)this._linkedView;
			}
		}
		public ComputeResource(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ReconfigureComputeResource_Task(ComputeResourceConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
				ReconfigureComputeResourceRequestType reconfigureComputeResourceRequestType = new ReconfigureComputeResourceRequestType();
				reconfigureComputeResourceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureComputeResourceRequestType.spec = (VimApi_65.ComputeResourceConfigSpec)VIConvert.ToWsdlType(spec);
				reconfigureComputeResourceRequestType.modify = modify;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigureComputeResource_Task(new ReconfigureComputeResource_TaskRequest(reconfigureComputeResourceRequestType)).ReconfigureComputeResource_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigureComputeResource(ComputeResourceConfigSpec spec, bool modify)
		{
			try
			{
				ManagedObjectReference taskReference = this.ReconfigureComputeResource_Task(spec, modify);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

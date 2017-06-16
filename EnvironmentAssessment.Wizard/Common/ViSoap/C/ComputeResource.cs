using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ComputeResource(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ReconfigureComputeResource_Task(ComputeResourceConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureComputeResource_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ComputeResourceConfigSpec)VIConvert.ToWsdlType(spec), modify));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ReconfigureComputeResource(ComputeResourceConfigSpec spec, bool modify)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureComputeResource_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ComputeResourceConfigSpec)VIConvert.ToWsdlType(spec), modify));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

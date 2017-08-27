using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class Network : ManagedEntity
	{
		protected new string _name;
		protected NetworkSummary _summary;
		protected ManagedObjectReference[] _host;
		protected ManagedObjectReference[] _vm;
		public new string Name
		{
			get
			{
				return this._name;
			}
		}
		public NetworkSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public new Network_LinkedView LinkedView
		{
			get
			{
				return (Network_LinkedView)this._linkedView;
			}
		}
		public Network(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void DestroyNetwork()
		{
			try
			{
				DestroyNetworkRequestType destroyNetworkRequestType = new DestroyNetworkRequestType();
				destroyNetworkRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyNetwork(new DestroyNetworkRequest(destroyNetworkRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

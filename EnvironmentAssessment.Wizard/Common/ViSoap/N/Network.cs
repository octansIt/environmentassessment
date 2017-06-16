using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public Network(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void DestroyNetwork()
		{
			try
			{
				((VimService)this.Client.VimService).DestroyNetwork((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

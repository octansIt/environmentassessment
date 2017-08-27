using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyFilter : ViewBase
	{
		protected PropertyFilterSpec _spec;
		protected bool _partialUpdates;
		public PropertyFilterSpec Spec
		{
			get
			{
				return this._spec;
			}
		}
		public bool PartialUpdates
		{
			get
			{
				return this._partialUpdates;
			}
		}
		public PropertyFilter(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void DestroyPropertyFilter()
		{
			try
			{
				DestroyPropertyFilterRequestType destroyPropertyFilterRequestType = new DestroyPropertyFilterRequestType();
				destroyPropertyFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyPropertyFilter(new DestroyPropertyFilterRequest(destroyPropertyFilterRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

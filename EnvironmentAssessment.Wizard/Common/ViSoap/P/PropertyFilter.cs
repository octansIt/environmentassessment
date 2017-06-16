using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				((VimService)this.Client.VimService).DestroyPropertyFilter((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

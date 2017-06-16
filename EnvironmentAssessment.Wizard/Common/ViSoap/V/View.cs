using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class View : ViewBase
	{
		public View(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void DestroyView()
		{
			try
			{
				((VimService)this.Client.VimService).DestroyView((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

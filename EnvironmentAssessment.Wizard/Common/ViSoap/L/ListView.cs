using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class ListView : ManagedObjectView
	{
		public ListView(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference[] ModifyListView(ManagedObjectReference[] add, ManagedObjectReference[] remove)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).ModifyListView((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(add), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(remove)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] ResetListView(ManagedObjectReference[] obj)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).ResetListView((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(obj)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ResetListViewFromView(ManagedObjectReference view)
		{
			try
			{
				((VimService)this.Client.VimService).ResetListViewFromView((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(view));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class InventoryView : ManagedObjectView
	{
		public InventoryView(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference[] OpenInventoryViewFolder(ManagedObjectReference[] entity)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).OpenInventoryViewFolder((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] CloseInventoryViewFolder(ManagedObjectReference[] entity)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).CloseInventoryViewFolder((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

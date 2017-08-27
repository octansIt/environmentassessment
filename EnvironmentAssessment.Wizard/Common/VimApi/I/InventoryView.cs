using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				OpenInventoryViewFolderRequestType openInventoryViewFolderRequestType = new OpenInventoryViewFolderRequestType();
				openInventoryViewFolderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				openInventoryViewFolderRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.OpenInventoryViewFolder(new OpenInventoryViewFolderRequest(openInventoryViewFolderRequestType)).OpenInventoryViewFolderResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] CloseInventoryViewFolder(ManagedObjectReference[] entity)
		{
			ManagedObjectReference[] result;
			try
			{
				CloseInventoryViewFolderRequestType closeInventoryViewFolderRequestType = new CloseInventoryViewFolderRequestType();
				closeInventoryViewFolderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				closeInventoryViewFolderRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.CloseInventoryViewFolder(new CloseInventoryViewFolderRequest(closeInventoryViewFolderRequestType)).CloseInventoryViewFolderResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

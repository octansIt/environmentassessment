using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				ModifyListViewRequestType modifyListViewRequestType = new ModifyListViewRequestType();
				modifyListViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				modifyListViewRequestType.add = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(add);
				modifyListViewRequestType.remove = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(remove);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.ModifyListView(new ModifyListViewRequest(modifyListViewRequestType)).ModifyListViewResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] ResetListView(ManagedObjectReference[] obj)
		{
			ManagedObjectReference[] result;
			try
			{
				ResetListViewRequestType resetListViewRequestType = new ResetListViewRequestType();
				resetListViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resetListViewRequestType.obj = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(obj);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.ResetListView(new ResetListViewRequest(resetListViewRequestType)).ResetListViewResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ResetListViewFromView(ManagedObjectReference view)
		{
			try
			{
				ResetListViewFromViewRequestType resetListViewFromViewRequestType = new ResetListViewFromViewRequestType();
				resetListViewFromViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resetListViewFromViewRequestType.view = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(view);
				this.VimServiceProxy.ResetListViewFromView(new ResetListViewFromViewRequest(resetListViewFromViewRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

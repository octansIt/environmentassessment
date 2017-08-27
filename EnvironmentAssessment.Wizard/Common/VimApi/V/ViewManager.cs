using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ViewManager : ViewBase
	{
		protected ManagedObjectReference[] _viewList;
		protected ViewManager_LinkedView _linkedView;
		public ManagedObjectReference[] ViewList
		{
			get
			{
				return this._viewList;
			}
		}
		public ViewManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public ViewManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateInventoryView()
		{
			ManagedObjectReference result;
			try
			{
				CreateInventoryViewRequestType createInventoryViewRequestType = new CreateInventoryViewRequestType();
				createInventoryViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateInventoryView(new CreateInventoryViewRequest(createInventoryViewRequestType)).CreateInventoryViewResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateContainerView(ManagedObjectReference container, string[] type, bool recursive)
		{
			ManagedObjectReference result;
			try
			{
				CreateContainerViewRequestType createContainerViewRequestType = new CreateContainerViewRequestType();
				createContainerViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createContainerViewRequestType.container = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(container);
				createContainerViewRequestType.type = type;
				createContainerViewRequestType.recursive = recursive;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateContainerView(new CreateContainerViewRequest(createContainerViewRequestType)).CreateContainerViewResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateListView(ManagedObjectReference[] obj)
		{
			ManagedObjectReference result;
			try
			{
				CreateListViewRequestType createListViewRequestType = new CreateListViewRequestType();
				createListViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createListViewRequestType.obj = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(obj);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateListView(new CreateListViewRequest(createListViewRequestType)).CreateListViewResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateListViewFromView(ManagedObjectReference view)
		{
			ManagedObjectReference result;
			try
			{
				CreateListViewFromViewRequestType createListViewFromViewRequestType = new CreateListViewFromViewRequestType();
				createListViewFromViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createListViewFromViewRequestType.view = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(view);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateListViewFromView(new CreateListViewFromViewRequest(createListViewFromViewRequestType)).CreateListViewFromViewResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

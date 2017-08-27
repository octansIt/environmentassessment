using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyCollector : ViewBase
	{
		protected ManagedObjectReference[] _filter;
		protected PropertyCollector_LinkedView _linkedView;
		public ManagedObjectReference[] Filter
		{
			get
			{
				return this._filter;
			}
		}
		public PropertyCollector_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public PropertyCollector(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateFilter(PropertyFilterSpec spec, bool partialUpdates)
		{
			ManagedObjectReference result;
			try
			{
				CreateFilterRequestType createFilterRequestType = new CreateFilterRequestType();
				createFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createFilterRequestType.spec = (VimApi_65.PropertyFilterSpec)VIConvert.ToWsdlType(spec);
				createFilterRequestType.partialUpdates = partialUpdates;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateFilter(new CreateFilterRequest(createFilterRequestType)).CreateFilterResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ObjectContent[] RetrieveProperties(PropertyFilterSpec[] specSet)
		{
			ObjectContent[] result;
			try
			{
				RetrievePropertiesRequestType retrievePropertiesRequestType = new RetrievePropertiesRequestType();
				retrievePropertiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrievePropertiesRequestType.specSet = (VimApi_65.PropertyFilterSpec[])VIConvert.ToWsdlType(specSet);
				result = (ObjectContent[])VIConvert.ToVim(this.VimServiceProxy.RetrieveProperties(new RetrievePropertiesRequest(retrievePropertiesRequestType)).RetrievePropertiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UpdateSet CheckForUpdates(string version)
		{
			UpdateSet result;
			try
			{
				CheckForUpdatesRequestType checkForUpdatesRequestType = new CheckForUpdatesRequestType();
				checkForUpdatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkForUpdatesRequestType.version = version;
				result = (UpdateSet)VIConvert.ToVim(this.VimServiceProxy.CheckForUpdates(new CheckForUpdatesRequest(checkForUpdatesRequestType)).CheckForUpdatesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UpdateSet WaitForUpdates(string version)
		{
			UpdateSet result;
			try
			{
				WaitForUpdatesRequestType waitForUpdatesRequestType = new WaitForUpdatesRequestType();
				waitForUpdatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				waitForUpdatesRequestType.version = version;
				result = (UpdateSet)VIConvert.ToVim(this.VimServiceProxy.WaitForUpdates(new WaitForUpdatesRequest(waitForUpdatesRequestType)).WaitForUpdatesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CancelWaitForUpdates()
		{
			try
			{
				CancelWaitForUpdatesRequestType cancelWaitForUpdatesRequestType = new CancelWaitForUpdatesRequestType();
				cancelWaitForUpdatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.CancelWaitForUpdates(new CancelWaitForUpdatesRequest(cancelWaitForUpdatesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public UpdateSet WaitForUpdatesEx(string version, WaitOptions options)
		{
			UpdateSet result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				WaitForUpdatesExRequestType waitForUpdatesExRequestType = new WaitForUpdatesExRequestType();
				waitForUpdatesExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				waitForUpdatesExRequestType.version = version;
				waitForUpdatesExRequestType.options = (VimApi_65.WaitOptions)VIConvert.ToWsdlType(options);
				result = (UpdateSet)VIConvert.ToVim(this.VimServiceProxy.WaitForUpdatesEx(new WaitForUpdatesExRequest(waitForUpdatesExRequestType)).WaitForUpdatesExResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public RetrieveResult RetrievePropertiesEx(PropertyFilterSpec[] specSet, RetrieveOptions options)
		{
			RetrieveResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				RetrievePropertiesExRequestType retrievePropertiesExRequestType = new RetrievePropertiesExRequestType();
				retrievePropertiesExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrievePropertiesExRequestType.specSet = (VimApi_65.PropertyFilterSpec[])VIConvert.ToWsdlType(specSet);
				retrievePropertiesExRequestType.options = (VimApi_65.RetrieveOptions)VIConvert.ToWsdlType(options);
				result = (RetrieveResult)VIConvert.ToVim(this.VimServiceProxy.RetrievePropertiesEx(new RetrievePropertiesExRequest(retrievePropertiesExRequestType)).RetrievePropertiesExResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public RetrieveResult ContinueRetrievePropertiesEx(string token)
		{
			RetrieveResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ContinueRetrievePropertiesExRequestType continueRetrievePropertiesExRequestType = new ContinueRetrievePropertiesExRequestType();
				continueRetrievePropertiesExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				continueRetrievePropertiesExRequestType.token = token;
				result = (RetrieveResult)VIConvert.ToVim(this.VimServiceProxy.ContinueRetrievePropertiesEx(new ContinueRetrievePropertiesExRequest(continueRetrievePropertiesExRequestType)).ContinueRetrievePropertiesExResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CancelRetrievePropertiesEx(string token)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				CancelRetrievePropertiesExRequestType cancelRetrievePropertiesExRequestType = new CancelRetrievePropertiesExRequestType();
				cancelRetrievePropertiesExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cancelRetrievePropertiesExRequestType.token = token;
				this.VimServiceProxy.CancelRetrievePropertiesEx(new CancelRetrievePropertiesExRequest(cancelRetrievePropertiesExRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreatePropertyCollector()
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				CreatePropertyCollectorRequestType createPropertyCollectorRequestType = new CreatePropertyCollectorRequestType();
				createPropertyCollectorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreatePropertyCollector(new CreatePropertyCollectorRequest(createPropertyCollectorRequestType)).CreatePropertyCollectorResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DestroyPropertyCollector()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				DestroyPropertyCollectorRequestType destroyPropertyCollectorRequestType = new DestroyPropertyCollectorRequestType();
				destroyPropertyCollectorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyPropertyCollector(new DestroyPropertyCollectorRequest(destroyPropertyCollectorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDatastoreBrowser : ViewBase
	{
		protected ManagedObjectReference[] _datastore;
		protected FileQuery[] _supportedType;
		protected HostDatastoreBrowser_LinkedView _linkedView;
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public FileQuery[] SupportedType
		{
			get
			{
				return this._supportedType;
			}
		}
		public HostDatastoreBrowser_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public HostDatastoreBrowser(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference SearchDatastore_Task(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).SearchDatastore_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), datastorePath, (VimApi_60.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDatastoreBrowserSearchResults SearchDatastore(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			HostDatastoreBrowserSearchResults result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).SearchDatastore_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), datastorePath, (VimApi_60.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec)));
				result = (HostDatastoreBrowserSearchResults)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference SearchDatastoreSubFolders_Task(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).SearchDatastoreSubFolders_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), datastorePath, (VimApi_60.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDatastoreBrowserSearchResults[] SearchDatastoreSubFolders(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			HostDatastoreBrowserSearchResults[] result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).SearchDatastoreSubFolders_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), datastorePath, (VimApi_60.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec)));
				result = (HostDatastoreBrowserSearchResults[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DeleteFile(string datastorePath)
		{
			try
			{
				((VimService)this.Client.VimService).DeleteFile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), datastorePath);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

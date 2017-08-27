using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				SearchDatastoreRequestType searchDatastoreRequestType = new SearchDatastoreRequestType();
				searchDatastoreRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				searchDatastoreRequestType.datastorePath = datastorePath;
				searchDatastoreRequestType.searchSpec = (VimApi_65.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.SearchDatastore_Task(new SearchDatastore_TaskRequest(searchDatastoreRequestType)).SearchDatastore_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDatastoreBrowserSearchResults SearchDatastore(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			HostDatastoreBrowserSearchResults result;
			try
			{
				ManagedObjectReference taskReference = this.SearchDatastore_Task(datastorePath, searchSpec);
				result = (HostDatastoreBrowserSearchResults)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference SearchDatastoreSubFolders_Task(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			ManagedObjectReference result;
			try
			{
				SearchDatastoreSubFoldersRequestType searchDatastoreSubFoldersRequestType = new SearchDatastoreSubFoldersRequestType();
				searchDatastoreSubFoldersRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				searchDatastoreSubFoldersRequestType.datastorePath = datastorePath;
				searchDatastoreSubFoldersRequestType.searchSpec = (VimApi_65.HostDatastoreBrowserSearchSpec)VIConvert.ToWsdlType(searchSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.SearchDatastoreSubFolders_Task(new SearchDatastoreSubFolders_TaskRequest(searchDatastoreSubFoldersRequestType)).SearchDatastoreSubFolders_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDatastoreBrowserSearchResults[] SearchDatastoreSubFolders(string datastorePath, HostDatastoreBrowserSearchSpec searchSpec)
		{
			HostDatastoreBrowserSearchResults[] result;
			try
			{
				ManagedObjectReference taskReference = this.SearchDatastoreSubFolders_Task(datastorePath, searchSpec);
				result = (HostDatastoreBrowserSearchResults[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteFile(string datastorePath)
		{
			try
			{
				DeleteFileRequestType deleteFileRequestType = new DeleteFileRequestType();
				deleteFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteFileRequestType.datastorePath = datastorePath;
				this.VimServiceProxy.DeleteFile(new DeleteFileRequest(deleteFileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

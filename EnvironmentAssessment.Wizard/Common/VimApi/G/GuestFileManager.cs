using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestFileManager : ViewBase
	{
		public GuestFileManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void MakeDirectoryInGuest(ManagedObjectReference vm, GuestAuthentication auth, string directoryPath, bool createParentDirectories)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				MakeDirectoryInGuestRequestType makeDirectoryInGuestRequestType = new MakeDirectoryInGuestRequestType();
				makeDirectoryInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				makeDirectoryInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				makeDirectoryInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				makeDirectoryInGuestRequestType.directoryPath = directoryPath;
				makeDirectoryInGuestRequestType.createParentDirectories = createParentDirectories;
				this.VimServiceProxy.MakeDirectoryInGuest(new MakeDirectoryInGuestRequest(makeDirectoryInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeleteFileInGuest(ManagedObjectReference vm, GuestAuthentication auth, string filePath)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DeleteFileInGuestRequestType deleteFileInGuestRequestType = new DeleteFileInGuestRequestType();
				deleteFileInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteFileInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				deleteFileInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				deleteFileInGuestRequestType.filePath = filePath;
				this.VimServiceProxy.DeleteFileInGuest(new DeleteFileInGuestRequest(deleteFileInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DeleteDirectoryInGuest(ManagedObjectReference vm, GuestAuthentication auth, string directoryPath, bool recursive)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				DeleteDirectoryInGuestRequestType deleteDirectoryInGuestRequestType = new DeleteDirectoryInGuestRequestType();
				deleteDirectoryInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteDirectoryInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				deleteDirectoryInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				deleteDirectoryInGuestRequestType.directoryPath = directoryPath;
				deleteDirectoryInGuestRequestType.recursive = recursive;
				this.VimServiceProxy.DeleteDirectoryInGuest(new DeleteDirectoryInGuestRequest(deleteDirectoryInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MoveDirectoryInGuest(ManagedObjectReference vm, GuestAuthentication auth, string srcDirectoryPath, string dstDirectoryPath)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				MoveDirectoryInGuestRequestType moveDirectoryInGuestRequestType = new MoveDirectoryInGuestRequestType();
				moveDirectoryInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveDirectoryInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				moveDirectoryInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				moveDirectoryInGuestRequestType.srcDirectoryPath = srcDirectoryPath;
				moveDirectoryInGuestRequestType.dstDirectoryPath = dstDirectoryPath;
				this.VimServiceProxy.MoveDirectoryInGuest(new MoveDirectoryInGuestRequest(moveDirectoryInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MoveFileInGuest(ManagedObjectReference vm, GuestAuthentication auth, string srcFilePath, string dstFilePath, bool overwrite)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				MoveFileInGuestRequestType moveFileInGuestRequestType = new MoveFileInGuestRequestType();
				moveFileInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				moveFileInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				moveFileInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				moveFileInGuestRequestType.srcFilePath = srcFilePath;
				moveFileInGuestRequestType.dstFilePath = dstFilePath;
				moveFileInGuestRequestType.overwrite = overwrite;
				this.VimServiceProxy.MoveFileInGuest(new MoveFileInGuestRequest(moveFileInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string CreateTemporaryFileInGuest(ManagedObjectReference vm, GuestAuthentication auth, string prefix, string suffix, string directoryPath)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				CreateTemporaryFileInGuestRequestType createTemporaryFileInGuestRequestType = new CreateTemporaryFileInGuestRequestType();
				createTemporaryFileInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createTemporaryFileInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				createTemporaryFileInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				createTemporaryFileInGuestRequestType.prefix = prefix;
				createTemporaryFileInGuestRequestType.suffix = suffix;
				createTemporaryFileInGuestRequestType.directoryPath = directoryPath;
				returnval = this.VimServiceProxy.CreateTemporaryFileInGuest(new CreateTemporaryFileInGuestRequest(createTemporaryFileInGuestRequestType)).CreateTemporaryFileInGuestResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string CreateTemporaryDirectoryInGuest(ManagedObjectReference vm, GuestAuthentication auth, string prefix, string suffix, string directoryPath)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				CreateTemporaryDirectoryInGuestRequestType createTemporaryDirectoryInGuestRequestType = new CreateTemporaryDirectoryInGuestRequestType();
				createTemporaryDirectoryInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createTemporaryDirectoryInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				createTemporaryDirectoryInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				createTemporaryDirectoryInGuestRequestType.prefix = prefix;
				createTemporaryDirectoryInGuestRequestType.suffix = suffix;
				createTemporaryDirectoryInGuestRequestType.directoryPath = directoryPath;
				returnval = this.VimServiceProxy.CreateTemporaryDirectoryInGuest(new CreateTemporaryDirectoryInGuestRequest(createTemporaryDirectoryInGuestRequestType)).CreateTemporaryDirectoryInGuestResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public GuestListFileInfo ListFilesInGuest(ManagedObjectReference vm, GuestAuthentication auth, string filePath, int? index, int? maxResults, string matchPattern)
		{
			GuestListFileInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ListFilesInGuestRequestType listFilesInGuestRequestType = new ListFilesInGuestRequestType();
				listFilesInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listFilesInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listFilesInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				listFilesInGuestRequestType.filePath = filePath;
				listFilesInGuestRequestType.index = index.GetValueOrDefault();
				listFilesInGuestRequestType.indexSpecified = index.HasValue;
				listFilesInGuestRequestType.maxResults = maxResults.GetValueOrDefault();
				listFilesInGuestRequestType.maxResultsSpecified = maxResults.HasValue;
				listFilesInGuestRequestType.matchPattern = matchPattern;
				result = (GuestListFileInfo)VIConvert.ToVim(this.VimServiceProxy.ListFilesInGuest(new ListFilesInGuestRequest(listFilesInGuestRequestType)).ListFilesInGuestResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ChangeFileAttributesInGuest(ManagedObjectReference vm, GuestAuthentication auth, string guestFilePath, GuestFileAttributes fileAttributes)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ChangeFileAttributesInGuestRequestType changeFileAttributesInGuestRequestType = new ChangeFileAttributesInGuestRequestType();
				changeFileAttributesInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				changeFileAttributesInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				changeFileAttributesInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				changeFileAttributesInGuestRequestType.guestFilePath = guestFilePath;
				changeFileAttributesInGuestRequestType.fileAttributes = (VimApi_65.GuestFileAttributes)VIConvert.ToWsdlType(fileAttributes);
				this.VimServiceProxy.ChangeFileAttributesInGuest(new ChangeFileAttributesInGuestRequest(changeFileAttributesInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public FileTransferInformation InitiateFileTransferFromGuest(ManagedObjectReference vm, GuestAuthentication auth, string guestFilePath)
		{
			FileTransferInformation result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				InitiateFileTransferFromGuestRequestType initiateFileTransferFromGuestRequestType = new InitiateFileTransferFromGuestRequestType();
				initiateFileTransferFromGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				initiateFileTransferFromGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				initiateFileTransferFromGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				initiateFileTransferFromGuestRequestType.guestFilePath = guestFilePath;
				result = (FileTransferInformation)VIConvert.ToVim(this.VimServiceProxy.InitiateFileTransferFromGuest(new InitiateFileTransferFromGuestRequest(initiateFileTransferFromGuestRequestType)).InitiateFileTransferFromGuestResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string InitiateFileTransferToGuest(ManagedObjectReference vm, GuestAuthentication auth, string guestFilePath, GuestFileAttributes fileAttributes, long fileSize, bool overwrite)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				InitiateFileTransferToGuestRequestType initiateFileTransferToGuestRequestType = new InitiateFileTransferToGuestRequestType();
				initiateFileTransferToGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				initiateFileTransferToGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				initiateFileTransferToGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				initiateFileTransferToGuestRequestType.guestFilePath = guestFilePath;
				initiateFileTransferToGuestRequestType.fileAttributes = (VimApi_65.GuestFileAttributes)VIConvert.ToWsdlType(fileAttributes);
				initiateFileTransferToGuestRequestType.fileSize = fileSize;
				initiateFileTransferToGuestRequestType.overwrite = overwrite;
				returnval = this.VimServiceProxy.InitiateFileTransferToGuest(new InitiateFileTransferToGuestRequest(initiateFileTransferToGuestRequestType)).InitiateFileTransferToGuestResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}

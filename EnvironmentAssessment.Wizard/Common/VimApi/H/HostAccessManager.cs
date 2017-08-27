using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAccessManager : ViewBase
	{
		protected HostLockdownMode _lockdownMode;
		public HostLockdownMode LockdownMode
		{
			get
			{
				return this._lockdownMode;
			}
		}
		public HostAccessManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostAccessControlEntry[] RetrieveHostAccessControlEntries()
		{
			HostAccessControlEntry[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RetrieveHostAccessControlEntriesRequestType retrieveHostAccessControlEntriesRequestType = new RetrieveHostAccessControlEntriesRequestType();
				retrieveHostAccessControlEntriesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostAccessControlEntry[])VIConvert.ToVim(this.VimServiceProxy.RetrieveHostAccessControlEntries(new RetrieveHostAccessControlEntriesRequest(retrieveHostAccessControlEntriesRequestType)).RetrieveHostAccessControlEntriesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ChangeAccessMode(string principal, bool isGroup, HostAccessMode accessMode)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ChangeAccessModeRequestType changeAccessModeRequestType = new ChangeAccessModeRequestType();
				changeAccessModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				changeAccessModeRequestType.principal = principal;
				changeAccessModeRequestType.isGroup = isGroup;
				changeAccessModeRequestType.accessMode = (VimApi_65.HostAccessMode)VIConvert.ToWsdlType(accessMode);
				this.VimServiceProxy.ChangeAccessMode(new ChangeAccessModeRequest(changeAccessModeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] QuerySystemUsers()
		{
			string[] querySystemUsersResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QuerySystemUsersRequestType querySystemUsersRequestType = new QuerySystemUsersRequestType();
				querySystemUsersRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				querySystemUsersResponse = this.VimServiceProxy.QuerySystemUsers(new QuerySystemUsersRequest(querySystemUsersRequestType)).QuerySystemUsersResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return querySystemUsersResponse;
		}
		public void UpdateSystemUsers(string[] users)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UpdateSystemUsersRequestType updateSystemUsersRequestType = new UpdateSystemUsersRequestType();
				updateSystemUsersRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateSystemUsersRequestType.users = users;
				this.VimServiceProxy.UpdateSystemUsers(new UpdateSystemUsersRequest(updateSystemUsersRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] QueryLockdownExceptions()
		{
			string[] queryLockdownExceptionsResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				QueryLockdownExceptionsRequestType queryLockdownExceptionsRequestType = new QueryLockdownExceptionsRequestType();
				queryLockdownExceptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryLockdownExceptionsResponse = this.VimServiceProxy.QueryLockdownExceptions(new QueryLockdownExceptionsRequest(queryLockdownExceptionsRequestType)).QueryLockdownExceptionsResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryLockdownExceptionsResponse;
		}
		public void UpdateLockdownExceptions(string[] users)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				UpdateLockdownExceptionsRequestType updateLockdownExceptionsRequestType = new UpdateLockdownExceptionsRequestType();
				updateLockdownExceptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateLockdownExceptionsRequestType.users = users;
				this.VimServiceProxy.UpdateLockdownExceptions(new UpdateLockdownExceptionsRequest(updateLockdownExceptionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ChangeLockdownMode(HostLockdownMode mode)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ChangeLockdownModeRequestType changeLockdownModeRequestType = new ChangeLockdownModeRequestType();
				changeLockdownModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				changeLockdownModeRequestType.mode = (VimApi_65.HostLockdownMode)VIConvert.ToWsdlType(mode);
				this.VimServiceProxy.ChangeLockdownMode(new ChangeLockdownModeRequest(changeLockdownModeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

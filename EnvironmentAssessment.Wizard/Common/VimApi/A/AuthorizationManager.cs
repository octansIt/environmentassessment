
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class AuthorizationManager : ViewBase
	{
		protected AuthorizationPrivilege[] _privilegeList;
		protected AuthorizationRole[] _roleList;
		protected AuthorizationDescription _description;
		public AuthorizationPrivilege[] PrivilegeList
		{
			get
			{
				return this._privilegeList;
			}
		}
		public AuthorizationRole[] RoleList
		{
			get
			{
				return this._roleList;
			}
		}
		public AuthorizationDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public AuthorizationManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public int AddAuthorizationRole(string name, string[] privIds)
		{
			int returnval;
			try
			{
				AddAuthorizationRoleRequestType addAuthorizationRoleRequestType = new AddAuthorizationRoleRequestType();
				addAuthorizationRoleRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addAuthorizationRoleRequestType.name = name;
				addAuthorizationRoleRequestType.privIds = privIds;
				returnval = this.VimServiceProxy.AddAuthorizationRole(new AddAuthorizationRoleRequest(addAuthorizationRoleRequestType)).AddAuthorizationRoleResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void RemoveAuthorizationRole(int roleId, bool failIfUsed)
		{
			try
			{
				RemoveAuthorizationRoleRequestType removeAuthorizationRoleRequestType = new RemoveAuthorizationRoleRequestType();
				removeAuthorizationRoleRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeAuthorizationRoleRequestType.roleId = roleId;
				removeAuthorizationRoleRequestType.failIfUsed = failIfUsed;
				this.VimServiceProxy.RemoveAuthorizationRole(new RemoveAuthorizationRoleRequest(removeAuthorizationRoleRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateAuthorizationRole(int roleId, string newName, string[] privIds)
		{
			try
			{
				UpdateAuthorizationRoleRequestType updateAuthorizationRoleRequestType = new UpdateAuthorizationRoleRequestType();
				updateAuthorizationRoleRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateAuthorizationRoleRequestType.roleId = roleId;
				updateAuthorizationRoleRequestType.newName = newName;
				updateAuthorizationRoleRequestType.privIds = privIds;
				this.VimServiceProxy.UpdateAuthorizationRole(new UpdateAuthorizationRoleRequest(updateAuthorizationRoleRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MergePermissions(int srcRoleId, int dstRoleId)
		{
			try
			{
				MergePermissionsRequestType mergePermissionsRequestType = new MergePermissionsRequestType();
				mergePermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				mergePermissionsRequestType.srcRoleId = srcRoleId;
				mergePermissionsRequestType.dstRoleId = dstRoleId;
				this.VimServiceProxy.MergePermissions(new MergePermissionsRequest(mergePermissionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public Permission[] RetrieveRolePermissions(int roleId)
		{
			Permission[] result;
			try
			{
				RetrieveRolePermissionsRequestType retrieveRolePermissionsRequestType = new RetrieveRolePermissionsRequestType();
				retrieveRolePermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveRolePermissionsRequestType.roleId = roleId;
				result = (Permission[])VIConvert.ToVim(this.VimServiceProxy.RetrieveRolePermissions(new RetrieveRolePermissionsRequest(retrieveRolePermissionsRequestType)).RetrieveRolePermissionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public Permission[] RetrieveEntityPermissions(ManagedObjectReference entity, bool inherited)
		{
			Permission[] result;
			try
			{
				RetrieveEntityPermissionsRequestType retrieveEntityPermissionsRequestType = new RetrieveEntityPermissionsRequestType();
				retrieveEntityPermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveEntityPermissionsRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				retrieveEntityPermissionsRequestType.inherited = inherited;
				result = (Permission[])VIConvert.ToVim(this.VimServiceProxy.RetrieveEntityPermissions(new RetrieveEntityPermissionsRequest(retrieveEntityPermissionsRequestType)).RetrieveEntityPermissionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public Permission[] RetrieveAllPermissions()
		{
			Permission[] result;
			try
			{
				RetrieveAllPermissionsRequestType retrieveAllPermissionsRequestType = new RetrieveAllPermissionsRequestType();
				retrieveAllPermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (Permission[])VIConvert.ToVim(this.VimServiceProxy.RetrieveAllPermissions(new RetrieveAllPermissionsRequest(retrieveAllPermissionsRequestType)).RetrieveAllPermissionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SetEntityPermissions(ManagedObjectReference entity, Permission[] permission)
		{
			try
			{
				SetEntityPermissionsRequestType setEntityPermissionsRequestType = new SetEntityPermissionsRequestType();
				setEntityPermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setEntityPermissionsRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				setEntityPermissionsRequestType.permission = (VimApi_65.Permission[])VIConvert.ToWsdlType(permission);
				this.VimServiceProxy.SetEntityPermissions(new SetEntityPermissionsRequest(setEntityPermissionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ResetEntityPermissions(ManagedObjectReference entity, Permission[] permission)
		{
			try
			{
				ResetEntityPermissionsRequestType resetEntityPermissionsRequestType = new ResetEntityPermissionsRequestType();
				resetEntityPermissionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resetEntityPermissionsRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				resetEntityPermissionsRequestType.permission = (VimApi_65.Permission[])VIConvert.ToWsdlType(permission);
				this.VimServiceProxy.ResetEntityPermissions(new ResetEntityPermissionsRequest(resetEntityPermissionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveEntityPermission(ManagedObjectReference entity, string user, bool isGroup)
		{
			try
			{
				RemoveEntityPermissionRequestType removeEntityPermissionRequestType = new RemoveEntityPermissionRequestType();
				removeEntityPermissionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeEntityPermissionRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				removeEntityPermissionRequestType.user = user;
				removeEntityPermissionRequestType.isGroup = isGroup;
				this.VimServiceProxy.RemoveEntityPermission(new RemoveEntityPermissionRequest(removeEntityPermissionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public bool[] HasPrivilegeOnEntity(ManagedObjectReference entity, string sessionId, string[] privId)
		{
			bool[] hasPrivilegeOnEntityResponse;
			try
			{
				HasPrivilegeOnEntityRequestType hasPrivilegeOnEntityRequestType = new HasPrivilegeOnEntityRequestType();
				hasPrivilegeOnEntityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hasPrivilegeOnEntityRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				hasPrivilegeOnEntityRequestType.sessionId = sessionId;
				hasPrivilegeOnEntityRequestType.privId = privId;
				hasPrivilegeOnEntityResponse = this.VimServiceProxy.HasPrivilegeOnEntity(new HasPrivilegeOnEntityRequest(hasPrivilegeOnEntityRequestType)).HasPrivilegeOnEntityResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return hasPrivilegeOnEntityResponse;
		}
		public EntityPrivilege[] HasPrivilegeOnEntities(ManagedObjectReference[] entity, string sessionId, string[] privId)
		{
			EntityPrivilege[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
                HasPrivilegeOnEntitiesRequestType hasPrivilegeOnEntitiesRequestType = new HasPrivilegeOnEntitiesRequestType();
				hasPrivilegeOnEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hasPrivilegeOnEntitiesRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				hasPrivilegeOnEntitiesRequestType.sessionId = sessionId;
				hasPrivilegeOnEntitiesRequestType.privId = privId;
				result = (EntityPrivilege[])VIConvert.ToVim(this.VimServiceProxy.HasPrivilegeOnEntities(new HasPrivilegeOnEntitiesRequest(hasPrivilegeOnEntitiesRequestType)).HasPrivilegeOnEntitiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public EntityPrivilege[] HasUserPrivilegeOnEntities(ManagedObjectReference[] entities, string userName, string[] privId)
		{
			EntityPrivilege[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                HasUserPrivilegeOnEntitiesRequestType hasUserPrivilegeOnEntitiesRequestType = new HasUserPrivilegeOnEntitiesRequestType();
				hasUserPrivilegeOnEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hasUserPrivilegeOnEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				hasUserPrivilegeOnEntitiesRequestType.userName = userName;
				hasUserPrivilegeOnEntitiesRequestType.privId = privId;
				result = (EntityPrivilege[])VIConvert.ToVim(this.VimServiceProxy.HasUserPrivilegeOnEntities(new HasUserPrivilegeOnEntitiesRequest(hasUserPrivilegeOnEntitiesRequestType)).HasUserPrivilegeOnEntitiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UserPrivilegeResult[] FetchUserPrivilegeOnEntities(ManagedObjectReference[] entities, string userName)
		{
			UserPrivilegeResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                FetchUserPrivilegeOnEntitiesRequestType fetchUserPrivilegeOnEntitiesRequestType = new FetchUserPrivilegeOnEntitiesRequestType();
				fetchUserPrivilegeOnEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				fetchUserPrivilegeOnEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				fetchUserPrivilegeOnEntitiesRequestType.userName = userName;
				result = (UserPrivilegeResult[])VIConvert.ToVim(this.VimServiceProxy.FetchUserPrivilegeOnEntities(new FetchUserPrivilegeOnEntitiesRequest(fetchUserPrivilegeOnEntitiesRequestType)).FetchUserPrivilegeOnEntitiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

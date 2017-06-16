using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public AuthorizationManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public int AddAuthorizationRole(string name, string[] privIds)
		{
			int result;
			try
			{
				result = ((VimService)this.Client.VimService).AddAuthorizationRole((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, privIds);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveAuthorizationRole(int roleId, bool failIfUsed)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveAuthorizationRole((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), roleId, failIfUsed);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateAuthorizationRole(int roleId, string newName, string[] privIds)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateAuthorizationRole((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), roleId, newName, privIds);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void MergePermissions(int srcRoleId, int dstRoleId)
		{
			try
			{
				((VimService)this.Client.VimService).MergePermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), srcRoleId, dstRoleId);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public Permission[] RetrieveRolePermissions(int roleId)
		{
			Permission[] result;
			try
			{
				result = (Permission[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveRolePermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), roleId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public Permission[] RetrieveEntityPermissions(ManagedObjectReference entity, bool inherited)
		{
			Permission[] result;
			try
			{
				result = (Permission[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveEntityPermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), inherited));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public Permission[] RetrieveAllPermissions()
		{
			Permission[] result;
			try
			{
				result = (Permission[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveAllPermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void SetEntityPermissions(ManagedObjectReference entity, Permission[] permission)
		{
			try
			{
				((VimService)this.Client.VimService).SetEntityPermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), (VimApi_60.Permission[])VIConvert.ToWsdlType(permission));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ResetEntityPermissions(ManagedObjectReference entity, Permission[] permission)
		{
			try
			{
				((VimService)this.Client.VimService).ResetEntityPermissions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), (VimApi_60.Permission[])VIConvert.ToWsdlType(permission));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveEntityPermission(ManagedObjectReference entity, string user, bool isGroup)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveEntityPermission((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), user, isGroup);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public bool[] HasPrivilegeOnEntity(ManagedObjectReference entity, string sessionId, string[] privId)
		{
			bool[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = ((VimService)this.Client.VimService).HasPrivilegeOnEntity((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), sessionId, privId);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public EntityPrivilege[] HasPrivilegeOnEntities(ManagedObjectReference[] entity, string sessionId, string[] privId)
		{
			EntityPrivilege[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (EntityPrivilege[])VIConvert.ToVim(((VimService)this.Client.VimService).HasPrivilegeOnEntities((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(entity), sessionId, privId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLocalAccountManager : ViewBase
	{
		public HostLocalAccountManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void CreateUser(HostAccountSpec user)
		{
			try
			{
				CreateUserRequestType createUserRequestType = new CreateUserRequestType();
				createUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createUserRequestType.user = (VimApi_65.HostAccountSpec)VIConvert.ToWsdlType(user);
				this.VimServiceProxy.CreateUser(new CreateUserRequest(createUserRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateUser(HostAccountSpec user)
		{
			try
			{
				UpdateUserRequestType updateUserRequestType = new UpdateUserRequestType();
				updateUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateUserRequestType.user = (VimApi_65.HostAccountSpec)VIConvert.ToWsdlType(user);
				this.VimServiceProxy.UpdateUser(new UpdateUserRequest(updateUserRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void CreateGroup(HostAccountSpec group)
		{
			try
			{
				CreateGroupRequestType createGroupRequestType = new CreateGroupRequestType();
				createGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createGroupRequestType.group = (VimApi_65.HostAccountSpec)VIConvert.ToWsdlType(group);
				this.VimServiceProxy.CreateGroup(new CreateGroupRequest(createGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveUser(string userName)
		{
			try
			{
				RemoveUserRequestType removeUserRequestType = new RemoveUserRequestType();
				removeUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeUserRequestType.userName = userName;
				this.VimServiceProxy.RemoveUser(new RemoveUserRequest(removeUserRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveGroup(string groupName)
		{
			try
			{
				RemoveGroupRequestType removeGroupRequestType = new RemoveGroupRequestType();
				removeGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeGroupRequestType.groupName = groupName;
				this.VimServiceProxy.RemoveGroup(new RemoveGroupRequest(removeGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AssignUserToGroup(string user, string group)
		{
			try
			{
				AssignUserToGroupRequestType assignUserToGroupRequestType = new AssignUserToGroupRequestType();
				assignUserToGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				assignUserToGroupRequestType.user = user;
				assignUserToGroupRequestType.group = group;
				this.VimServiceProxy.AssignUserToGroup(new AssignUserToGroupRequest(assignUserToGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnassignUserFromGroup(string user, string group)
		{
			try
			{
				UnassignUserFromGroupRequestType unassignUserFromGroupRequestType = new UnassignUserFromGroupRequestType();
				unassignUserFromGroupRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unassignUserFromGroupRequestType.user = user;
				unassignUserFromGroupRequestType.group = group;
				this.VimServiceProxy.UnassignUserFromGroup(new UnassignUserFromGroupRequest(unassignUserFromGroupRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

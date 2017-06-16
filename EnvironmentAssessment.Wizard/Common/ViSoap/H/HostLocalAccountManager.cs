using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				((VimService)this.Client.VimService).CreateUser((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostAccountSpec)VIConvert.ToWsdlType(user));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateUser(HostAccountSpec user)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateUser((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostAccountSpec)VIConvert.ToWsdlType(user));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void CreateGroup(HostAccountSpec group)
		{
			try
			{
				((VimService)this.Client.VimService).CreateGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostAccountSpec)VIConvert.ToWsdlType(group));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveUser(string userName)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveUser((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), userName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveGroup(string groupName)
		{
			try
			{
				((VimService)this.Client.VimService).RemoveGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), groupName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void AssignUserToGroup(string user, string group)
		{
			try
			{
				((VimService)this.Client.VimService).AssignUserToGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), user, group);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UnassignUserFromGroup(string user, string group)
		{
			try
			{
				((VimService)this.Client.VimService).UnassignUserFromGroup((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), user, group);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

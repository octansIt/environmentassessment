using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class UserDirectory : ViewBase
	{
		protected string[] _domainList;
		public string[] DomainList
		{
			get
			{
				return this._domainList;
			}
		}
		public UserDirectory(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public UserSearchResult[] RetrieveUserGroups(string domain, string searchStr, string belongsToGroup, string belongsToUser, bool exactMatch, bool findUsers, bool findGroups)
		{
			UserSearchResult[] result;
			try
			{
				RetrieveUserGroupsRequestType retrieveUserGroupsRequestType = new RetrieveUserGroupsRequestType();
				retrieveUserGroupsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveUserGroupsRequestType.domain = domain;
				retrieveUserGroupsRequestType.searchStr = searchStr;
				retrieveUserGroupsRequestType.belongsToGroup = belongsToGroup;
				retrieveUserGroupsRequestType.belongsToUser = belongsToUser;
				retrieveUserGroupsRequestType.exactMatch = exactMatch;
				retrieveUserGroupsRequestType.findUsers = findUsers;
				retrieveUserGroupsRequestType.findGroups = findGroups;
				result = (UserSearchResult[])VIConvert.ToVim(this.VimServiceProxy.RetrieveUserGroups(new RetrieveUserGroupsRequest(retrieveUserGroupsRequestType)).RetrieveUserGroupsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

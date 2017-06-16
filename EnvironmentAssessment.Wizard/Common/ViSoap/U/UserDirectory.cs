using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (UserSearchResult[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveUserGroups((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), domain, searchStr, belongsToGroup, belongsToUser, exactMatch, findUsers, findGroups));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

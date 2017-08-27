using System;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace EnvironmentAssessment.Common.VimApi
{
	public interface IVimClient
	{
		VimVersion Version
		{
			get;
		}
		object VimService
		{
			get;
		}
		ServiceContent ServiceContent
		{
			get;
		}
		string ServiceUrl
		{
			get;
			set;
		}
		int ServiceTimeout
		{
			get;
			set;
		}
		string UserAgent
		{
			get;
			set;
		}
		string SessionSecret
		{
			get;
			set;
		}
		ServiceContent Connect();
		ServiceContent Connect(string serviceUrl);
		ServiceContent Connect(string server, CommunicationProtocol? protocol, ushort? port);
		UserSession Login(string username, string password);
		UserSession Login(string serviceUrl, string username, string password);
		void Logout();
		UserSession ConnectToSession(string serviceUrl, string soapSessionId);
		EntityViewBase FindEntityView(Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties);
		List<EntityViewBase> FindEntityViews(Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties);
		List<ViewBase> GetViews(IEnumerable<ManagedObjectReference> moRefs, params string[] properties);
		List<ViewBase> GetViews(ObjectContent[] objectContent, string[] properties);
		List<ViewBase> GetViewsByMorefs(IEnumerable<ManagedObjectReference> moRefs, params string[] properties);
		ViewBase GetView(ManagedObjectReference moRef, string[] properties);
		void Disconnect();
		[Obsolete("Use the SessionSecret property.")]
		void SaveSession(string fileName);
		[Obsolete("Use the SessionSecret property.")]
		void LoadSession(string fileName);
		bool IsVimVersionOrHigher(VimVersion version);
		object WaitForTask(ManagedObjectReference taskReference);
	}
}

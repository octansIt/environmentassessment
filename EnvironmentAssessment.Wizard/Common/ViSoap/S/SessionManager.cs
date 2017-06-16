using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class SessionManager : ViewBase
	{
		protected UserSession[] _sessionList;
		protected UserSession _currentSession;
		protected string _message;
		protected string[] _messageLocaleList;
		protected string[] _supportedLocaleList;
		protected string _defaultLocale;
		public UserSession[] SessionList
		{
			get
			{
				return this._sessionList;
			}
		}
		public UserSession CurrentSession
		{
			get
			{
				return this._currentSession;
			}
		}
		public string Message
		{
			get
			{
				return this._message;
			}
		}
		public string[] MessageLocaleList
		{
			get
			{
				return this._messageLocaleList;
			}
		}
		public string[] SupportedLocaleList
		{
			get
			{
				return this._supportedLocaleList;
			}
		}
		public string DefaultLocale
		{
			get
			{
				return this._defaultLocale;
			}
		}
		public SessionManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateServiceMessage(string message)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateServiceMessage((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), message);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public UserSession LoginByToken(string locale)
		{
			UserSession result;
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
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).LoginByToken((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UserSession Login(string userName, string password, string locale)
		{
			UserSession result;
			try
			{
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).Login((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), userName, password, locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UserSession LoginBySSPI(string base64Token, string locale)
		{
			UserSession result;
			try
			{
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).LoginBySSPI((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), base64Token, locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void Logout()
		{
			try
			{
				((VimService)this.Client.VimService).Logout((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
                if (ex.Message != "The session is not authenticated.") // zzz - ignore logouts for sessions where we dont have active logins any more anyways
                {
                    throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
                }
			}
		}
		public SessionManagerLocalTicket AcquireLocalTicket(string userName)
		{
			SessionManagerLocalTicket result;
			try
			{
				result = (SessionManagerLocalTicket)VIConvert.ToVim(((VimService)this.Client.VimService).AcquireLocalTicket((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), userName));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public SessionManagerGenericServiceTicket AcquireGenericServiceTicket(SessionManagerServiceRequestSpec spec)
		{
			SessionManagerGenericServiceTicket result;
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
				result = (SessionManagerGenericServiceTicket)VIConvert.ToVim(((VimService)this.Client.VimService).AcquireGenericServiceTicket((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.SessionManagerServiceRequestSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void TerminateSession(string[] sessionId)
		{
			try
			{
				((VimService)this.Client.VimService).TerminateSession((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sessionId);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetLocale(string locale)
		{
			try
			{
				((VimService)this.Client.VimService).SetLocale((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), locale);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public UserSession LoginExtensionBySubjectName(string extensionKey, string locale)
		{
			UserSession result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).LoginExtensionBySubjectName((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UserSession LoginExtensionByCertificate(string extensionKey, string locale)
		{
			UserSession result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).LoginExtensionByCertificate((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UserSession ImpersonateUser(string userName, string locale)
		{
			UserSession result;
			try
			{
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).ImpersonateUser((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), userName, locale));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public bool SessionIsActive(string sessionID, string userName)
		{
			bool result;
			try
			{
				result = ((VimService)this.Client.VimService).SessionIsActive((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sessionID, userName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public string AcquireCloneTicket()
		{
			string result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = ((VimService)this.Client.VimService).AcquireCloneTicket((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UserSession CloneSession(string cloneTicket)
		{
			UserSession result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (UserSession)VIConvert.ToVim(((VimService)this.Client.VimService).CloneSession((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), cloneTicket));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

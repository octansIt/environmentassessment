using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public SessionManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateServiceMessage(string message)
		{
			try
			{
				UpdateServiceMessageRequestType updateServiceMessageRequestType = new UpdateServiceMessageRequestType();
				updateServiceMessageRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateServiceMessageRequestType.message = message;
				this.VimServiceProxy.UpdateServiceMessage(new UpdateServiceMessageRequest(updateServiceMessageRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public UserSession LoginByToken(string locale)
		{
			UserSession result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				LoginByTokenRequestType loginByTokenRequestType = new LoginByTokenRequestType();
				loginByTokenRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				loginByTokenRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.LoginByToken(new LoginByTokenRequest(loginByTokenRequestType)).LoginByTokenResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UserSession Login(string userName, string password, string locale)
		{
			UserSession result;
			try
			{
				LoginRequestType loginRequestType = new LoginRequestType();
				loginRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				loginRequestType.userName = userName;
				loginRequestType.password = password;
				loginRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.Login(new LoginRequest(loginRequestType)).LoginResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UserSession LoginBySSPI(string base64Token, string locale)
		{
			UserSession result;
			try
			{
				LoginBySSPIRequestType loginBySSPIRequestType = new LoginBySSPIRequestType();
				loginBySSPIRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				loginBySSPIRequestType.base64Token = base64Token;
				loginBySSPIRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.LoginBySSPI(new LoginBySSPIRequest(loginBySSPIRequestType)).LoginBySSPIResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void Logout()
		{
			try
			{
				LogoutRequestType logoutRequestType = new LogoutRequestType();
				logoutRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.Logout(new LogoutRequest(logoutRequestType));
			}
			catch (FaultException ex)
			{
				if (ex.Message != "The session is not authenticated") {
					throw FaultUtility.HandleFault(ex);
				}
			}
		}
		public SessionManagerLocalTicket AcquireLocalTicket(string userName)
		{
			SessionManagerLocalTicket result;
			try
			{
				AcquireLocalTicketRequestType acquireLocalTicketRequestType = new AcquireLocalTicketRequestType();
				acquireLocalTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				acquireLocalTicketRequestType.userName = userName;
				result = (SessionManagerLocalTicket)VIConvert.ToVim(this.VimServiceProxy.AcquireLocalTicket(new AcquireLocalTicketRequest(acquireLocalTicketRequestType)).AcquireLocalTicketResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public SessionManagerGenericServiceTicket AcquireGenericServiceTicket(SessionManagerServiceRequestSpec spec)
		{
			SessionManagerGenericServiceTicket result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				AcquireGenericServiceTicketRequestType acquireGenericServiceTicketRequestType = new AcquireGenericServiceTicketRequestType();
				acquireGenericServiceTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				acquireGenericServiceTicketRequestType.spec = (VimApi_65.SessionManagerServiceRequestSpec)VIConvert.ToWsdlType(spec);
				result = (SessionManagerGenericServiceTicket)VIConvert.ToVim(this.VimServiceProxy.AcquireGenericServiceTicket(new AcquireGenericServiceTicketRequest(acquireGenericServiceTicketRequestType)).AcquireGenericServiceTicketResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void TerminateSession(string[] sessionId)
		{
			try
			{
				TerminateSessionRequestType terminateSessionRequestType = new TerminateSessionRequestType();
				terminateSessionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				terminateSessionRequestType.sessionId = sessionId;
				this.VimServiceProxy.TerminateSession(new TerminateSessionRequest(terminateSessionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetLocale(string locale)
		{
			try
			{
				SetLocaleRequestType setLocaleRequestType = new SetLocaleRequestType();
				setLocaleRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setLocaleRequestType.locale = locale;
				this.VimServiceProxy.SetLocale(new SetLocaleRequest(setLocaleRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public UserSession LoginExtensionBySubjectName(string extensionKey, string locale)
		{
			UserSession result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				LoginExtensionBySubjectNameRequestType loginExtensionBySubjectNameRequestType = new LoginExtensionBySubjectNameRequestType();
				loginExtensionBySubjectNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				loginExtensionBySubjectNameRequestType.extensionKey = extensionKey;
				loginExtensionBySubjectNameRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.LoginExtensionBySubjectName(new LoginExtensionBySubjectNameRequest(loginExtensionBySubjectNameRequestType)).LoginExtensionBySubjectNameResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UserSession LoginExtensionByCertificate(string extensionKey, string locale)
		{
			UserSession result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				LoginExtensionByCertificateRequestType loginExtensionByCertificateRequestType = new LoginExtensionByCertificateRequestType();
				loginExtensionByCertificateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				loginExtensionByCertificateRequestType.extensionKey = extensionKey;
				loginExtensionByCertificateRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.LoginExtensionByCertificate(new LoginExtensionByCertificateRequest(loginExtensionByCertificateRequestType)).LoginExtensionByCertificateResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public UserSession ImpersonateUser(string userName, string locale)
		{
			UserSession result;
			try
			{
				ImpersonateUserRequestType impersonateUserRequestType = new ImpersonateUserRequestType();
				impersonateUserRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				impersonateUserRequestType.userName = userName;
				impersonateUserRequestType.locale = locale;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.ImpersonateUser(new ImpersonateUserRequest(impersonateUserRequestType)).ImpersonateUserResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public bool SessionIsActive(string sessionID, string userName)
		{
			bool returnval;
			try
			{
				SessionIsActiveRequestType sessionIsActiveRequestType = new SessionIsActiveRequestType();
				sessionIsActiveRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				sessionIsActiveRequestType.sessionID = sessionID;
				sessionIsActiveRequestType.userName = userName;
				returnval = this.VimServiceProxy.SessionIsActive(new SessionIsActiveRequest(sessionIsActiveRequestType)).SessionIsActiveResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string AcquireCloneTicket()
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				AcquireCloneTicketRequestType acquireCloneTicketRequestType = new AcquireCloneTicketRequestType();
				acquireCloneTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.AcquireCloneTicket(new AcquireCloneTicketRequest(acquireCloneTicketRequestType)).AcquireCloneTicketResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public UserSession CloneSession(string cloneTicket)
		{
			UserSession result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CloneSessionRequestType cloneSessionRequestType = new CloneSessionRequestType();
				cloneSessionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cloneSessionRequestType.cloneTicket = cloneTicket;
				result = (UserSession)VIConvert.ToVim(this.VimServiceProxy.CloneSession(new CloneSessionRequest(cloneSessionRequestType)).CloneSessionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

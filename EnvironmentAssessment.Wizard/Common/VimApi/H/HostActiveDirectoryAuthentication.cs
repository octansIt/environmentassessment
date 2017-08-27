using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class HostActiveDirectoryAuthentication : HostDirectoryStore
	{
		public HostActiveDirectoryAuthentication(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference JoinDomain_Task(string domainName, string userName, string password)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				JoinDomainRequestType joinDomainRequestType = new JoinDomainRequestType();
				joinDomainRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				joinDomainRequestType.domainName = domainName;
				joinDomainRequestType.userName = userName;
				joinDomainRequestType.password = password;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.JoinDomain_Task(new JoinDomain_TaskRequest(joinDomainRequestType)).JoinDomain_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void JoinDomain(string domainName, string userName, string password)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ManagedObjectReference taskReference = this.JoinDomain_Task(domainName, userName, password);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference JoinDomainWithCAM_Task(string domainName, string camServer)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				JoinDomainWithCAMRequestType joinDomainWithCAMRequestType = new JoinDomainWithCAMRequestType();
				joinDomainWithCAMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				joinDomainWithCAMRequestType.domainName = domainName;
				joinDomainWithCAMRequestType.camServer = camServer;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.JoinDomainWithCAM_Task(new JoinDomainWithCAM_TaskRequest(joinDomainWithCAMRequestType)).JoinDomainWithCAM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void JoinDomainWithCAM(string domainName, string camServer)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.JoinDomainWithCAM_Task(domainName, camServer);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ImportCertificateForCAM_Task(string certPath, string camServer)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ImportCertificateForCAMRequestType importCertificateForCAMRequestType = new ImportCertificateForCAMRequestType();
				importCertificateForCAMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				importCertificateForCAMRequestType.certPath = certPath;
				importCertificateForCAMRequestType.camServer = camServer;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ImportCertificateForCAM_Task(new ImportCertificateForCAM_TaskRequest(importCertificateForCAMRequestType)).ImportCertificateForCAM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ImportCertificateForCAM(string certPath, string camServer)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.ImportCertificateForCAM_Task(certPath, camServer);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference LeaveCurrentDomain_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				LeaveCurrentDomainRequestType leaveCurrentDomainRequestType = new LeaveCurrentDomainRequestType();
				leaveCurrentDomainRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				leaveCurrentDomainRequestType.force = force;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.LeaveCurrentDomain_Task(new LeaveCurrentDomain_TaskRequest(leaveCurrentDomainRequestType)).LeaveCurrentDomain_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void LeaveCurrentDomain(bool force)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ManagedObjectReference taskReference = this.LeaveCurrentDomain_Task(force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void EnableSmartCardAuthentication()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				EnableSmartCardAuthenticationRequestType enableSmartCardAuthenticationRequestType = new EnableSmartCardAuthenticationRequestType();
				enableSmartCardAuthenticationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.EnableSmartCardAuthentication(new EnableSmartCardAuthenticationRequest(enableSmartCardAuthenticationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void InstallSmartCardTrustAnchor(string cert)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				InstallSmartCardTrustAnchorRequestType installSmartCardTrustAnchorRequestType = new InstallSmartCardTrustAnchorRequestType();
				installSmartCardTrustAnchorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				installSmartCardTrustAnchorRequestType.cert = cert;
				this.VimServiceProxy.InstallSmartCardTrustAnchor(new InstallSmartCardTrustAnchorRequest(installSmartCardTrustAnchorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReplaceSmartCardTrustAnchors(string[] certs)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ReplaceSmartCardTrustAnchorsRequestType replaceSmartCardTrustAnchorsRequestType = new ReplaceSmartCardTrustAnchorsRequestType();
				replaceSmartCardTrustAnchorsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				replaceSmartCardTrustAnchorsRequestType.certs = certs;
				this.VimServiceProxy.ReplaceSmartCardTrustAnchors(new ReplaceSmartCardTrustAnchorsRequest(replaceSmartCardTrustAnchorsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveSmartCardTrustAnchor(string issuer, string serial)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RemoveSmartCardTrustAnchorRequestType removeSmartCardTrustAnchorRequestType = new RemoveSmartCardTrustAnchorRequestType();
				removeSmartCardTrustAnchorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeSmartCardTrustAnchorRequestType.issuer = issuer;
				removeSmartCardTrustAnchorRequestType.serial = serial;
				this.VimServiceProxy.RemoveSmartCardTrustAnchor(new RemoveSmartCardTrustAnchorRequest(removeSmartCardTrustAnchorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveSmartCardTrustAnchorByFingerprint(string fingerprint, string digest)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				RemoveSmartCardTrustAnchorByFingerprintRequestType removeSmartCardTrustAnchorByFingerprintRequestType = new RemoveSmartCardTrustAnchorByFingerprintRequestType();
				removeSmartCardTrustAnchorByFingerprintRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeSmartCardTrustAnchorByFingerprintRequestType.fingerprint = fingerprint;
				removeSmartCardTrustAnchorByFingerprintRequestType.digest = digest;
				this.VimServiceProxy.RemoveSmartCardTrustAnchorByFingerprint(new RemoveSmartCardTrustAnchorByFingerprintRequest(removeSmartCardTrustAnchorByFingerprintRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] ListSmartCardTrustAnchors()
		{
			string[] listSmartCardTrustAnchorsResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListSmartCardTrustAnchorsRequestType listSmartCardTrustAnchorsRequestType = new ListSmartCardTrustAnchorsRequestType();
				listSmartCardTrustAnchorsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listSmartCardTrustAnchorsResponse = this.VimServiceProxy.ListSmartCardTrustAnchors(new ListSmartCardTrustAnchorsRequest(listSmartCardTrustAnchorsRequestType)).ListSmartCardTrustAnchorsResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return listSmartCardTrustAnchorsResponse;
		}
		public void DisableSmartCardAuthentication()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DisableSmartCardAuthenticationRequestType disableSmartCardAuthenticationRequestType = new DisableSmartCardAuthenticationRequestType();
				disableSmartCardAuthenticationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DisableSmartCardAuthentication(new DisableSmartCardAuthenticationRequest(disableSmartCardAuthenticationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

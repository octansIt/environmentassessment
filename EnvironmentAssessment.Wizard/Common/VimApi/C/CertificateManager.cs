
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class CertificateManager : ViewBase
	{
		public CertificateManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CertMgrRefreshCACertificatesAndCRLs_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				CertMgrRefreshCACertificatesAndCRLsRequestType certMgrRefreshCACertificatesAndCRLsRequestType = new CertMgrRefreshCACertificatesAndCRLsRequestType();
				certMgrRefreshCACertificatesAndCRLsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				certMgrRefreshCACertificatesAndCRLsRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CertMgrRefreshCACertificatesAndCRLs_Task(new CertMgrRefreshCACertificatesAndCRLs_TaskRequest(certMgrRefreshCACertificatesAndCRLsRequestType)).CertMgrRefreshCACertificatesAndCRLs_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CertMgrRefreshCACertificatesAndCRLs(ManagedObjectReference[] host)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.CertMgrRefreshCACertificatesAndCRLs_Task(host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CertMgrRefreshCertificates_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                CertMgrRefreshCertificatesRequestType certMgrRefreshCertificatesRequestType = new CertMgrRefreshCertificatesRequestType();
				certMgrRefreshCertificatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				certMgrRefreshCertificatesRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CertMgrRefreshCertificates_Task(new CertMgrRefreshCertificates_TaskRequest(certMgrRefreshCertificatesRequestType)).CertMgrRefreshCertificates_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CertMgrRefreshCertificates(ManagedObjectReference[] host)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.CertMgrRefreshCertificates_Task(host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CertMgrRevokeCertificates_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                CertMgrRevokeCertificatesRequestType certMgrRevokeCertificatesRequestType = new CertMgrRevokeCertificatesRequestType();
				certMgrRevokeCertificatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				certMgrRevokeCertificatesRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CertMgrRevokeCertificates_Task(new CertMgrRevokeCertificates_TaskRequest(certMgrRevokeCertificatesRequestType)).CertMgrRevokeCertificates_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CertMgrRevokeCertificates(ManagedObjectReference[] host)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
                ManagedObjectReference taskReference = this.CertMgrRevokeCertificates_Task(host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

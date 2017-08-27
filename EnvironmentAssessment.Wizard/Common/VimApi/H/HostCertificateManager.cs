using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCertificateManager : ViewBase
	{
		protected HostCertificateManagerCertificateInfo _certificateInfo;
		public HostCertificateManagerCertificateInfo CertificateInfo
		{
			get
			{
				return this._certificateInfo;
			}
		}
		public HostCertificateManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string GenerateCertificateSigningRequest(bool useIpAddressAsCommonName)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				GenerateCertificateSigningRequestRequestType generateCertificateSigningRequestRequestType = new GenerateCertificateSigningRequestRequestType();
				generateCertificateSigningRequestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateCertificateSigningRequestRequestType.useIpAddressAsCommonName = useIpAddressAsCommonName;
				returnval = this.VimServiceProxy.GenerateCertificateSigningRequest(new GenerateCertificateSigningRequestRequest(generateCertificateSigningRequestRequestType)).GenerateCertificateSigningRequestResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string GenerateCertificateSigningRequestByDn(string distinguishedName)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				GenerateCertificateSigningRequestByDnRequestType generateCertificateSigningRequestByDnRequestType = new GenerateCertificateSigningRequestByDnRequestType();
				generateCertificateSigningRequestByDnRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateCertificateSigningRequestByDnRequestType.distinguishedName = distinguishedName;
				returnval = this.VimServiceProxy.GenerateCertificateSigningRequestByDn(new GenerateCertificateSigningRequestByDnRequest(generateCertificateSigningRequestByDnRequestType)).GenerateCertificateSigningRequestByDnResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void InstallServerCertificate(string cert)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				InstallServerCertificateRequestType installServerCertificateRequestType = new InstallServerCertificateRequestType();
				installServerCertificateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				installServerCertificateRequestType.cert = cert;
				this.VimServiceProxy.InstallServerCertificate(new InstallServerCertificateRequest(installServerCertificateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReplaceCACertificatesAndCRLs(string[] caCert, string[] caCrl)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ReplaceCACertificatesAndCRLsRequestType replaceCACertificatesAndCRLsRequestType = new ReplaceCACertificatesAndCRLsRequestType();
				replaceCACertificatesAndCRLsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				replaceCACertificatesAndCRLsRequestType.caCert = caCert;
				replaceCACertificatesAndCRLsRequestType.caCrl = caCrl;
				this.VimServiceProxy.ReplaceCACertificatesAndCRLs(new ReplaceCACertificatesAndCRLsRequest(replaceCACertificatesAndCRLsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] ListCACertificates()
		{
			string[] listCACertificatesResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListCACertificatesRequestType listCACertificatesRequestType = new ListCACertificatesRequestType();
				listCACertificatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listCACertificatesResponse = this.VimServiceProxy.ListCACertificates(new ListCACertificatesRequest(listCACertificatesRequestType)).ListCACertificatesResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return listCACertificatesResponse;
		}
		public string[] ListCACertificateRevocationLists()
		{
			string[] listCACertificateRevocationListsResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListCACertificateRevocationListsRequestType listCACertificateRevocationListsRequestType = new ListCACertificateRevocationListsRequestType();
				listCACertificateRevocationListsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listCACertificateRevocationListsResponse = this.VimServiceProxy.ListCACertificateRevocationLists(new ListCACertificateRevocationListsRequest(listCACertificateRevocationListsRequestType)).ListCACertificateRevocationListsResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return listCACertificateRevocationListsResponse;
		}
	}
}


using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManagerKmip : CryptoManager
	{
		protected KmipClusterInfo[] _kmipServers;
		public KmipClusterInfo[] KmipServers
		{
			get
			{
				return this._kmipServers;
			}
		}
		public CryptoManagerKmip(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RegisterKmipServer(KmipServerSpec server)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RegisterKmipServerRequestType registerKmipServerRequestType = new RegisterKmipServerRequestType();
				registerKmipServerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerKmipServerRequestType.server = (VimApi_65.KmipServerSpec)VIConvert.ToWsdlType(server);
				this.VimServiceProxy.RegisterKmipServer(new RegisterKmipServerRequest(registerKmipServerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MarkDefault(KeyProviderId clusterId)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65); 
				MarkDefaultRequestType markDefaultRequestType = new MarkDefaultRequestType();
				markDefaultRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markDefaultRequestType.clusterId = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(clusterId);
				this.VimServiceProxy.MarkDefault(new MarkDefaultRequest(markDefaultRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateKmipServer(KmipServerSpec server)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                UpdateKmipServerRequestType updateKmipServerRequestType = new UpdateKmipServerRequestType();
				updateKmipServerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateKmipServerRequestType.server = (VimApi_65.KmipServerSpec)VIConvert.ToWsdlType(server);
				this.VimServiceProxy.UpdateKmipServer(new UpdateKmipServerRequest(updateKmipServerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveKmipServer(KeyProviderId clusterId, string serverName)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RemoveKmipServerRequestType removeKmipServerRequestType = new RemoveKmipServerRequestType();
				removeKmipServerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeKmipServerRequestType.clusterId = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(clusterId);
				removeKmipServerRequestType.serverName = serverName;
				this.VimServiceProxy.RemoveKmipServer(new RemoveKmipServerRequest(removeKmipServerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public KmipClusterInfo[] ListKmipServers(int? limit)
		{
			KmipClusterInfo[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                ListKmipServersRequestType listKmipServersRequestType = new ListKmipServersRequestType();
				listKmipServersRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listKmipServersRequestType.limit = limit.GetValueOrDefault();
				listKmipServersRequestType.limitSpecified = limit.HasValue;
				result = (KmipClusterInfo[])VIConvert.ToVim(this.VimServiceProxy.ListKmipServers(new ListKmipServersRequest(listKmipServersRequestType)).ListKmipServersResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RetrieveKmipServersStatus_Task(KmipClusterInfo[] clusters)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveKmipServersStatusRequestType retrieveKmipServersStatusRequestType = new RetrieveKmipServersStatusRequestType();
				retrieveKmipServersStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveKmipServersStatusRequestType.clusters = (VimApi_65.KmipClusterInfo[])VIConvert.ToWsdlType(clusters);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RetrieveKmipServersStatus_Task(new RetrieveKmipServersStatus_TaskRequest(retrieveKmipServersStatusRequestType)).RetrieveKmipServersStatus_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CryptoManagerKmipClusterStatus[] RetrieveKmipServersStatus(KmipClusterInfo[] clusters)
		{
			CryptoManagerKmipClusterStatus[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                ManagedObjectReference taskReference = this.RetrieveKmipServersStatus_Task(clusters);
				result = (CryptoManagerKmipClusterStatus[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CryptoKeyResult GenerateKey(KeyProviderId keyProvider)
		{
			CryptoKeyResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                GenerateKeyRequestType generateKeyRequestType = new GenerateKeyRequestType();
				generateKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateKeyRequestType.keyProvider = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(keyProvider);
				result = (CryptoKeyResult)VIConvert.ToVim(this.VimServiceProxy.GenerateKey(new GenerateKeyRequest(generateKeyRequestType)).GenerateKeyResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CryptoManagerKmipServerCertInfo RetrieveKmipServerCert(KeyProviderId keyProvider, KmipServerInfo server)
		{
			CryptoManagerKmipServerCertInfo result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RetrieveKmipServerCertRequestType retrieveKmipServerCertRequestType = new RetrieveKmipServerCertRequestType();
				retrieveKmipServerCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveKmipServerCertRequestType.keyProvider = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(keyProvider);
				retrieveKmipServerCertRequestType.server = (VimApi_65.KmipServerInfo)VIConvert.ToWsdlType(server);
				result = (CryptoManagerKmipServerCertInfo)VIConvert.ToVim(this.VimServiceProxy.RetrieveKmipServerCert(new RetrieveKmipServerCertRequest(retrieveKmipServerCertRequestType)).RetrieveKmipServerCertResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UploadKmipServerCert(KeyProviderId cluster, string certificate)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                UploadKmipServerCertRequestType uploadKmipServerCertRequestType = new UploadKmipServerCertRequestType();
				uploadKmipServerCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				uploadKmipServerCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				uploadKmipServerCertRequestType.certificate = certificate;
				this.VimServiceProxy.UploadKmipServerCert(new UploadKmipServerCertRequest(uploadKmipServerCertRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string GenerateSelfSignedClientCert(KeyProviderId cluster)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                GenerateSelfSignedClientCertRequestType generateSelfSignedClientCertRequestType = new GenerateSelfSignedClientCertRequestType();
				generateSelfSignedClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateSelfSignedClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				returnval = this.VimServiceProxy.GenerateSelfSignedClientCert(new GenerateSelfSignedClientCertRequest(generateSelfSignedClientCertRequestType)).GenerateSelfSignedClientCertResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string GenerateClientCsr(KeyProviderId cluster)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                GenerateClientCsrRequestType generateClientCsrRequestType = new GenerateClientCsrRequestType();
				generateClientCsrRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateClientCsrRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				returnval = this.VimServiceProxy.GenerateClientCsr(new GenerateClientCsrRequest(generateClientCsrRequestType)).GenerateClientCsrResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string RetrieveSelfSignedClientCert(KeyProviderId cluster)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RetrieveSelfSignedClientCertRequestType retrieveSelfSignedClientCertRequestType = new RetrieveSelfSignedClientCertRequestType();
				retrieveSelfSignedClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveSelfSignedClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				returnval = this.VimServiceProxy.RetrieveSelfSignedClientCert(new RetrieveSelfSignedClientCertRequest(retrieveSelfSignedClientCertRequestType)).RetrieveSelfSignedClientCertResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string RetrieveClientCsr(KeyProviderId cluster)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RetrieveClientCsrRequestType retrieveClientCsrRequestType = new RetrieveClientCsrRequestType();
				retrieveClientCsrRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveClientCsrRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				returnval = this.VimServiceProxy.RetrieveClientCsr(new RetrieveClientCsrRequest(retrieveClientCsrRequestType)).RetrieveClientCsrResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string RetrieveClientCert(KeyProviderId cluster)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RetrieveClientCertRequestType retrieveClientCertRequestType = new RetrieveClientCertRequestType();
				retrieveClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				returnval = this.VimServiceProxy.RetrieveClientCert(new RetrieveClientCertRequest(retrieveClientCertRequestType)).RetrieveClientCertResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void UpdateSelfSignedClientCert(KeyProviderId cluster, string certificate)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                UpdateSelfSignedClientCertRequestType updateSelfSignedClientCertRequestType = new UpdateSelfSignedClientCertRequestType();
				updateSelfSignedClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateSelfSignedClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				updateSelfSignedClientCertRequestType.certificate = certificate;
				this.VimServiceProxy.UpdateSelfSignedClientCert(new UpdateSelfSignedClientCertRequest(updateSelfSignedClientCertRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateKmsSignedCsrClientCert(KeyProviderId cluster, string certificate)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                UpdateKmsSignedCsrClientCertRequestType updateKmsSignedCsrClientCertRequestType = new UpdateKmsSignedCsrClientCertRequestType();
				updateKmsSignedCsrClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateKmsSignedCsrClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				updateKmsSignedCsrClientCertRequestType.certificate = certificate;
				this.VimServiceProxy.UpdateKmsSignedCsrClientCert(new UpdateKmsSignedCsrClientCertRequest(updateKmsSignedCsrClientCertRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UploadClientCert(KeyProviderId cluster, string certificate, string privateKey)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                UploadClientCertRequestType uploadClientCertRequestType = new UploadClientCertRequestType();
				uploadClientCertRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				uploadClientCertRequestType.cluster = (VimApi_65.KeyProviderId)VIConvert.ToWsdlType(cluster);
				uploadClientCertRequestType.certificate = certificate;
				uploadClientCertRequestType.privateKey = privateKey;
				this.VimServiceProxy.UploadClientCert(new UploadClientCertRequest(uploadClientCertRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

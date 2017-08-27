using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtensionManager : ViewBase
	{
		protected Extension[] _extensionList;
		public Extension[] ExtensionList
		{
			get
			{
				return this._extensionList;
			}
		}
		public ExtensionManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UnregisterExtension(string extensionKey)
		{
			try
			{
				UnregisterExtensionRequestType unregisterExtensionRequestType = new UnregisterExtensionRequestType();
				unregisterExtensionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unregisterExtensionRequestType.extensionKey = extensionKey;
				this.VimServiceProxy.UnregisterExtension(new UnregisterExtensionRequest(unregisterExtensionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public Extension FindExtension(string extensionKey)
		{
			Extension result;
			try
			{
				FindExtensionRequestType findExtensionRequestType = new FindExtensionRequestType();
				findExtensionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				findExtensionRequestType.extensionKey = extensionKey;
				result = (Extension)VIConvert.ToVim(this.VimServiceProxy.FindExtension(new FindExtensionRequest(findExtensionRequestType)).FindExtensionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RegisterExtension(Extension extension)
		{
			try
			{
				RegisterExtensionRequestType registerExtensionRequestType = new RegisterExtensionRequestType();
				registerExtensionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerExtensionRequestType.extension = (VimApi_65.Extension)VIConvert.ToWsdlType(extension);
				this.VimServiceProxy.RegisterExtension(new RegisterExtensionRequest(registerExtensionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateExtension(Extension extension)
		{
			try
			{
				UpdateExtensionRequestType updateExtensionRequestType = new UpdateExtensionRequestType();
				updateExtensionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateExtensionRequestType.extension = (VimApi_65.Extension)VIConvert.ToWsdlType(extension);
				this.VimServiceProxy.UpdateExtension(new UpdateExtensionRequest(updateExtensionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string GetPublicKey()
		{
			string returnval;
			try
			{
				GetPublicKeyRequestType getPublicKeyRequestType = new GetPublicKeyRequestType();
				getPublicKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.GetPublicKey(new GetPublicKeyRequest(getPublicKeyRequestType)).GetPublicKeyResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void SetPublicKey(string extensionKey, string publicKey)
		{
			try
			{
				SetPublicKeyRequestType setPublicKeyRequestType = new SetPublicKeyRequestType();
				setPublicKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setPublicKeyRequestType.extensionKey = extensionKey;
				setPublicKeyRequestType.publicKey = publicKey;
				this.VimServiceProxy.SetPublicKey(new SetPublicKeyRequest(setPublicKeyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetExtensionCertificate(string extensionKey, string certificatePem)
		{
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				SetExtensionCertificateRequestType setExtensionCertificateRequestType = new SetExtensionCertificateRequestType();
				setExtensionCertificateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setExtensionCertificateRequestType.extensionKey = extensionKey;
				setExtensionCertificateRequestType.certificatePem = certificatePem;
				this.VimServiceProxy.SetExtensionCertificate(new SetExtensionCertificateRequest(setExtensionCertificateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference[] QueryManagedBy(string extensionKey)
		{
			ManagedObjectReference[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryManagedByRequestType queryManagedByRequestType = new QueryManagedByRequestType();
				queryManagedByRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryManagedByRequestType.extensionKey = extensionKey;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryManagedBy(new QueryManagedByRequest(queryManagedByRequestType)).QueryManagedByResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ExtensionManagerIpAllocationUsage[] QueryExtensionIpAllocationUsage(string[] extensionKeys)
		{
			ExtensionManagerIpAllocationUsage[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryExtensionIpAllocationUsageRequestType queryExtensionIpAllocationUsageRequestType = new QueryExtensionIpAllocationUsageRequestType();
				queryExtensionIpAllocationUsageRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryExtensionIpAllocationUsageRequestType.extensionKeys = extensionKeys;
				result = (ExtensionManagerIpAllocationUsage[])VIConvert.ToVim(this.VimServiceProxy.QueryExtensionIpAllocationUsage(new QueryExtensionIpAllocationUsageRequest(queryExtensionIpAllocationUsageRequestType)).QueryExtensionIpAllocationUsageResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

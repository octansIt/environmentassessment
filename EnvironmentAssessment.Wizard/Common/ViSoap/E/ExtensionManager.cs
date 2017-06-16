using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ExtensionManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UnregisterExtension(string extensionKey)
		{
			try
			{
				((VimService)this.Client.VimService).UnregisterExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public Extension FindExtension(string extensionKey)
		{
			Extension result;
			try
			{
				result = (Extension)VIConvert.ToVim(((VimService)this.Client.VimService).FindExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RegisterExtension(Extension extension)
		{
			try
			{
				((VimService)this.Client.VimService).RegisterExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.Extension)VIConvert.ToWsdlType(extension));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateExtension(Extension extension)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateExtension((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.Extension)VIConvert.ToWsdlType(extension));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string GetPublicKey()
		{
			string publicKey;
			try
			{
				publicKey = ((VimService)this.Client.VimService).GetPublicKey((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return publicKey;
		}
		public void SetPublicKey(string extensionKey, string publicKey)
		{
			try
			{
				((VimService)this.Client.VimService).SetPublicKey((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, publicKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetExtensionCertificate(string extensionKey, string certificatePem)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).SetExtensionCertificate((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey, certificatePem);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference[] QueryManagedBy(string extensionKey)
		{
			ManagedObjectReference[] result;
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
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryManagedBy((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKey));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ExtensionManagerIpAllocationUsage[] QueryExtensionIpAllocationUsage(string[] extensionKeys)
		{
			ExtensionManagerIpAllocationUsage[] result;
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
				result = (ExtensionManagerIpAllocationUsage[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryExtensionIpAllocationUsage((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), extensionKeys));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

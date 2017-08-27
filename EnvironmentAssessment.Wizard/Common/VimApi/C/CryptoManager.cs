
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManager : ViewBase
	{
		protected bool _enabled;
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
		}
		public CryptoManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void AddKey(CryptoKeyPlain key)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				AddKeyRequestType addKeyRequestType = new AddKeyRequestType();
				addKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addKeyRequestType.key = (VimApi_65.CryptoKeyPlain)VIConvert.ToWsdlType(key);
				this.VimServiceProxy.AddKey(new AddKeyRequest(addKeyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public CryptoKeyResult[] AddKeys(CryptoKeyPlain[] keys)
		{
			CryptoKeyResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                AddKeysRequestType addKeysRequestType = new AddKeysRequestType();
				addKeysRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addKeysRequestType.keys = (VimApi_65.CryptoKeyPlain[])VIConvert.ToWsdlType(keys);
				result = (CryptoKeyResult[])VIConvert.ToVim(this.VimServiceProxy.AddKeys(new AddKeysRequest(addKeysRequestType)).AddKeysResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveKey(CryptoKeyId key, bool force)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RemoveKeyRequestType removeKeyRequestType = new RemoveKeyRequestType();
				removeKeyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeKeyRequestType.key = (VimApi_65.CryptoKeyId)VIConvert.ToWsdlType(key);
				removeKeyRequestType.force = force;
				this.VimServiceProxy.RemoveKey(new RemoveKeyRequest(removeKeyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public CryptoKeyResult[] RemoveKeys(CryptoKeyId[] keys, bool force)
		{
			CryptoKeyResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                RemoveKeysRequestType removeKeysRequestType = new RemoveKeysRequestType();
				removeKeysRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeKeysRequestType.keys = (VimApi_65.CryptoKeyId[])VIConvert.ToWsdlType(keys);
				removeKeysRequestType.force = force;
				result = (CryptoKeyResult[])VIConvert.ToVim(this.VimServiceProxy.RemoveKeys(new RemoveKeysRequest(removeKeysRequestType)).RemoveKeysResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public CryptoKeyId[] ListKeys(int? limit)
		{
			CryptoKeyId[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
                ListKeysRequestType listKeysRequestType = new ListKeysRequestType();
				listKeysRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listKeysRequestType.limit = limit.GetValueOrDefault();
				listKeysRequestType.limitSpecified = limit.HasValue;
				result = (CryptoKeyId[])VIConvert.ToVim(this.VimServiceProxy.ListKeys(new ListKeysRequest(listKeysRequestType)).ListKeysResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

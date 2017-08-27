using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestWindowsRegistryManager : ViewBase
	{
		public GuestWindowsRegistryManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void CreateRegistryKeyInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegKeyNameSpec keyName, bool isVolatile, string classType)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				CreateRegistryKeyInGuestRequestType createRegistryKeyInGuestRequestType = new CreateRegistryKeyInGuestRequestType();
				createRegistryKeyInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createRegistryKeyInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				createRegistryKeyInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				createRegistryKeyInGuestRequestType.keyName = (VimApi_65.GuestRegKeyNameSpec)VIConvert.ToWsdlType(keyName);
				createRegistryKeyInGuestRequestType.isVolatile = isVolatile;
				createRegistryKeyInGuestRequestType.classType = classType;
				this.VimServiceProxy.CreateRegistryKeyInGuest(new CreateRegistryKeyInGuestRequest(createRegistryKeyInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public GuestRegKeyRecordSpec[] ListRegistryKeysInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegKeyNameSpec keyName, bool recursive, string matchPattern)
		{
			GuestRegKeyRecordSpec[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListRegistryKeysInGuestRequestType listRegistryKeysInGuestRequestType = new ListRegistryKeysInGuestRequestType();
				listRegistryKeysInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listRegistryKeysInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listRegistryKeysInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				listRegistryKeysInGuestRequestType.keyName = (VimApi_65.GuestRegKeyNameSpec)VIConvert.ToWsdlType(keyName);
				listRegistryKeysInGuestRequestType.recursive = recursive;
				listRegistryKeysInGuestRequestType.matchPattern = matchPattern;
				result = (GuestRegKeyRecordSpec[])VIConvert.ToVim(this.VimServiceProxy.ListRegistryKeysInGuest(new ListRegistryKeysInGuestRequest(listRegistryKeysInGuestRequestType)).ListRegistryKeysInGuestResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteRegistryKeyInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegKeyNameSpec keyName, bool recursive)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DeleteRegistryKeyInGuestRequestType deleteRegistryKeyInGuestRequestType = new DeleteRegistryKeyInGuestRequestType();
				deleteRegistryKeyInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteRegistryKeyInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				deleteRegistryKeyInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				deleteRegistryKeyInGuestRequestType.keyName = (VimApi_65.GuestRegKeyNameSpec)VIConvert.ToWsdlType(keyName);
				deleteRegistryKeyInGuestRequestType.recursive = recursive;
				this.VimServiceProxy.DeleteRegistryKeyInGuest(new DeleteRegistryKeyInGuestRequest(deleteRegistryKeyInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SetRegistryValueInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegValueSpec value)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				SetRegistryValueInGuestRequestType setRegistryValueInGuestRequestType = new SetRegistryValueInGuestRequestType();
				setRegistryValueInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setRegistryValueInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				setRegistryValueInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				setRegistryValueInGuestRequestType.value = (VimApi_65.GuestRegValueSpec)VIConvert.ToWsdlType(value);
				this.VimServiceProxy.SetRegistryValueInGuest(new SetRegistryValueInGuestRequest(setRegistryValueInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public GuestRegValueSpec[] ListRegistryValuesInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegKeyNameSpec keyName, bool expandStrings, string matchPattern)
		{
			GuestRegValueSpec[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				ListRegistryValuesInGuestRequestType listRegistryValuesInGuestRequestType = new ListRegistryValuesInGuestRequestType();
				listRegistryValuesInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				listRegistryValuesInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				listRegistryValuesInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				listRegistryValuesInGuestRequestType.keyName = (VimApi_65.GuestRegKeyNameSpec)VIConvert.ToWsdlType(keyName);
				listRegistryValuesInGuestRequestType.expandStrings = expandStrings;
				listRegistryValuesInGuestRequestType.matchPattern = matchPattern;
				result = (GuestRegValueSpec[])VIConvert.ToVim(this.VimServiceProxy.ListRegistryValuesInGuest(new ListRegistryValuesInGuestRequest(listRegistryValuesInGuestRequestType)).ListRegistryValuesInGuestResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DeleteRegistryValueInGuest(ManagedObjectReference vm, GuestAuthentication auth, GuestRegValueNameSpec valueName)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim60);
				DeleteRegistryValueInGuestRequestType deleteRegistryValueInGuestRequestType = new DeleteRegistryValueInGuestRequestType();
				deleteRegistryValueInGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deleteRegistryValueInGuestRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				deleteRegistryValueInGuestRequestType.auth = (VimApi_65.GuestAuthentication)VIConvert.ToWsdlType(auth);
				deleteRegistryValueInGuestRequestType.valueName = (VimApi_65.GuestRegValueNameSpec)VIConvert.ToWsdlType(valueName);
				this.VimServiceProxy.DeleteRegistryValueInGuest(new DeleteRegistryValueInGuestRequest(deleteRegistryValueInGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

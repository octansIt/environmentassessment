using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseManager : ViewBase
	{
		protected LicenseSource _source;
		protected bool _sourceAvailable;
		protected LicenseDiagnostics _diagnostics;
		protected LicenseFeatureInfo[] _featureInfo;
		protected string _licensedEdition;
		protected LicenseManagerLicenseInfo[] _licenses;
		protected ManagedObjectReference _licenseAssignmentManager;
		protected LicenseManagerEvaluationInfo _evaluation;
		protected LicenseManager_LinkedView _linkedView;
		public LicenseSource Source
		{
			get
			{
				return this._source;
			}
		}
		public bool SourceAvailable
		{
			get
			{
				return this._sourceAvailable;
			}
		}
		public LicenseDiagnostics Diagnostics
		{
			get
			{
				return this._diagnostics;
			}
		}
		public LicenseFeatureInfo[] FeatureInfo
		{
			get
			{
				return this._featureInfo;
			}
		}
		public string LicensedEdition
		{
			get
			{
				return this._licensedEdition;
			}
		}
		public LicenseManagerLicenseInfo[] Licenses
		{
			get
			{
				return this._licenses;
			}
		}
		public ManagedObjectReference LicenseAssignmentManager
		{
			get
			{
				return this._licenseAssignmentManager;
			}
		}
		public LicenseManagerEvaluationInfo Evaluation
		{
			get
			{
				return this._evaluation;
			}
		}
		public LicenseManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public LicenseManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public LicenseFeatureInfo[] QuerySupportedFeatures(ManagedObjectReference host)
		{
			LicenseFeatureInfo[] result;
			try
			{
				QuerySupportedFeaturesRequestType querySupportedFeaturesRequestType = new QuerySupportedFeaturesRequestType();
				querySupportedFeaturesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				querySupportedFeaturesRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (LicenseFeatureInfo[])VIConvert.ToVim(this.VimServiceProxy.QuerySupportedFeatures(new QuerySupportedFeaturesRequest(querySupportedFeaturesRequestType)).QuerySupportedFeaturesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public LicenseAvailabilityInfo[] QueryLicenseSourceAvailability(ManagedObjectReference host)
		{
			LicenseAvailabilityInfo[] result;
			try
			{
				QueryLicenseSourceAvailabilityRequestType queryLicenseSourceAvailabilityRequestType = new QueryLicenseSourceAvailabilityRequestType();
				queryLicenseSourceAvailabilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryLicenseSourceAvailabilityRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (LicenseAvailabilityInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryLicenseSourceAvailability(new QueryLicenseSourceAvailabilityRequest(queryLicenseSourceAvailabilityRequestType)).QueryLicenseSourceAvailabilityResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public LicenseUsageInfo QueryLicenseUsage(ManagedObjectReference host)
		{
			LicenseUsageInfo result;
			try
			{
				QueryLicenseUsageRequestType queryLicenseUsageRequestType = new QueryLicenseUsageRequestType();
				queryLicenseUsageRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryLicenseUsageRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (LicenseUsageInfo)VIConvert.ToVim(this.VimServiceProxy.QueryLicenseUsage(new QueryLicenseUsageRequest(queryLicenseUsageRequestType)).QueryLicenseUsageResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SetLicenseEdition(ManagedObjectReference host, string featureKey)
		{
			try
			{
				SetLicenseEditionRequestType setLicenseEditionRequestType = new SetLicenseEditionRequestType();
				setLicenseEditionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setLicenseEditionRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				setLicenseEditionRequestType.featureKey = featureKey;
				this.VimServiceProxy.SetLicenseEdition(new SetLicenseEditionRequest(setLicenseEditionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public bool CheckLicenseFeature(ManagedObjectReference host, string featureKey)
		{
			bool returnval;
			try
			{
				CheckLicenseFeatureRequestType checkLicenseFeatureRequestType = new CheckLicenseFeatureRequestType();
				checkLicenseFeatureRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkLicenseFeatureRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				checkLicenseFeatureRequestType.featureKey = featureKey;
				returnval = this.VimServiceProxy.CheckLicenseFeature(new CheckLicenseFeatureRequest(checkLicenseFeatureRequestType)).CheckLicenseFeatureResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public bool EnableFeature(ManagedObjectReference host, string featureKey)
		{
			bool returnval;
			try
			{
				EnableFeatureRequestType enableFeatureRequestType = new EnableFeatureRequestType();
				enableFeatureRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableFeatureRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				enableFeatureRequestType.featureKey = featureKey;
				returnval = this.VimServiceProxy.EnableFeature(new EnableFeatureRequest(enableFeatureRequestType)).EnableFeatureResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public bool DisableFeature(ManagedObjectReference host, string featureKey)
		{
			bool returnval;
			try
			{
				DisableFeatureRequestType disableFeatureRequestType = new DisableFeatureRequestType();
				disableFeatureRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				disableFeatureRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				disableFeatureRequestType.featureKey = featureKey;
				returnval = this.VimServiceProxy.DisableFeature(new DisableFeatureRequest(disableFeatureRequestType)).DisableFeatureResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void ConfigureLicenseSource(ManagedObjectReference host, LicenseSource licenseSource)
		{
			try
			{
				ConfigureLicenseSourceRequestType configureLicenseSourceRequestType = new ConfigureLicenseSourceRequestType();
				configureLicenseSourceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureLicenseSourceRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				configureLicenseSourceRequestType.licenseSource = (VimApi_65.LicenseSource)VIConvert.ToWsdlType(licenseSource);
				this.VimServiceProxy.ConfigureLicenseSource(new ConfigureLicenseSourceRequest(configureLicenseSourceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public LicenseManagerLicenseInfo UpdateLicense(string licenseKey, KeyValue[] labels)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateLicenseRequestType updateLicenseRequestType = new UpdateLicenseRequestType();
				updateLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateLicenseRequestType.licenseKey = licenseKey;
				updateLicenseRequestType.labels = (VimApi_65.KeyValue[])VIConvert.ToWsdlType(labels);
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(this.VimServiceProxy.UpdateLicense(new UpdateLicenseRequest(updateLicenseRequestType)).UpdateLicenseResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public LicenseManagerLicenseInfo AddLicense(string licenseKey, KeyValue[] labels)
		{
			LicenseManagerLicenseInfo result;
			try
			{	
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				AddLicenseRequestType addLicenseRequestType = new AddLicenseRequestType();
				addLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addLicenseRequestType.licenseKey = licenseKey;
				addLicenseRequestType.labels = (VimApi_65.KeyValue[])VIConvert.ToWsdlType(labels);
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(this.VimServiceProxy.AddLicense(new AddLicenseRequest(addLicenseRequestType)).AddLicenseResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveLicense(string licenseKey)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RemoveLicenseRequestType removeLicenseRequestType = new RemoveLicenseRequestType();
				removeLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeLicenseRequestType.licenseKey = licenseKey;
				this.VimServiceProxy.RemoveLicense(new RemoveLicenseRequest(removeLicenseRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public LicenseManagerLicenseInfo DecodeLicense(string licenseKey)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				DecodeLicenseRequestType decodeLicenseRequestType = new DecodeLicenseRequestType();
				decodeLicenseRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				decodeLicenseRequestType.licenseKey = licenseKey;
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(this.VimServiceProxy.DecodeLicense(new DecodeLicenseRequest(decodeLicenseRequestType)).DecodeLicenseResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateLicenseLabel(string licenseKey, string labelKey, string labelValue)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateLicenseLabelRequestType updateLicenseLabelRequestType = new UpdateLicenseLabelRequestType();
				updateLicenseLabelRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateLicenseLabelRequestType.licenseKey = licenseKey;
				updateLicenseLabelRequestType.labelKey = labelKey;
				updateLicenseLabelRequestType.labelValue = labelValue;
				this.VimServiceProxy.UpdateLicenseLabel(new UpdateLicenseLabelRequest(updateLicenseLabelRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveLicenseLabel(string licenseKey, string labelKey)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				RemoveLicenseLabelRequestType removeLicenseLabelRequestType = new RemoveLicenseLabelRequestType();
				removeLicenseLabelRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeLicenseLabelRequestType.licenseKey = licenseKey;
				removeLicenseLabelRequestType.labelKey = labelKey;
				this.VimServiceProxy.RemoveLicenseLabel(new RemoveLicenseLabelRequest(removeLicenseLabelRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

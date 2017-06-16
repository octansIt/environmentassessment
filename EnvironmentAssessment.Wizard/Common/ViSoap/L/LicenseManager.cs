using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				result = (LicenseFeatureInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QuerySupportedFeatures((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public LicenseAvailabilityInfo[] QueryLicenseSourceAvailability(ManagedObjectReference host)
		{
			LicenseAvailabilityInfo[] result;
			try
			{
				result = (LicenseAvailabilityInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryLicenseSourceAvailability((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public LicenseUsageInfo QueryLicenseUsage(ManagedObjectReference host)
		{
			LicenseUsageInfo result;
			try
			{
				result = (LicenseUsageInfo)VIConvert.ToVim(((VimService)this.Client.VimService).QueryLicenseUsage((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void SetLicenseEdition(ManagedObjectReference host, string featureKey)
		{
			try
			{
				((VimService)this.Client.VimService).SetLicenseEdition((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), featureKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public bool CheckLicenseFeature(ManagedObjectReference host, string featureKey)
		{
			bool result;
			try
			{
				result = ((VimService)this.Client.VimService).CheckLicenseFeature((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), featureKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public bool EnableFeature(ManagedObjectReference host, string featureKey)
		{
			bool result;
			try
			{
				result = ((VimService)this.Client.VimService).EnableFeature((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), featureKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public bool DisableFeature(ManagedObjectReference host, string featureKey)
		{
			bool result;
			try
			{
				result = ((VimService)this.Client.VimService).DisableFeature((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), featureKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ConfigureLicenseSource(ManagedObjectReference host, LicenseSource licenseSource)
		{
			try
			{
				((VimService)this.Client.VimService).ConfigureLicenseSource((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.LicenseSource)VIConvert.ToWsdlType(licenseSource));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public LicenseManagerLicenseInfo UpdateLicense(string licenseKey, KeyValue[] labels)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey, (VimApi_60.KeyValue[])VIConvert.ToWsdlType(labels)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public LicenseManagerLicenseInfo AddLicense(string licenseKey, KeyValue[] labels)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(((VimService)this.Client.VimService).AddLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey, (VimApi_60.KeyValue[])VIConvert.ToWsdlType(labels)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RemoveLicense(string licenseKey)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RemoveLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public LicenseManagerLicenseInfo DecodeLicense(string licenseKey)
		{
			LicenseManagerLicenseInfo result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (LicenseManagerLicenseInfo)VIConvert.ToVim(((VimService)this.Client.VimService).DecodeLicense((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateLicenseLabel(string licenseKey, string labelKey, string labelValue)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateLicenseLabel((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey, labelKey, labelValue);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemoveLicenseLabel(string licenseKey, string labelKey)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RemoveLicenseLabel((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), licenseKey, labelKey);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class Profile : ViewBase
	{
		protected ProfileConfigInfo _config;
		protected ProfileDescription _description;
		protected string _name;
		protected DateTime _createdTime;
		protected DateTime _modifiedTime;
		protected ManagedObjectReference[] _entity;
		protected string _complianceStatus;
		protected Profile_LinkedView _linkedView;
		public ProfileConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public ProfileDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
		}
		public DateTime CreatedTime
		{
			get
			{
				return this._createdTime;
			}
		}
		public DateTime ModifiedTime
		{
			get
			{
				return this._modifiedTime;
			}
		}
		public ManagedObjectReference[] Entity
		{
			get
			{
				return this._entity;
			}
		}
		public string ComplianceStatus
		{
			get
			{
				return this._complianceStatus;
			}
		}
		public Profile_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public Profile(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ProfileDescription RetrieveDescription()
		{
			ProfileDescription result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RetrieveDescriptionRequestType retrieveDescriptionRequestType = new RetrieveDescriptionRequestType();
				retrieveDescriptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ProfileDescription)VIConvert.ToVim(this.VimServiceProxy.RetrieveDescription(new RetrieveDescriptionRequest(retrieveDescriptionRequestType)).RetrieveDescriptionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DestroyProfile()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				DestroyProfileRequestType destroyProfileRequestType = new DestroyProfileRequestType();
				destroyProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyProfile(new DestroyProfileRequest(destroyProfileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AssociateProfile(ManagedObjectReference[] entity)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				AssociateProfileRequestType associateProfileRequestType = new AssociateProfileRequestType();
				associateProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				associateProfileRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				this.VimServiceProxy.AssociateProfile(new AssociateProfileRequest(associateProfileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DissociateProfile(ManagedObjectReference[] entity)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				DissociateProfileRequestType dissociateProfileRequestType = new DissociateProfileRequestType();
				dissociateProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				dissociateProfileRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				this.VimServiceProxy.DissociateProfile(new DissociateProfileRequest(dissociateProfileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CheckProfileCompliance_Task(ManagedObjectReference[] entity)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CheckProfileComplianceRequestType checkProfileComplianceRequestType = new CheckProfileComplianceRequestType();
				checkProfileComplianceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkProfileComplianceRequestType.entity = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckProfileCompliance_Task(new CheckProfileCompliance_TaskRequest(checkProfileComplianceRequestType)).CheckProfileCompliance_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ComplianceResult[] CheckProfileCompliance(ManagedObjectReference[] entity)
		{
			ComplianceResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CheckProfileCompliance_Task(entity);
				result = (ComplianceResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string ExportProfile()
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ExportProfileRequestType exportProfileRequestType = new ExportProfileRequestType();
				exportProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.ExportProfile(new ExportProfileRequest(exportProfileRequestType)).ExportProfileResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}

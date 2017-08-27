using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileManager : ProfileManager
	{
		public new HostProfileManager_LinkedView LinkedView
		{
			get
			{
				return (HostProfileManager_LinkedView)this._linkedView;
			}
		}
		public HostProfileManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ApplyHostConfig_Task(ManagedObjectReference host, HostConfigSpec configSpec, ProfileDeferredPolicyOptionParameter[] userInput)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ApplyHostConfigRequestType applyHostConfigRequestType = new ApplyHostConfigRequestType();
				applyHostConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				applyHostConfigRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				applyHostConfigRequestType.configSpec = (VimApi_65.HostConfigSpec)VIConvert.ToWsdlType(configSpec);
				applyHostConfigRequestType.userInput = (VimApi_65.ProfileDeferredPolicyOptionParameter[])VIConvert.ToWsdlType(userInput);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ApplyHostConfig_Task(new ApplyHostConfig_TaskRequest(applyHostConfigRequestType)).ApplyHostConfig_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ApplyHostConfig(ManagedObjectReference host, HostConfigSpec configSpec, ProfileDeferredPolicyOptionParameter[] userInput)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.ApplyHostConfig_Task(host, configSpec, userInput);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostProfileManagerConfigTaskList GenerateConfigTaskList(HostConfigSpec configSpec, ManagedObjectReference host)
		{
			HostProfileManagerConfigTaskList result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				GenerateConfigTaskListRequestType generateConfigTaskListRequestType = new GenerateConfigTaskListRequestType();
				generateConfigTaskListRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateConfigTaskListRequestType.configSpec = (VimApi_65.HostConfigSpec)VIConvert.ToWsdlType(configSpec);
				generateConfigTaskListRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (HostProfileManagerConfigTaskList)VIConvert.ToVim(this.VimServiceProxy.GenerateConfigTaskList(new GenerateConfigTaskListRequest(generateConfigTaskListRequestType)).GenerateConfigTaskListResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference GenerateHostProfileTaskList_Task(HostConfigSpec configSpec, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				GenerateHostProfileTaskListRequestType generateHostProfileTaskListRequestType = new GenerateHostProfileTaskListRequestType();
				generateHostProfileTaskListRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateHostProfileTaskListRequestType.configSpec = (VimApi_65.HostConfigSpec)VIConvert.ToWsdlType(configSpec);
				generateHostProfileTaskListRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.GenerateHostProfileTaskList_Task(new GenerateHostProfileTaskList_TaskRequest(generateHostProfileTaskListRequestType)).GenerateHostProfileTaskList_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostProfileManagerConfigTaskList GenerateHostProfileTaskList(HostConfigSpec configSpec, ManagedObjectReference host)
		{
			HostProfileManagerConfigTaskList result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.GenerateHostProfileTaskList_Task(configSpec, host);
				result = (HostProfileManagerConfigTaskList)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ProfileMetadata[] QueryHostProfileMetadata(string[] profileName, ManagedObjectReference profile)
		{
			ProfileMetadata[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryHostProfileMetadataRequestType queryHostProfileMetadataRequestType = new QueryHostProfileMetadataRequestType();
				queryHostProfileMetadataRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryHostProfileMetadataRequestType.profileName = profileName;
				queryHostProfileMetadataRequestType.profile = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(profile);
				result = (ProfileMetadata[])VIConvert.ToVim(this.VimServiceProxy.QueryHostProfileMetadata(new QueryHostProfileMetadataRequest(queryHostProfileMetadataRequestType)).QueryHostProfileMetadataResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ProfileProfileStructure QueryProfileStructure(ManagedObjectReference profile)
		{
			ProfileProfileStructure result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryProfileStructureRequestType queryProfileStructureRequestType = new QueryProfileStructureRequestType();
				queryProfileStructureRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryProfileStructureRequestType.profile = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(profile);
				result = (ProfileProfileStructure)VIConvert.ToVim(this.VimServiceProxy.QueryProfileStructure(new QueryProfileStructureRequest(queryProfileStructureRequestType)).QueryProfileStructureResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ApplyProfile CreateDefaultProfile(string profileType, string profileTypeName, ManagedObjectReference profile)
		{
			ApplyProfile result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateDefaultProfileRequestType createDefaultProfileRequestType = new CreateDefaultProfileRequestType();
				createDefaultProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDefaultProfileRequestType.profileType = profileType;
				createDefaultProfileRequestType.profileTypeName = profileTypeName;
				createDefaultProfileRequestType.profile = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(profile);
				result = (ApplyProfile)VIConvert.ToVim(this.VimServiceProxy.CreateDefaultProfile(new CreateDefaultProfileRequest(createDefaultProfileRequestType)).CreateDefaultProfileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UpdateAnswerFile_Task(ManagedObjectReference host, AnswerFileCreateSpec configSpec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UpdateAnswerFileRequestType updateAnswerFileRequestType = new UpdateAnswerFileRequestType();
				updateAnswerFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateAnswerFileRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				updateAnswerFileRequestType.configSpec = (VimApi_65.AnswerFileCreateSpec)VIConvert.ToWsdlType(configSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateAnswerFile_Task(new UpdateAnswerFile_TaskRequest(updateAnswerFileRequestType)).UpdateAnswerFile_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpdateAnswerFile(ManagedObjectReference host, AnswerFileCreateSpec configSpec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.UpdateAnswerFile_Task(host, configSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public AnswerFile RetrieveAnswerFile(ManagedObjectReference host)
		{
			AnswerFile result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RetrieveAnswerFileRequestType retrieveAnswerFileRequestType = new RetrieveAnswerFileRequestType();
				retrieveAnswerFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveAnswerFileRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (AnswerFile)VIConvert.ToVim(this.VimServiceProxy.RetrieveAnswerFile(new RetrieveAnswerFileRequest(retrieveAnswerFileRequestType)).RetrieveAnswerFileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public AnswerFile RetrieveAnswerFileForProfile(ManagedObjectReference host, HostApplyProfile applyProfile)
		{
			AnswerFile result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				RetrieveAnswerFileForProfileRequestType retrieveAnswerFileForProfileRequestType = new RetrieveAnswerFileForProfileRequestType();
				retrieveAnswerFileForProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveAnswerFileForProfileRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				retrieveAnswerFileForProfileRequestType.applyProfile = (VimApi_65.HostApplyProfile)VIConvert.ToWsdlType(applyProfile);
				result = (AnswerFile)VIConvert.ToVim(this.VimServiceProxy.RetrieveAnswerFileForProfile(new RetrieveAnswerFileForProfileRequest(retrieveAnswerFileForProfileRequestType)).RetrieveAnswerFileForProfileResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExportAnswerFile_Task(ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ExportAnswerFileRequestType exportAnswerFileRequestType = new ExportAnswerFileRequestType();
				exportAnswerFileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				exportAnswerFileRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExportAnswerFile_Task(new ExportAnswerFile_TaskRequest(exportAnswerFileRequestType)).ExportAnswerFile_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string ExportAnswerFile(ManagedObjectReference host)
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = this.ExportAnswerFile_Task(host);
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CheckAnswerFileStatus_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				CheckAnswerFileStatusRequestType checkAnswerFileStatusRequestType = new CheckAnswerFileStatusRequestType();
				checkAnswerFileStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkAnswerFileStatusRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CheckAnswerFileStatus_Task(new CheckAnswerFileStatus_TaskRequest(checkAnswerFileStatusRequestType)).CheckAnswerFileStatus_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public AnswerFileStatusResult[] CheckAnswerFileStatus(ManagedObjectReference[] host)
		{
			AnswerFileStatusResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ManagedObjectReference taskReference = this.CheckAnswerFileStatus_Task(host);
				result = (AnswerFileStatusResult[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public AnswerFileStatusResult[] QueryAnswerFileStatus(ManagedObjectReference[] host)
		{
			AnswerFileStatusResult[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryAnswerFileStatusRequestType queryAnswerFileStatusRequestType = new QueryAnswerFileStatusRequestType();
				queryAnswerFileStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAnswerFileStatusRequestType.host = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(host);
				result = (AnswerFileStatusResult[])VIConvert.ToVim(this.VimServiceProxy.QueryAnswerFileStatus(new QueryAnswerFileStatusRequest(queryAnswerFileStatusRequestType)).QueryAnswerFileStatusResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference UpdateHostCustomizations_Task(HostProfileManagerHostToConfigSpecMap[] hostToConfigSpecMap)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UpdateHostCustomizationsRequestType updateHostCustomizationsRequestType = new UpdateHostCustomizationsRequestType();
				updateHostCustomizationsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateHostCustomizationsRequestType.hostToConfigSpecMap = (VimApi_65.HostProfileManagerHostToConfigSpecMap[])VIConvert.ToWsdlType(hostToConfigSpecMap);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpdateHostCustomizations_Task(new UpdateHostCustomizations_TaskRequest(updateHostCustomizationsRequestType)).UpdateHostCustomizations_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] UpdateHostCustomizations(HostProfileManagerHostToConfigSpecMap[] hostToConfigSpecMap)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.UpdateHostCustomizations_Task(hostToConfigSpecMap);
				result = (ManagedObjectReference[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public StructuredCustomizations[] RetrieveHostCustomizations(ManagedObjectReference[] hosts)
		{
			StructuredCustomizations[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveHostCustomizationsRequestType retrieveHostCustomizationsRequestType = new RetrieveHostCustomizationsRequestType();
				retrieveHostCustomizationsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveHostCustomizationsRequestType.hosts = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(hosts);
				result = (StructuredCustomizations[])VIConvert.ToVim(this.VimServiceProxy.RetrieveHostCustomizations(new RetrieveHostCustomizationsRequest(retrieveHostCustomizationsRequestType)).RetrieveHostCustomizationsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public StructuredCustomizations[] RetrieveHostCustomizationsForProfile(ManagedObjectReference[] hosts, HostApplyProfile applyProfile)
		{
			StructuredCustomizations[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RetrieveHostCustomizationsForProfileRequestType retrieveHostCustomizationsForProfileRequestType = new RetrieveHostCustomizationsForProfileRequestType();
				retrieveHostCustomizationsForProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				retrieveHostCustomizationsForProfileRequestType.hosts = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(hosts);
				retrieveHostCustomizationsForProfileRequestType.applyProfile = (VimApi_65.HostApplyProfile)VIConvert.ToWsdlType(applyProfile);
				result = (StructuredCustomizations[])VIConvert.ToVim(this.VimServiceProxy.RetrieveHostCustomizationsForProfile(new RetrieveHostCustomizationsForProfileRequest(retrieveHostCustomizationsForProfileRequestType)).RetrieveHostCustomizationsForProfileResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference GenerateHostConfigTaskSpec_Task(StructuredCustomizations[] hostsInfo)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				GenerateHostConfigTaskSpecRequestType generateHostConfigTaskSpecRequestType = new GenerateHostConfigTaskSpecRequestType();
				generateHostConfigTaskSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				generateHostConfigTaskSpecRequestType.hostsInfo = (VimApi_65.StructuredCustomizations[])VIConvert.ToWsdlType(hostsInfo);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.GenerateHostConfigTaskSpec_Task(new GenerateHostConfigTaskSpec_TaskRequest(generateHostConfigTaskSpecRequestType)).GenerateHostConfigTaskSpec_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ApplyHostProfileConfigurationSpec[] GenerateHostConfigTaskSpec(StructuredCustomizations[] hostsInfo)
		{
			ApplyHostProfileConfigurationSpec[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.GenerateHostConfigTaskSpec_Task(hostsInfo);
				result = (ApplyHostProfileConfigurationSpec[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ApplyEntitiesConfig_Task(ApplyHostProfileConfigurationSpec[] applyConfigSpecs)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ApplyEntitiesConfigRequestType applyEntitiesConfigRequestType = new ApplyEntitiesConfigRequestType();
				applyEntitiesConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				applyEntitiesConfigRequestType.applyConfigSpecs = (VimApi_65.ApplyHostProfileConfigurationSpec[])VIConvert.ToWsdlType(applyConfigSpecs);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ApplyEntitiesConfig_Task(new ApplyEntitiesConfig_TaskRequest(applyEntitiesConfigRequestType)).ApplyEntitiesConfig_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] ApplyEntitiesConfig(ApplyHostProfileConfigurationSpec[] applyConfigSpecs)
		{
			ManagedObjectReference[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.ApplyEntitiesConfig_Task(applyConfigSpecs);
				result = (ManagedObjectReference[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageResourceManager : ViewBase
	{
		public StorageResourceManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ConfigureDatastoreIORM_Task(ManagedObjectReference datastore, StorageIORMConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ConfigureDatastoreIORMRequestType configureDatastoreIORMRequestType = new ConfigureDatastoreIORMRequestType();
				configureDatastoreIORMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureDatastoreIORMRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				configureDatastoreIORMRequestType.spec = (VimApi_65.StorageIORMConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConfigureDatastoreIORM_Task(new ConfigureDatastoreIORM_TaskRequest(configureDatastoreIORMRequestType)).ConfigureDatastoreIORM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConfigureDatastoreIORM(ManagedObjectReference datastore, StorageIORMConfigSpec spec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ManagedObjectReference taskReference = this.ConfigureDatastoreIORM_Task(datastore, spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public StorageIORMConfigOption QueryIORMConfigOption(ManagedObjectReference host)
		{
			StorageIORMConfigOption result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				QueryIORMConfigOptionRequestType queryIORMConfigOptionRequestType = new QueryIORMConfigOptionRequestType();
				queryIORMConfigOptionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryIORMConfigOptionRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (StorageIORMConfigOption)VIConvert.ToVim(this.VimServiceProxy.QueryIORMConfigOption(new QueryIORMConfigOptionRequest(queryIORMConfigOptionRequestType)).QueryIORMConfigOptionResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public StoragePerformanceSummary[] QueryDatastorePerformanceSummary(ManagedObjectReference datastore)
		{
			StoragePerformanceSummary[] result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryDatastorePerformanceSummaryRequestType queryDatastorePerformanceSummaryRequestType = new QueryDatastorePerformanceSummaryRequestType();
				queryDatastorePerformanceSummaryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryDatastorePerformanceSummaryRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				result = (StoragePerformanceSummary[])VIConvert.ToVim(this.VimServiceProxy.QueryDatastorePerformanceSummary(new QueryDatastorePerformanceSummaryRequest(queryDatastorePerformanceSummaryRequestType)).QueryDatastorePerformanceSummaryResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ApplyStorageDrsRecommendationToPod_Task(ManagedObjectReference pod, string key)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ApplyStorageDrsRecommendationToPodRequestType applyStorageDrsRecommendationToPodRequestType = new ApplyStorageDrsRecommendationToPodRequestType();
				applyStorageDrsRecommendationToPodRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				applyStorageDrsRecommendationToPodRequestType.pod = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pod);
				applyStorageDrsRecommendationToPodRequestType.key = key;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ApplyStorageDrsRecommendationToPod_Task(new ApplyStorageDrsRecommendationToPod_TaskRequest(applyStorageDrsRecommendationToPodRequestType)).ApplyStorageDrsRecommendationToPod_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ApplyStorageRecommendationResult ApplyStorageDrsRecommendationToPod(ManagedObjectReference pod, string key)
		{
			ApplyStorageRecommendationResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.ApplyStorageDrsRecommendationToPod_Task(pod, key);
				result = (ApplyStorageRecommendationResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ApplyStorageDrsRecommendation_Task(string[] key)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ApplyStorageDrsRecommendationRequestType applyStorageDrsRecommendationRequestType = new ApplyStorageDrsRecommendationRequestType();
				applyStorageDrsRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				applyStorageDrsRecommendationRequestType.key = key;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ApplyStorageDrsRecommendation_Task(new ApplyStorageDrsRecommendation_TaskRequest(applyStorageDrsRecommendationRequestType)).ApplyStorageDrsRecommendation_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ApplyStorageRecommendationResult ApplyStorageDrsRecommendation(string[] key)
		{
			ApplyStorageRecommendationResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.ApplyStorageDrsRecommendation_Task(key);
				result = (ApplyStorageRecommendationResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CancelStorageDrsRecommendation(string[] key)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				CancelStorageDrsRecommendationRequestType cancelStorageDrsRecommendationRequestType = new CancelStorageDrsRecommendationRequestType();
				cancelStorageDrsRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cancelStorageDrsRecommendationRequestType.key = key;
				this.VimServiceProxy.CancelStorageDrsRecommendation(new CancelStorageDrsRecommendationRequest(cancelStorageDrsRecommendationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshStorageDrsRecommendation(ManagedObjectReference pod)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RefreshStorageDrsRecommendationRequestType refreshStorageDrsRecommendationRequestType = new RefreshStorageDrsRecommendationRequestType();
				refreshStorageDrsRecommendationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				refreshStorageDrsRecommendationRequestType.pod = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pod);
				this.VimServiceProxy.RefreshStorageDrsRecommendation(new RefreshStorageDrsRecommendationRequest(refreshStorageDrsRecommendationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ConfigureStorageDrsForPod_Task(ManagedObjectReference pod, StorageDrsConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ConfigureStorageDrsForPodRequestType configureStorageDrsForPodRequestType = new ConfigureStorageDrsForPodRequestType();
				configureStorageDrsForPodRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureStorageDrsForPodRequestType.pod = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pod);
				configureStorageDrsForPodRequestType.spec = (VimApi_65.StorageDrsConfigSpec)VIConvert.ToWsdlType(spec);
				configureStorageDrsForPodRequestType.modify = modify;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConfigureStorageDrsForPod_Task(new ConfigureStorageDrsForPod_TaskRequest(configureStorageDrsForPodRequestType)).ConfigureStorageDrsForPod_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConfigureStorageDrsForPod(ManagedObjectReference pod, StorageDrsConfigSpec spec, bool modify)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.ConfigureStorageDrsForPod_Task(pod, spec, modify);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public StoragePlacementResult RecommendDatastores(StoragePlacementSpec storageSpec)
		{
			StoragePlacementResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				RecommendDatastoresRequestType recommendDatastoresRequestType = new RecommendDatastoresRequestType();
				recommendDatastoresRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				recommendDatastoresRequestType.storageSpec = (VimApi_65.StoragePlacementSpec)VIConvert.ToWsdlType(storageSpec);
				result = (StoragePlacementResult)VIConvert.ToVim(this.VimServiceProxy.RecommendDatastores(new RecommendDatastoresRequest(recommendDatastoresRequestType)).RecommendDatastoresResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

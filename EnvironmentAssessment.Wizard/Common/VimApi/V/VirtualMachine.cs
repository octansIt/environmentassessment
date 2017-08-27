using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachine : ManagedEntity
	{
		protected VirtualMachineCapability _capability;
		protected VirtualMachineConfigInfo _config;
		protected VirtualMachineFileLayout _layout;
		protected VirtualMachineFileLayoutEx _layoutEx;
		protected VirtualMachineStorageInfo _storage;
		protected ManagedObjectReference _environmentBrowser;
		protected ManagedObjectReference _resourcePool;
		protected ManagedObjectReference _parentVApp;
		protected ResourceConfigSpec _resourceConfig;
		protected VirtualMachineRuntimeInfo _runtime;
		protected GuestInfo _guest;
		protected VirtualMachineSummary _summary;
		protected ManagedObjectReference[] _datastore;
		protected ManagedObjectReference[] _network;
		protected VirtualMachineSnapshotInfo _snapshot;
		protected ManagedObjectReference[] _rootSnapshot;
		protected ManagedEntityStatus _guestHeartbeatStatus;
		public VirtualMachineCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public VirtualMachineConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public VirtualMachineFileLayout Layout
		{
			get
			{
				return this._layout;
			}
		}
		public VirtualMachineFileLayoutEx LayoutEx
		{
			get
			{
				return this._layoutEx;
			}
		}
		public VirtualMachineStorageInfo Storage
		{
			get
			{
				return this._storage;
			}
		}
		public ManagedObjectReference EnvironmentBrowser
		{
			get
			{
				return this._environmentBrowser;
			}
		}
		public ManagedObjectReference ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public ManagedObjectReference ParentVApp
		{
			get
			{
				return this._parentVApp;
			}
		}
		public ResourceConfigSpec ResourceConfig
		{
			get
			{
				return this._resourceConfig;
			}
		}
		public VirtualMachineRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
		}
		public GuestInfo Guest
		{
			get
			{
				return this._guest;
			}
		}
		public VirtualMachineSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
		}
		public ManagedObjectReference[] Network
		{
			get
			{
				return this._network;
			}
		}
		public VirtualMachineSnapshotInfo Snapshot
		{
			get
			{
				return this._snapshot;
			}
		}
		public ManagedObjectReference[] RootSnapshot
		{
			get
			{
				return this._rootSnapshot;
			}
		}
		public ManagedEntityStatus GuestHeartbeatStatus
		{
			get
			{
				return this._guestHeartbeatStatus;
			}
		}
		public new VirtualMachine_LinkedView LinkedView
		{
			get
			{
				return (VirtualMachine_LinkedView)this._linkedView;
			}
		}
		public VirtualMachine(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshStorageInfo()
		{
			try
			{
				RefreshStorageInfoRequestType refreshStorageInfoRequestType = new RefreshStorageInfoRequestType();
				refreshStorageInfoRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshStorageInfo(new RefreshStorageInfoRequest(refreshStorageInfoRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateSnapshot_Task(string name, string description, bool memory, bool quiesce)
		{
			ManagedObjectReference result;
			try
			{
				CreateSnapshotRequestType createSnapshotRequestType = new CreateSnapshotRequestType();
				createSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createSnapshotRequestType.name = name;
				createSnapshotRequestType.description = description;
				createSnapshotRequestType.memory = memory;
				createSnapshotRequestType.quiesce = quiesce;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateSnapshot_Task(new CreateSnapshot_TaskRequest(createSnapshotRequestType)).CreateSnapshot_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateSnapshot(string name, string description, bool memory, bool quiesce)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.CreateSnapshot_Task(name, description, memory, quiesce);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateSnapshotEx_Task(string name, string description, bool memory, VirtualMachineGuestQuiesceSpec quiesceSpec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				CreateSnapshotExRequestType createSnapshotExRequestType = new CreateSnapshotExRequestType();
				createSnapshotExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createSnapshotExRequestType.name = name;
				createSnapshotExRequestType.description = description;
				createSnapshotExRequestType.memory = memory;
				createSnapshotExRequestType.quiesceSpec = (VimApi_65.VirtualMachineGuestQuiesceSpec)VIConvert.ToWsdlType(quiesceSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateSnapshotEx_Task(new CreateSnapshotEx_TaskRequest(createSnapshotExRequestType)).CreateSnapshotEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateSnapshotEx(string name, string description, bool memory, VirtualMachineGuestQuiesceSpec quiesceSpec)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				ManagedObjectReference taskReference = this.CreateSnapshotEx_Task(name, description, memory, quiesceSpec);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference RevertToCurrentSnapshot_Task(ManagedObjectReference host, bool? suppressPowerOn)
		{
			ManagedObjectReference result;
			try
			{
				RevertToCurrentSnapshotRequestType revertToCurrentSnapshotRequestType = new RevertToCurrentSnapshotRequestType();
				revertToCurrentSnapshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				revertToCurrentSnapshotRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				revertToCurrentSnapshotRequestType.suppressPowerOn = suppressPowerOn.GetValueOrDefault();
				revertToCurrentSnapshotRequestType.suppressPowerOnSpecified = suppressPowerOn.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RevertToCurrentSnapshot_Task(new RevertToCurrentSnapshot_TaskRequest(revertToCurrentSnapshotRequestType)).RevertToCurrentSnapshot_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RevertToCurrentSnapshot(ManagedObjectReference host, bool? suppressPowerOn)
		{
			try
			{
				ManagedObjectReference taskReference = this.RevertToCurrentSnapshot_Task(host, suppressPowerOn);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RemoveAllSnapshots_Task(bool? consolidate)
		{
			ManagedObjectReference result;
			try
			{
				RemoveAllSnapshotsRequestType removeAllSnapshotsRequestType = new RemoveAllSnapshotsRequestType();
				removeAllSnapshotsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeAllSnapshotsRequestType.consolidate = consolidate.GetValueOrDefault();
				removeAllSnapshotsRequestType.consolidateSpecified = consolidate.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RemoveAllSnapshots_Task(new RemoveAllSnapshots_TaskRequest(removeAllSnapshotsRequestType)).RemoveAllSnapshots_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RemoveAllSnapshots(bool? consolidate)
		{
			try
			{
				ManagedObjectReference taskReference = this.RemoveAllSnapshots_Task(consolidate);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ConsolidateVMDisks_Task()
		{
			ManagedObjectReference result;
			try
			{
				ConsolidateVMDisksRequestType consolidateVMDisksRequestType = new ConsolidateVMDisksRequestType();
				consolidateVMDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConsolidateVMDisks_Task(new ConsolidateVMDisks_TaskRequest(consolidateVMDisksRequestType)).ConsolidateVMDisks_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConsolidateVMDisks()
		{
			try
			{
				ManagedObjectReference taskReference = this.ConsolidateVMDisks_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference EstimateStorageForConsolidateSnapshots_Task()
		{
			ManagedObjectReference result;
			try
			{
				EstimateStorageForConsolidateSnapshotsRequestType estimateStorageForConsolidateSnapshotsRequestType = new EstimateStorageForConsolidateSnapshotsRequestType();
				estimateStorageForConsolidateSnapshotsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EstimateStorageForConsolidateSnapshots_Task(new EstimateStorageForConsolidateSnapshots_TaskRequest(estimateStorageForConsolidateSnapshotsRequestType)).EstimateStorageForConsolidateSnapshots_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public StorageRequirement[] EstimateStorageForConsolidateSnapshots()
		{
			StorageRequirement[] result;
			try
			{
				ManagedObjectReference taskReference = this.EstimateStorageForConsolidateSnapshots_Task();
				result = (StorageRequirement[])this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ReconfigVM_Task(VirtualMachineConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				ReconfigVMRequestType reconfigVMRequestType = new ReconfigVMRequestType();
				reconfigVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigVMRequestType.spec = (VimApi_65.VirtualMachineConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ReconfigVM_Task(new ReconfigVM_TaskRequest(reconfigVMRequestType)).ReconfigVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ReconfigVM(VirtualMachineConfigSpec spec)
		{
			try
			{
				ManagedObjectReference taskReference = this.ReconfigVM_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UpgradeVM_Task(string version)
		{
			ManagedObjectReference result;
			try
			{
				UpgradeVMRequestType upgradeVMRequestType = new UpgradeVMRequestType();
				upgradeVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				upgradeVMRequestType.version = version;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpgradeVM_Task(new UpgradeVM_TaskRequest(upgradeVMRequestType)).UpgradeVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpgradeVM(string version)
		{
			try
			{
				ManagedObjectReference taskReference = this.UpgradeVM_Task(version);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string ExtractOvfEnvironment()
		{
			string returnval;
			try
			{
				ExtractOvfEnvironmentRequestType extractOvfEnvironmentRequestType = new ExtractOvfEnvironmentRequestType();
				extractOvfEnvironmentRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.ExtractOvfEnvironment(new ExtractOvfEnvironmentRequest(extractOvfEnvironmentRequestType)).ExtractOvfEnvironmentResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public ManagedObjectReference PowerOnVM_Task(ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				PowerOnVMRequestType powerOnVMRequestType = new PowerOnVMRequestType();
				powerOnVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				powerOnVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerOnVM_Task(new PowerOnVM_TaskRequest(powerOnVMRequestType)).PowerOnVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerOnVM(ManagedObjectReference host)
		{
			try
			{
				ManagedObjectReference taskReference = this.PowerOnVM_Task(host);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PowerOffVM_Task()
		{
			ManagedObjectReference result;
			try
			{
				PowerOffVMRequestType powerOffVMRequestType = new PowerOffVMRequestType();
				powerOffVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerOffVM_Task(new PowerOffVM_TaskRequest(powerOffVMRequestType)).PowerOffVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerOffVM()
		{
			try
			{
				ManagedObjectReference taskReference = this.PowerOffVM_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference SuspendVM_Task()
		{
			ManagedObjectReference result;
			try
			{
				SuspendVMRequestType suspendVMRequestType = new SuspendVMRequestType();
				suspendVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.SuspendVM_Task(new SuspendVM_TaskRequest(suspendVMRequestType)).SuspendVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SuspendVM()
		{
			try
			{
				ManagedObjectReference taskReference = this.SuspendVM_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference ResetVM_Task()
		{
			ManagedObjectReference result;
			try
			{
				ResetVMRequestType resetVMRequestType = new ResetVMRequestType();
				resetVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ResetVM_Task(new ResetVM_TaskRequest(resetVMRequestType)).ResetVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ResetVM()
		{
			try
			{
				ManagedObjectReference taskReference = this.ResetVM_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ShutdownGuest()
		{
			try
			{
				ShutdownGuestRequestType shutdownGuestRequestType = new ShutdownGuestRequestType();
				shutdownGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ShutdownGuest(new ShutdownGuestRequest(shutdownGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RebootGuest()
		{
			try
			{
				RebootGuestRequestType rebootGuestRequestType = new RebootGuestRequestType();
				rebootGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RebootGuest(new RebootGuestRequest(rebootGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void StandbyGuest()
		{
			try
			{
				StandbyGuestRequestType standbyGuestRequestType = new StandbyGuestRequestType();
				standbyGuestRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.StandbyGuest(new StandbyGuestRequest(standbyGuestRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void AnswerVM(string questionId, string answerChoice)
		{
			try
			{
				AnswerVMRequestType answerVMRequestType = new AnswerVMRequestType();
				answerVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				answerVMRequestType.questionId = questionId;
				answerVMRequestType.answerChoice = answerChoice;
				this.VimServiceProxy.AnswerVM(new AnswerVMRequest(answerVMRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CustomizeVM_Task(CustomizationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CustomizeVMRequestType customizeVMRequestType = new CustomizeVMRequestType();
				customizeVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				customizeVMRequestType.spec = (VimApi_65.CustomizationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CustomizeVM_Task(new CustomizeVM_TaskRequest(customizeVMRequestType)).CustomizeVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CustomizeVM(CustomizationSpec spec)
		{
			try
			{
				ManagedObjectReference taskReference = this.CustomizeVM_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void CheckCustomizationSpec(CustomizationSpec spec)
		{
			try
			{
				CheckCustomizationSpecRequestType checkCustomizationSpecRequestType = new CheckCustomizationSpecRequestType();
				checkCustomizationSpecRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				checkCustomizationSpecRequestType.spec = (VimApi_65.CustomizationSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.CheckCustomizationSpec(new CheckCustomizationSpecRequest(checkCustomizationSpecRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MigrateVM_Task(ManagedObjectReference pool, ManagedObjectReference host, VirtualMachineMovePriority priority, VirtualMachinePowerState? state)
		{
			ManagedObjectReference result;
			try
			{
				MigrateVMRequestType migrateVMRequestType = new MigrateVMRequestType();
				migrateVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				migrateVMRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				migrateVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				migrateVMRequestType.priority = (VimApi_65.VirtualMachineMovePriority)VIConvert.ToWsdlType(priority);
				migrateVMRequestType.state = (VimApi_65.VirtualMachinePowerState)VIConvert.ToWsdlType(state.GetValueOrDefault());
				migrateVMRequestType.stateSpecified = state.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MigrateVM_Task(new MigrateVM_TaskRequest(migrateVMRequestType)).MigrateVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MigrateVM(ManagedObjectReference pool, ManagedObjectReference host, VirtualMachineMovePriority priority, VirtualMachinePowerState? state)
		{
			try
			{
				ManagedObjectReference taskReference = this.MigrateVM_Task(pool, host, priority, state);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference RelocateVM_Task(VirtualMachineRelocateSpec spec, VirtualMachineMovePriority? priority)
		{
			ManagedObjectReference result;
			try
			{
				RelocateVMRequestType relocateVMRequestType = new RelocateVMRequestType();
				relocateVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				relocateVMRequestType.spec = (VimApi_65.VirtualMachineRelocateSpec)VIConvert.ToWsdlType(spec);
				relocateVMRequestType.priority = (VimApi_65.VirtualMachineMovePriority)VIConvert.ToWsdlType(priority.GetValueOrDefault());
				relocateVMRequestType.prioritySpecified = priority.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.RelocateVM_Task(new RelocateVM_TaskRequest(relocateVMRequestType)).RelocateVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void RelocateVM(VirtualMachineRelocateSpec spec, VirtualMachineMovePriority? priority)
		{
			try
			{
				ManagedObjectReference taskReference = this.RelocateVM_Task(spec, priority);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CloneVM_Task(ManagedObjectReference folder, string name, VirtualMachineCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CloneVMRequestType cloneVMRequestType = new CloneVMRequestType();
				cloneVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cloneVMRequestType.folder = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(folder);
				cloneVMRequestType.name = name;
				cloneVMRequestType.spec = (VimApi_65.VirtualMachineCloneSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CloneVM_Task(new CloneVM_TaskRequest(cloneVMRequestType)).CloneVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CloneVM(ManagedObjectReference folder, string name, VirtualMachineCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.CloneVM_Task(folder, name, spec);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExportVm()
		{
			ManagedObjectReference result;
			try
			{
				ExportVmRequestType exportVmRequestType = new ExportVmRequestType();
				exportVmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExportVm(new ExportVmRequest(exportVmRequestType)).ExportVmResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MarkAsTemplate()
		{
			try
			{
				MarkAsTemplateRequestType markAsTemplateRequestType = new MarkAsTemplateRequestType();
				markAsTemplateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.MarkAsTemplate(new MarkAsTemplateRequest(markAsTemplateRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MarkAsVirtualMachine(ManagedObjectReference pool, ManagedObjectReference host)
		{
			try
			{
				MarkAsVirtualMachineRequestType markAsVirtualMachineRequestType = new MarkAsVirtualMachineRequestType();
				markAsVirtualMachineRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				markAsVirtualMachineRequestType.pool = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(pool);
				markAsVirtualMachineRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				this.VimServiceProxy.MarkAsVirtualMachine(new MarkAsVirtualMachineRequest(markAsVirtualMachineRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnregisterVM()
		{
			try
			{
				UnregisterVMRequestType unregisterVMRequestType = new UnregisterVMRequestType();
				unregisterVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.UnregisterVM(new UnregisterVMRequest(unregisterVMRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ResetGuestInformation()
		{
			try
			{
				ResetGuestInformationRequestType resetGuestInformationRequestType = new ResetGuestInformationRequestType();
				resetGuestInformationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ResetGuestInformation(new ResetGuestInformationRequest(resetGuestInformationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void MountToolsInstaller()
		{
			try
			{
				MountToolsInstallerRequestType mountToolsInstallerRequestType = new MountToolsInstallerRequestType();
				mountToolsInstallerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.MountToolsInstaller(new MountToolsInstallerRequest(mountToolsInstallerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnmountToolsInstaller()
		{
			try
			{
				UnmountToolsInstallerRequestType unmountToolsInstallerRequestType = new UnmountToolsInstallerRequestType();
				unmountToolsInstallerRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.UnmountToolsInstaller(new UnmountToolsInstallerRequest(unmountToolsInstallerRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference UpgradeTools_Task(string installerOptions)
		{
			ManagedObjectReference result;
			try
			{
				UpgradeToolsRequestType upgradeToolsRequestType = new UpgradeToolsRequestType();
				upgradeToolsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				upgradeToolsRequestType.installerOptions = installerOptions;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.UpgradeTools_Task(new UpgradeTools_TaskRequest(upgradeToolsRequestType)).UpgradeTools_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void UpgradeTools(string installerOptions)
		{
			try
			{
				ManagedObjectReference taskReference = this.UpgradeTools_Task(installerOptions);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VirtualMachineMksTicket AcquireMksTicket()
		{
			VirtualMachineMksTicket result;
			try
			{
				AcquireMksTicketRequestType acquireMksTicketRequestType = new AcquireMksTicketRequestType();
				acquireMksTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VirtualMachineMksTicket)VIConvert.ToVim(this.VimServiceProxy.AcquireMksTicket(new AcquireMksTicketRequest(acquireMksTicketRequestType)).AcquireMksTicketResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public VirtualMachineTicket AcquireTicket(string ticketType)
		{
			VirtualMachineTicket result;
			try
			{
				AcquireTicketRequestType acquireTicketRequestType = new AcquireTicketRequestType();
				acquireTicketRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				acquireTicketRequestType.ticketType = ticketType;
				result = (VirtualMachineTicket)VIConvert.ToVim(this.VimServiceProxy.AcquireTicket(new AcquireTicketRequest(acquireTicketRequestType)).AcquireTicketResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SetScreenResolution(int width, int height)
		{
			try
			{
				SetScreenResolutionRequestType setScreenResolutionRequestType = new SetScreenResolutionRequestType();
				setScreenResolutionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setScreenResolutionRequestType.width = width;
				setScreenResolutionRequestType.height = height;
				this.VimServiceProxy.SetScreenResolution(new SetScreenResolutionRequest(setScreenResolutionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DefragmentAllDisks()
		{
			try
			{
				DefragmentAllDisksRequestType defragmentAllDisksRequestType = new DefragmentAllDisksRequestType();
				defragmentAllDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DefragmentAllDisks(new DefragmentAllDisksRequest(defragmentAllDisksRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateSecondaryVM_Task(ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				CreateSecondaryVMRequestType createSecondaryVMRequestType = new CreateSecondaryVMRequestType();
				createSecondaryVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createSecondaryVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateSecondaryVM_Task(new CreateSecondaryVM_TaskRequest(createSecondaryVMRequestType)).CreateSecondaryVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public FaultToleranceSecondaryOpResult CreateSecondaryVM(ManagedObjectReference host)
		{
			FaultToleranceSecondaryOpResult result;
			try
			{
				ManagedObjectReference taskReference = this.CreateSecondaryVM_Task(host);
				result = (FaultToleranceSecondaryOpResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CreateSecondaryVMEx_Task(ManagedObjectReference host, FaultToleranceConfigSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				CreateSecondaryVMExRequestType createSecondaryVMExRequestType = new CreateSecondaryVMExRequestType();
				createSecondaryVMExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createSecondaryVMExRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				createSecondaryVMExRequestType.spec = (VimApi_65.FaultToleranceConfigSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateSecondaryVMEx_Task(new CreateSecondaryVMEx_TaskRequest(createSecondaryVMExRequestType)).CreateSecondaryVMEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public FaultToleranceSecondaryOpResult CreateSecondaryVMEx(ManagedObjectReference host, FaultToleranceConfigSpec spec)
		{
			FaultToleranceSecondaryOpResult result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = this.CreateSecondaryVMEx_Task(host, spec);
				result = (FaultToleranceSecondaryOpResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference TurnOffFaultToleranceForVM_Task()
		{
			ManagedObjectReference result;
			try
			{
				TurnOffFaultToleranceForVMRequestType turnOffFaultToleranceForVMRequestType = new TurnOffFaultToleranceForVMRequestType();
				turnOffFaultToleranceForVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.TurnOffFaultToleranceForVM_Task(new TurnOffFaultToleranceForVM_TaskRequest(turnOffFaultToleranceForVMRequestType)).TurnOffFaultToleranceForVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void TurnOffFaultToleranceForVM()
		{
			try
			{
				ManagedObjectReference taskReference = this.TurnOffFaultToleranceForVM_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference MakePrimaryVM_Task(ManagedObjectReference vm)
		{
			ManagedObjectReference result;
			try
			{
				MakePrimaryVMRequestType makePrimaryVMRequestType = new MakePrimaryVMRequestType();
				makePrimaryVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				makePrimaryVMRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.MakePrimaryVM_Task(new MakePrimaryVM_TaskRequest(makePrimaryVMRequestType)).MakePrimaryVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void MakePrimaryVM(ManagedObjectReference vm)
		{
			try
			{
				ManagedObjectReference taskReference = this.MakePrimaryVM_Task(vm);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference TerminateFaultTolerantVM_Task(ManagedObjectReference vm)
		{
			ManagedObjectReference result;
			try
			{
				TerminateFaultTolerantVMRequestType terminateFaultTolerantVMRequestType = new TerminateFaultTolerantVMRequestType();
				terminateFaultTolerantVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				terminateFaultTolerantVMRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.TerminateFaultTolerantVM_Task(new TerminateFaultTolerantVM_TaskRequest(terminateFaultTolerantVMRequestType)).TerminateFaultTolerantVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void TerminateFaultTolerantVM(ManagedObjectReference vm)
		{
			try
			{
				ManagedObjectReference taskReference = this.TerminateFaultTolerantVM_Task(vm);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DisableSecondaryVM_Task(ManagedObjectReference vm)
		{
			ManagedObjectReference result;
			try
			{
				DisableSecondaryVMRequestType disableSecondaryVMRequestType = new DisableSecondaryVMRequestType();
				disableSecondaryVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				disableSecondaryVMRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DisableSecondaryVM_Task(new DisableSecondaryVM_TaskRequest(disableSecondaryVMRequestType)).DisableSecondaryVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DisableSecondaryVM(ManagedObjectReference vm)
		{
			try
			{
				ManagedObjectReference taskReference = this.DisableSecondaryVM_Task(vm);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference EnableSecondaryVM_Task(ManagedObjectReference vm, ManagedObjectReference host)
		{
			ManagedObjectReference result;
			try
			{
				EnableSecondaryVMRequestType enableSecondaryVMRequestType = new EnableSecondaryVMRequestType();
				enableSecondaryVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableSecondaryVMRequestType.vm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(vm);
				enableSecondaryVMRequestType.host = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(host);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.EnableSecondaryVM_Task(new EnableSecondaryVM_TaskRequest(enableSecondaryVMRequestType)).EnableSecondaryVM_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public FaultToleranceSecondaryOpResult EnableSecondaryVM(ManagedObjectReference vm, ManagedObjectReference host)
		{
			FaultToleranceSecondaryOpResult result;
			try
			{
				ManagedObjectReference taskReference = this.EnableSecondaryVM_Task(vm, host);
				result = (FaultToleranceSecondaryOpResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SetDisplayTopology(VirtualMachineDisplayTopology[] displays)
		{
			try
			{
				SetDisplayTopologyRequestType setDisplayTopologyRequestType = new SetDisplayTopologyRequestType();
				setDisplayTopologyRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setDisplayTopologyRequestType.displays = (VimApi_65.VirtualMachineDisplayTopology[])VIConvert.ToWsdlType(displays);
				this.VimServiceProxy.SetDisplayTopology(new SetDisplayTopologyRequest(setDisplayTopologyRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference StartRecording_Task(string name, string description)
		{
			ManagedObjectReference result;
			try
			{
				StartRecordingRequestType startRecordingRequestType = new StartRecordingRequestType();
				startRecordingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				startRecordingRequestType.name = name;
				startRecordingRequestType.description = description;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StartRecording_Task(new StartRecording_TaskRequest(startRecordingRequestType)).StartRecording_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference StartRecording(string name, string description)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = this.StartRecording_Task(name, description);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference StopRecording_Task()
		{
			ManagedObjectReference result;
			try
			{
				StopRecordingRequestType stopRecordingRequestType = new StopRecordingRequestType();
				stopRecordingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StopRecording_Task(new StopRecording_TaskRequest(stopRecordingRequestType)).StopRecording_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void StopRecording()
		{
			try
			{
				ManagedObjectReference taskReference = this.StopRecording_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference StartReplaying_Task(ManagedObjectReference replaySnapshot)
		{
			ManagedObjectReference result;
			try
			{
				StartReplayingRequestType startReplayingRequestType = new StartReplayingRequestType();
				startReplayingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				startReplayingRequestType.replaySnapshot = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(replaySnapshot);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StartReplaying_Task(new StartReplaying_TaskRequest(startReplayingRequestType)).StartReplaying_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void StartReplaying(ManagedObjectReference replaySnapshot)
		{
			try
			{
				ManagedObjectReference taskReference = this.StartReplaying_Task(replaySnapshot);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference StopReplaying_Task()
		{
			ManagedObjectReference result;
			try
			{
				StopReplayingRequestType stopReplayingRequestType = new StopReplayingRequestType();
				stopReplayingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.StopReplaying_Task(new StopReplaying_TaskRequest(stopReplayingRequestType)).StopReplaying_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void StopReplaying()
		{
			try
			{
				ManagedObjectReference taskReference = this.StopReplaying_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PromoteDisks_Task(bool unlink, VirtualDisk[] disks)
		{
			ManagedObjectReference result;
			try
			{
				PromoteDisksRequestType promoteDisksRequestType = new PromoteDisksRequestType();
				promoteDisksRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				promoteDisksRequestType.unlink = unlink;
				promoteDisksRequestType.disks = (VimApi_65.VirtualDisk[])VIConvert.ToWsdlType(disks);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PromoteDisks_Task(new PromoteDisks_TaskRequest(promoteDisksRequestType)).PromoteDisks_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PromoteDisks(bool unlink, VirtualDisk[] disks)
		{
			try
			{
				ManagedObjectReference taskReference = this.PromoteDisks_Task(unlink, disks);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CreateScreenshot_Task()
		{
			ManagedObjectReference result;
			try
			{
				CreateScreenshotRequestType createScreenshotRequestType = new CreateScreenshotRequestType();
				createScreenshotRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateScreenshot_Task(new CreateScreenshot_TaskRequest(createScreenshotRequestType)).CreateScreenshot_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string CreateScreenshot()
		{
			string result;
			try
			{
				ManagedObjectReference taskReference = this.CreateScreenshot_Task();
				result = (string)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public int PutUsbScanCodes(UsbScanCodeSpec spec)
		{
			int returnval;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				PutUsbScanCodesRequestType putUsbScanCodesRequestType = new PutUsbScanCodesRequestType();
				putUsbScanCodesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				putUsbScanCodesRequestType.spec = (VimApi_65.UsbScanCodeSpec)VIConvert.ToWsdlType(spec);
				returnval = this.VimServiceProxy.PutUsbScanCodes(new PutUsbScanCodesRequest(putUsbScanCodesRequestType)).PutUsbScanCodesResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public DiskChangeInfo QueryChangedDiskAreas(ManagedObjectReference snapshot, int deviceKey, long startOffset, string changeId)
		{
			DiskChangeInfo result;
			try
			{
				QueryChangedDiskAreasRequestType queryChangedDiskAreasRequestType = new QueryChangedDiskAreasRequestType();
				queryChangedDiskAreasRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryChangedDiskAreasRequestType.snapshot = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(snapshot);
				queryChangedDiskAreasRequestType.deviceKey = deviceKey;
				queryChangedDiskAreasRequestType.startOffset = startOffset;
				queryChangedDiskAreasRequestType.changeId = changeId;
				result = (DiskChangeInfo)VIConvert.ToVim(this.VimServiceProxy.QueryChangedDiskAreas(new QueryChangedDiskAreasRequest(queryChangedDiskAreasRequestType)).QueryChangedDiskAreasResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string[] QueryUnownedFiles()
		{
			string[] queryUnownedFilesResponse;
			try
			{
				QueryUnownedFilesRequestType queryUnownedFilesRequestType = new QueryUnownedFilesRequestType();
				queryUnownedFilesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryUnownedFilesResponse = this.VimServiceProxy.QueryUnownedFiles(new QueryUnownedFilesRequest(queryUnownedFilesRequestType)).QueryUnownedFilesResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryUnownedFilesResponse;
		}
		public ManagedObjectReference reloadVirtualMachineFromPath_Task(string configurationPath)
		{
			ManagedObjectReference result;
			try
			{
				reloadVirtualMachineFromPathRequestType reloadVirtualMachineFromPathRequestType = new reloadVirtualMachineFromPathRequestType();
				reloadVirtualMachineFromPathRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reloadVirtualMachineFromPathRequestType.configurationPath = configurationPath;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.reloadVirtualMachineFromPath_Task(new reloadVirtualMachineFromPath_TaskRequest(reloadVirtualMachineFromPathRequestType)).reloadVirtualMachineFromPath_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void reloadVirtualMachineFromPath(string configurationPath)
		{
			try
			{
				ManagedObjectReference taskReference = this.reloadVirtualMachineFromPath_Task(configurationPath);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public LocalizedMethodFault[] QueryFaultToleranceCompatibility()
		{
			LocalizedMethodFault[] result;
			try
			{
				QueryFaultToleranceCompatibilityRequestType queryFaultToleranceCompatibilityRequestType = new QueryFaultToleranceCompatibilityRequestType();
				queryFaultToleranceCompatibilityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (LocalizedMethodFault[])VIConvert.ToVim(this.VimServiceProxy.QueryFaultToleranceCompatibility(new QueryFaultToleranceCompatibilityRequest(queryFaultToleranceCompatibilityRequestType)).QueryFaultToleranceCompatibilityResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public LocalizedMethodFault[] QueryFaultToleranceCompatibilityEx(bool? forLegacyFt)
		{
			LocalizedMethodFault[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				QueryFaultToleranceCompatibilityExRequestType queryFaultToleranceCompatibilityExRequestType = new QueryFaultToleranceCompatibilityExRequestType();
				queryFaultToleranceCompatibilityExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryFaultToleranceCompatibilityExRequestType.forLegacyFt = forLegacyFt.GetValueOrDefault();
				queryFaultToleranceCompatibilityExRequestType.forLegacyFtSpecified = forLegacyFt.HasValue;
				result = (LocalizedMethodFault[])VIConvert.ToVim(this.VimServiceProxy.QueryFaultToleranceCompatibilityEx(new QueryFaultToleranceCompatibilityExRequest(queryFaultToleranceCompatibilityExRequestType)).QueryFaultToleranceCompatibilityExResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void TerminateVM()
		{
			try
			{
				TerminateVMRequestType terminateVMRequestType = new TerminateVMRequestType();
				terminateVMRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.TerminateVM(new TerminateVMRequest(terminateVMRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void SendNMI()
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				SendNMIRequestType sendNMIRequestType = new SendNMIRequestType();
				sendNMIRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.SendNMI(new SendNMIRequest(sendNMIRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference AttachDisk_Task(ID diskId, ManagedObjectReference datastore, int? controllerKey, int? unitNumber)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				AttachDiskRequestType attachDiskRequestType = new AttachDiskRequestType();
				attachDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				attachDiskRequestType.diskId = (VimApi_65.ID)VIConvert.ToWsdlType(diskId);
				attachDiskRequestType.datastore = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(datastore);
				attachDiskRequestType.controllerKey = controllerKey.GetValueOrDefault();
				attachDiskRequestType.controllerKeySpecified = controllerKey.HasValue;
				attachDiskRequestType.unitNumber = unitNumber.GetValueOrDefault();
				attachDiskRequestType.unitNumberSpecified = unitNumber.HasValue;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.AttachDisk_Task(new AttachDisk_TaskRequest(attachDiskRequestType)).AttachDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AttachDisk(ID diskId, ManagedObjectReference datastore, int? controllerKey, int? unitNumber)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = this.AttachDisk_Task(diskId, datastore, controllerKey, unitNumber);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference DetachDisk_Task(ID diskId)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				DetachDiskRequestType detachDiskRequestType = new DetachDiskRequestType();
				detachDiskRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				detachDiskRequestType.diskId = (VimApi_65.ID)VIConvert.ToWsdlType(diskId);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.DetachDisk_Task(new DetachDisk_TaskRequest(detachDiskRequestType)).DetachDisk_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void DetachDisk(ID diskId)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = this.DetachDisk_Task(diskId);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

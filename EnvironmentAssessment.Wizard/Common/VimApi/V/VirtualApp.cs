using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualApp : ResourcePool
	{
		protected ManagedObjectReference _parentFolder;
		protected ManagedObjectReference[] _datastore;
		protected ManagedObjectReference[] _network;
		protected VAppConfigInfo _vAppConfig;
		protected ManagedObjectReference _parentVApp;
		protected VirtualAppLinkInfo[] _childLink;
		public ManagedObjectReference ParentFolder
		{
			get
			{
				return this._parentFolder;
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
		public VAppConfigInfo VAppConfig
		{
			get
			{
				return this._vAppConfig;
			}
		}
		public ManagedObjectReference ParentVApp
		{
			get
			{
				return this._parentVApp;
			}
		}
		public VirtualAppLinkInfo[] ChildLink
		{
			get
			{
				return this._childLink;
			}
		}
		public new VirtualApp_LinkedView LinkedView
		{
			get
			{
				return (VirtualApp_LinkedView)this._linkedView;
			}
		}
		public VirtualApp(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateVAppConfig(VAppConfigSpec spec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateVAppConfigRequestType updateVAppConfigRequestType = new UpdateVAppConfigRequestType();
				updateVAppConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateVAppConfigRequestType.spec = (VimApi_65.VAppConfigSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.UpdateVAppConfig(new UpdateVAppConfigRequest(updateVAppConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateLinkedChildren(VirtualAppLinkInfo[] addChangeSet, ManagedObjectReference[] removeSet)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				UpdateLinkedChildrenRequestType updateLinkedChildrenRequestType = new UpdateLinkedChildrenRequestType();
				updateLinkedChildrenRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateLinkedChildrenRequestType.addChangeSet = (VimApi_65.VirtualAppLinkInfo[])VIConvert.ToWsdlType(addChangeSet);
				updateLinkedChildrenRequestType.removeSet = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(removeSet);
				this.VimServiceProxy.UpdateLinkedChildren(new UpdateLinkedChildrenRequest(updateLinkedChildrenRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference CloneVApp_Task(string name, ManagedObjectReference target, VAppCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CloneVAppRequestType cloneVAppRequestType = new CloneVAppRequestType();
				cloneVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				cloneVAppRequestType.name = name;
				cloneVAppRequestType.target = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(target);
				cloneVAppRequestType.spec = (VimApi_65.VAppCloneSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CloneVApp_Task(new CloneVApp_TaskRequest(cloneVAppRequestType)).CloneVApp_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference CloneVApp(string name, ManagedObjectReference target, VAppCloneSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.CloneVApp_Task(name, target, spec);
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference ExportVApp()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ExportVAppRequestType exportVAppRequestType = new ExportVAppRequestType();
				exportVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ExportVApp(new ExportVAppRequest(exportVAppRequestType)).ExportVAppResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference PowerOnVApp_Task()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				PowerOnVAppRequestType powerOnVAppRequestType = new PowerOnVAppRequestType();
				powerOnVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerOnVApp_Task(new PowerOnVApp_TaskRequest(powerOnVAppRequestType)).PowerOnVApp_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerOnVApp()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.PowerOnVApp_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference PowerOffVApp_Task(bool force)
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				PowerOffVAppRequestType powerOffVAppRequestType = new PowerOffVAppRequestType();
				powerOffVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				powerOffVAppRequestType.force = force;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.PowerOffVApp_Task(new PowerOffVApp_TaskRequest(powerOffVAppRequestType)).PowerOffVApp_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PowerOffVApp(bool force)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.PowerOffVApp_Task(force);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference SuspendVApp_Task()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				SuspendVAppRequestType suspendVAppRequestType = new SuspendVAppRequestType();
				suspendVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.SuspendVApp_Task(new SuspendVApp_TaskRequest(suspendVAppRequestType)).SuspendVApp_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SuspendVApp()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim41);
				ManagedObjectReference taskReference = this.SuspendVApp_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference unregisterVApp_Task()
		{
			ManagedObjectReference result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				unregisterVAppRequestType unregisterVAppRequestType = new unregisterVAppRequestType();
				unregisterVAppRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.unregisterVApp_Task(new unregisterVApp_TaskRequest(unregisterVAppRequestType)).unregisterVApp_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void unregisterVApp()
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				ManagedObjectReference taskReference = this.unregisterVApp_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

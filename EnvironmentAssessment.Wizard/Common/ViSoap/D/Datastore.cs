using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class Datastore : ManagedEntity
	{
		protected DatastoreInfo _info;
		protected DatastoreSummary _summary;
		protected DatastoreHostMount[] _host;
		protected ManagedObjectReference[] _vm;
		protected ManagedObjectReference _browser;
		protected DatastoreCapability _capability;
		protected StorageIORMInfo _iormConfiguration;
		public DatastoreInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public DatastoreSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public DatastoreHostMount[] Host
		{
			get
			{
				return this._host;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
		}
		public ManagedObjectReference Browser
		{
			get
			{
				return this._browser;
			}
		}
		public DatastoreCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public StorageIORMInfo IormConfiguration
		{
			get
			{
				return this._iormConfiguration;
			}
		}
		public new Datastore_LinkedView LinkedView
		{
			get
			{
				return (Datastore_LinkedView)this._linkedView;
			}
		}
		public Datastore(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshDatastore()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshDatastoreStorageInfo()
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RefreshDatastoreStorageInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference UpdateVirtualMachineFiles_Task(DatastoreMountPathDatastorePair[] mountPathDatastoreMapping)
		{
			ManagedObjectReference result;
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateVirtualMachineFiles_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DatastoreMountPathDatastorePair[])VIConvert.ToWsdlType(mountPathDatastoreMapping)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UpdateVirtualMachineFilesResult UpdateVirtualMachineFiles(DatastoreMountPathDatastorePair[] mountPathDatastoreMapping)
		{
			UpdateVirtualMachineFilesResult result;
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
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateVirtualMachineFiles_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DatastoreMountPathDatastorePair[])VIConvert.ToWsdlType(mountPathDatastoreMapping)));
				result = (UpdateVirtualMachineFilesResult)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void RenameDatastore(string newName)
		{
			try
			{
				((VimService)this.Client.VimService).RenameDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), newName);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DestroyDatastore()
		{
			try
			{
				((VimService)this.Client.VimService).DestroyDatastore((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public StoragePlacementResult DatastoreEnterMaintenanceMode()
		{
			StoragePlacementResult result;
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
				result = (StoragePlacementResult)VIConvert.ToVim(((VimService)this.Client.VimService).DatastoreEnterMaintenanceMode((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference DatastoreExitMaintenanceMode_Task()
		{
			ManagedObjectReference result;
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DatastoreExitMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DatastoreExitMaintenanceMode()
		{
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
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DatastoreExitMaintenanceMode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

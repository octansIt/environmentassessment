using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostVsanSystem : ViewBase
	{
		protected VsanHostConfigInfo _config;
		public VsanHostConfigInfo Config
		{
			get
			{
				return this._config;
			}
		}
		public HostVsanSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VsanHostDiskResult[] QueryDisksForVsan(string[] canonicalName)
		{
			VsanHostDiskResult[] result;
			try
			{
				if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				result = (VsanHostDiskResult[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryDisksForVsan((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), canonicalName));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference AddDisks_Task(HostScsiDisk[] disk)
		{
			ManagedObjectReference result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddDisks_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDisk[])VIConvert.ToWsdlType(disk)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VsanHostDiskMapResult[] AddDisks(HostScsiDisk[] disk)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddDisks_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDisk[])VIConvert.ToWsdlType(disk)));
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}

        public void EvacuateVsanNode(HostMaintenanceSpec maintenanceSpec, int timeout)
        {
            try
            {
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
                ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EvacuateVsanNode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec), timeout));
                this.Client.WaitForTask(taskReference);
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
        }

        public ManagedObjectReference EvacuateVsanNode_Task(HostMaintenanceSpec maintenanceSpec, int timeout)
        {
            ManagedObjectReference managedObjectReference;
            try
            {
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51) || (this.Client.Version == VimVersion.Vim55))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
                managedObjectReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).EvacuateVsanNode_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec), timeout));
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return managedObjectReference;
        }

		public ManagedObjectReference InitializeDisks_Task(VsanHostDiskMapping[] mapping)
		{
			ManagedObjectReference result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InitializeDisks_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VsanHostDiskMapResult[] InitializeDisks(VsanHostDiskMapping[] mapping)
		{
			VsanHostDiskMapResult[] result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).InitializeDisks_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping)));
				result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}

        public ManagedObjectReference RemoveDisk_Task(HostScsiDisk[] disk, HostMaintenanceSpec maintenanceSpec)
        {
            ManagedObjectReference managedObjectReference;
            try
            {
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
                else
                {
                    managedObjectReference = (ManagedObjectReference)VIConvert.ToVim(((VimApi_60.VimService)this.Client.VimService).RemoveDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDisk[])VIConvert.ToWsdlType(disk), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
                }
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return managedObjectReference;
        }

        [Obsolete("The method RemoveDisk_Task in HostVsanSystem is deprecated in version 5.5.")]
		public ManagedObjectReference RemoveDisk_Task(HostScsiDisk[] disk)
		{
            return this.RemoveDisk_Task(disk, null);
		}

        // --

         public VsanHostDiskResult[] RemoveDisk(HostScsiDisk[] disk, HostMaintenanceSpec maintenanceSpec)
         {
             VsanHostDiskResult[] result;
             try
             {
                 if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                 {
                     throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                 }
                 else
                 {
                     ManagedObjectReference taskReference2 = (ManagedObjectReference)VIConvert.ToVim(((VimApi_60.VimService)this.Client.VimService).RemoveDisk_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDisk[])VIConvert.ToWsdlType(disk), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
                     result = (VsanHostDiskResult[])this.Client.WaitForTask(taskReference2);
                 }
             }
             catch (SoapException ex)
             {
                 throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
             }
             return result;
         }

        [Obsolete("The method RemoveDisk in HostVsanSystem is deprecated in version 5.5.")]
		public VsanHostDiskResult[] RemoveDisk(HostScsiDisk[] disk)
		{
			return this.RemoveDisk(disk, null);
		}

        public ManagedObjectReference RemoveDiskMapping_Task(VsanHostDiskMapping[] mapping, HostMaintenanceSpec maintenanceSpec)
        {
            ManagedObjectReference managedObjectReference;
            try
            {
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
                else
                {
                    managedObjectReference = (ManagedObjectReference)VIConvert.ToVim(((VimApi_60.VimService)this.Client.VimService).RemoveDiskMapping_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
                }
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return managedObjectReference;
        }

        [Obsolete("The method RemoveDiskMapping_Task in HostVsanSystem is deprecated in version 5.5.")]
		public ManagedObjectReference RemoveDiskMapping_Task(VsanHostDiskMapping[] mapping)
		{
            return this.RemoveDiskMapping_Task(mapping, null);
		}
        //
        public VsanHostDiskMapResult[] RemoveDiskMapping(VsanHostDiskMapping[] mapping, HostMaintenanceSpec maintenanceSpec)
        {
            VsanHostDiskMapResult[] result;
            try
            {
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
                else
                {
                    ManagedObjectReference taskReference2 = (ManagedObjectReference)VIConvert.ToVim(((VimApi_60.VimService)this.Client.VimService).RemoveDiskMapping_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostDiskMapping[])VIConvert.ToWsdlType(mapping), (VimApi_60.HostMaintenanceSpec)VIConvert.ToWsdlType(maintenanceSpec)));
                    result = (VsanHostDiskMapResult[])this.Client.WaitForTask(taskReference2);
                }
            }
            catch (SoapException ex)
            {
                throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
            }
            return result;
        }

        [Obsolete("The method RemoveDiskMapping in HostVsanSystem is deprecated in version 5.5.")]
        public VsanHostDiskMapResult[] RemoveDiskMapping(VsanHostDiskMapping[] mapping)
        {
            return this.RemoveDiskMapping(mapping, null);
        }

		public ManagedObjectReference UpdateVsan_Task(VsanHostConfigInfo config)
		{
			ManagedObjectReference result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateVsan_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostConfigInfo)VIConvert.ToWsdlType(config)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateVsan(VsanHostConfigInfo config)
		{
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).UpdateVsan_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.VsanHostConfigInfo)VIConvert.ToWsdlType(config)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public VsanHostClusterStatus QueryHostStatus()
		{
			VsanHostClusterStatus result;
			try
			{
                if ((this.Client.Version == VimVersion.Vim25) || (this.Client.Version == VimVersion.Vim4) || (this.Client.Version == VimVersion.Vim41) || (this.Client.Version == VimVersion.Vim50) || (this.Client.Version == VimVersion.Vim51))
                {
                    throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
                }
				result = (VsanHostClusterStatus)VIConvert.ToVim(((VimService)this.Client.VimService).QueryHostStatus((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

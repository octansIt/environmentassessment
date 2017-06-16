using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class FileManager : ViewBase
	{
		public FileManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference MoveDatastoreFile_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destinationName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter), force.GetValueOrDefault(), force.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void MoveDatastoreFile(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destinationName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter), force.GetValueOrDefault(), force.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CopyDatastoreFile_Task(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CopyDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destinationName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter), force.GetValueOrDefault(), force.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CopyDatastoreFile(string sourceName, ManagedObjectReference sourceDatacenter, string destinationName, ManagedObjectReference destinationDatacenter, bool? force)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CopyDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), sourceName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(sourceDatacenter), destinationName, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(destinationDatacenter), force.GetValueOrDefault(), force.HasValue));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference DeleteDatastoreFile_Task(string name, ManagedObjectReference datacenter)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DeleteDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DeleteDatastoreFile(string name, ManagedObjectReference datacenter)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).DeleteDatastoreFile_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void MakeDirectory(string name, ManagedObjectReference datacenter, bool? createParentDirectories)
		{
			try
			{
				((VimService)this.Client.VimService).MakeDirectory((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), createParentDirectories.GetValueOrDefault(), createParentDirectories.HasValue);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ChangeOwner(string name, ManagedObjectReference datacenter, string owner)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).ChangeOwner((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(datacenter), owner);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class Task : ExtensibleManagedObject
	{
		protected TaskInfo _info;
		public TaskInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public Task(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void CancelTask()
		{
			try
			{
				((VimService)this.Client.VimService).CancelTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateProgress(int percentDone)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateProgress((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), percentDone);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetTaskState(TaskInfoState state, object result, LocalizedMethodFault fault)
		{
			try
			{
				((VimService)this.Client.VimService).SetTaskState((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.TaskInfoState)VIConvert.ToWsdlType(state), result, (VimApi_60.LocalizedMethodFault)VIConvert.ToWsdlType(fault));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void SetTaskDescription(LocalizableMessage description)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).SetTaskDescription((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.LocalizableMessage)VIConvert.ToWsdlType(description));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

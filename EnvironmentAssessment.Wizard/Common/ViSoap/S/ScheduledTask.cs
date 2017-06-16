using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTask : ExtensibleManagedObject
	{
		protected ScheduledTaskInfo _info;
		public ScheduledTaskInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public ScheduledTask(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RemoveScheduledTask()
		{
			try
			{
				((VimService)this.Client.VimService).RemoveScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ReconfigureScheduledTask(ScheduledTaskSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).ReconfigureScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ScheduledTaskSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RunScheduledTask()
		{
			try
			{
				((VimService)this.Client.VimService).RunScheduledTask((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

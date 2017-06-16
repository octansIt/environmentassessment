using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class Alarm : ExtensibleManagedObject
	{
		protected AlarmInfo _info;
		public AlarmInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public Alarm(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RemoveAlarm()
		{
			try
			{
				((VimService)this.Client.VimService).RemoveAlarm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ReconfigureAlarm(AlarmSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).ReconfigureAlarm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.AlarmSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}


using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
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
				RemoveAlarmRequestType removeAlarmRequestType = new RemoveAlarmRequestType();
				removeAlarmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RemoveAlarm(new RemoveAlarmRequest(removeAlarmRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ReconfigureAlarm(AlarmSpec spec)
		{
			try
			{
				ReconfigureAlarmRequestType reconfigureAlarmRequestType = new ReconfigureAlarmRequestType();
				reconfigureAlarmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				reconfigureAlarmRequestType.spec = (VimApi_65.AlarmSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.ReconfigureAlarm(new ReconfigureAlarmRequest(reconfigureAlarmRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

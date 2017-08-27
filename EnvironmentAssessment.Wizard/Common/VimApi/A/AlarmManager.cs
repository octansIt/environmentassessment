
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmManager : ViewBase
	{
		protected AlarmExpression[] _defaultExpression;
		protected AlarmDescription _description;
		public AlarmExpression[] DefaultExpression
		{
			get
			{
				return this._defaultExpression;
			}
		}
		public AlarmDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public AlarmManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateAlarm(ManagedObjectReference entity, AlarmSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				CreateAlarmRequestType createAlarmRequestType = new CreateAlarmRequestType();
				createAlarmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createAlarmRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				createAlarmRequestType.spec = (VimApi_65.AlarmSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.CreateAlarm(new CreateAlarmRequest(createAlarmRequestType)).CreateAlarmResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference[] GetAlarm(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
				GetAlarmRequestType getAlarmRequestType = new GetAlarmRequestType();
				getAlarmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				getAlarmRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.GetAlarm(new GetAlarmRequest(getAlarmRequestType)).GetAlarmResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public bool AreAlarmActionsEnabled(ManagedObjectReference entity)
		{
			bool returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				AreAlarmActionsEnabledRequestType areAlarmActionsEnabledRequestType = new AreAlarmActionsEnabledRequestType();
				areAlarmActionsEnabledRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				areAlarmActionsEnabledRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				returnval = this.VimServiceProxy.AreAlarmActionsEnabled(new AreAlarmActionsEnabledRequest(areAlarmActionsEnabledRequestType)).AreAlarmActionsEnabledResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void EnableAlarmActions(ManagedObjectReference entity, bool enabled)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
                EnableAlarmActionsRequestType enableAlarmActionsRequestType = new EnableAlarmActionsRequestType();
				enableAlarmActionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				enableAlarmActionsRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				enableAlarmActionsRequestType.enabled = enabled;
				this.VimServiceProxy.EnableAlarmActions(new EnableAlarmActionsRequest(enableAlarmActionsRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public AlarmState[] GetAlarmState(ManagedObjectReference entity)
		{
			AlarmState[] result;
			try
			{
				GetAlarmStateRequestType getAlarmStateRequestType = new GetAlarmStateRequestType();
				getAlarmStateRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				getAlarmStateRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				result = (AlarmState[])VIConvert.ToVim(this.VimServiceProxy.GetAlarmState(new GetAlarmStateRequest(getAlarmStateRequestType)).GetAlarmStateResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AcknowledgeAlarm(ManagedObjectReference alarm, ManagedObjectReference entity)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
                AcknowledgeAlarmRequestType acknowledgeAlarmRequestType = new AcknowledgeAlarmRequestType();
				acknowledgeAlarmRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				acknowledgeAlarmRequestType.alarm = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(alarm);
				acknowledgeAlarmRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				this.VimServiceProxy.AcknowledgeAlarm(new AcknowledgeAlarmRequest(acknowledgeAlarmRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

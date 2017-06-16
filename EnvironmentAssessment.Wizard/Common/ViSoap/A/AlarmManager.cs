using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public AlarmManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateAlarm(ManagedObjectReference entity, AlarmSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateAlarm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), (VimApi_60.AlarmSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference[] GetAlarm(ManagedObjectReference entity)
		{
			ManagedObjectReference[] result;
			try
			{
				result = (ManagedObjectReference[])VIConvert.ToVim(((VimService)this.Client.VimService).GetAlarm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public bool AreAlarmActionsEnabled(ManagedObjectReference entity)
		{
			bool result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = ((VimService)this.Client.VimService).AreAlarmActionsEnabled((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void EnableAlarmActions(ManagedObjectReference entity, bool enabled)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).EnableAlarmActions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), enabled);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public AlarmState[] GetAlarmState(ManagedObjectReference entity)
		{
			AlarmState[] result;
			try
			{
				result = (AlarmState[])VIConvert.ToVim(((VimService)this.Client.VimService).GetAlarmState((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void AcknowledgeAlarm(ManagedObjectReference alarm, ManagedObjectReference entity)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).AcknowledgeAlarm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(alarm), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

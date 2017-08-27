using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDateTimeSystem : ViewBase
	{
		protected HostDateTimeInfo _dateTimeInfo;
		public HostDateTimeInfo DateTimeInfo
		{
			get
			{
				return this._dateTimeInfo;
			}
		}
		public HostDateTimeSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateDateTimeConfig(HostDateTimeConfig config)
		{
			try
			{
				UpdateDateTimeConfigRequestType updateDateTimeConfigRequestType = new UpdateDateTimeConfigRequestType();
				updateDateTimeConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDateTimeConfigRequestType.config = (VimApi_65.HostDateTimeConfig)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateDateTimeConfig(new UpdateDateTimeConfigRequest(updateDateTimeConfigRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostDateTimeSystemTimeZone[] QueryAvailableTimeZones()
		{
			HostDateTimeSystemTimeZone[] result;
			try
			{
				QueryAvailableTimeZonesRequestType queryAvailableTimeZonesRequestType = new QueryAvailableTimeZonesRequestType();
				queryAvailableTimeZonesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostDateTimeSystemTimeZone[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailableTimeZones(new QueryAvailableTimeZonesRequest(queryAvailableTimeZonesRequestType)).QueryAvailableTimeZonesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public DateTime QueryDateTime()
		{
			DateTime returnval;
			try
			{
				QueryDateTimeRequestType queryDateTimeRequestType = new QueryDateTimeRequestType();
				queryDateTimeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.QueryDateTime(new QueryDateTimeRequest(queryDateTimeRequestType)).QueryDateTimeResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void UpdateDateTime(DateTime dateTime)
		{
			try
			{
				UpdateDateTimeRequestType updateDateTimeRequestType = new UpdateDateTimeRequestType();
				updateDateTimeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateDateTimeRequestType.dateTime = dateTime;
				this.VimServiceProxy.UpdateDateTime(new UpdateDateTimeRequest(updateDateTimeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RefreshDateTimeSystem()
		{
			try
			{
				RefreshDateTimeSystemRequestType refreshDateTimeSystemRequestType = new RefreshDateTimeSystemRequestType();
				refreshDateTimeSystemRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RefreshDateTimeSystem(new RefreshDateTimeSystemRequest(refreshDateTimeSystemRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

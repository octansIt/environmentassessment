using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
				((VimService)this.Client.VimService).UpdateDateTimeConfig((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostDateTimeConfig)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostDateTimeSystemTimeZone[] QueryAvailableTimeZones()
		{
			HostDateTimeSystemTimeZone[] result;
			try
			{
				result = (HostDateTimeSystemTimeZone[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAvailableTimeZones((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public DateTime QueryDateTime()
		{
			DateTime result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryDateTime((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateDateTime(DateTime dateTime)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateDateTime((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), dateTime);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshDateTimeSystem()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshDateTimeSystem((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

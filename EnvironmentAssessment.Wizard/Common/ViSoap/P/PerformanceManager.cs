using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class PerformanceManager : ViewBase
	{
		protected PerformanceDescription _description;
		protected PerfInterval[] _historicalInterval;
		protected PerfCounterInfo[] _perfCounter;
		public PerformanceDescription Description
		{
			get
			{
				return this._description;
			}
		}
		public PerfInterval[] HistoricalInterval
		{
			get
			{
				return this._historicalInterval;
			}
		}
		public PerfCounterInfo[] PerfCounter
		{
			get
			{
				return this._perfCounter;
			}
		}
		public PerformanceManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public PerfProviderSummary QueryPerfProviderSummary(ManagedObjectReference entity)
		{
			PerfProviderSummary result;
			try
			{
				result = (PerfProviderSummary)VIConvert.ToVim(((VimService)this.Client.VimService).QueryPerfProviderSummary((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public PerfMetricId[] QueryAvailablePerfMetric(ManagedObjectReference entity, DateTime? beginTime, DateTime? endTime, int? intervalId)
		{
			PerfMetricId[] result;
			try
			{
				result = (PerfMetricId[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAvailablePerfMetric((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(entity), beginTime.GetValueOrDefault(), beginTime.HasValue, endTime.GetValueOrDefault(), endTime.HasValue, intervalId.GetValueOrDefault(), intervalId.HasValue));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public PerfCounterInfo[] QueryPerfCounter(int[] counterId)
		{
			PerfCounterInfo[] result;
			try
			{
				result = (PerfCounterInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPerfCounter((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), counterId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public PerfCounterInfo[] QueryPerfCounterByLevel(int level)
		{
			PerfCounterInfo[] result;
			try
			{
				result = (PerfCounterInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPerfCounterByLevel((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), level));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public PerfEntityMetricBase[] QueryPerf(PerfQuerySpec[] querySpec)
		{
			PerfEntityMetricBase[] result;
			try
			{
				result = (PerfEntityMetricBase[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPerf((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PerfQuerySpec[])VIConvert.ToWsdlType(querySpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public PerfCompositeMetric QueryPerfComposite(PerfQuerySpec querySpec)
		{
			PerfCompositeMetric result;
			try
			{
				result = (PerfCompositeMetric)VIConvert.ToVim(((VimService)this.Client.VimService).QueryPerfComposite((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PerfQuerySpec)VIConvert.ToWsdlType(querySpec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CreatePerfInterval(PerfInterval intervalId)
		{
			try
			{
				((VimService)this.Client.VimService).CreatePerfInterval((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PerfInterval)VIConvert.ToWsdlType(intervalId));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RemovePerfInterval(int samplePeriod)
		{
			try
			{
				((VimService)this.Client.VimService).RemovePerfInterval((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), samplePeriod);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdatePerfInterval(PerfInterval interval)
		{
			try
			{
				((VimService)this.Client.VimService).UpdatePerfInterval((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PerfInterval)VIConvert.ToWsdlType(interval));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void UpdateCounterLevelMapping(PerformanceManagerCounterLevelMapping[] counterLevelMap)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateCounterLevelMapping((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PerformanceManagerCounterLevelMapping[])VIConvert.ToWsdlType(counterLevelMap));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ResetCounterLevelMapping(int[] counters)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).ResetCounterLevelMapping((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), counters);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public PerformanceManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public PerfProviderSummary QueryPerfProviderSummary(ManagedObjectReference entity)
		{
			PerfProviderSummary result;
			try
			{
				QueryPerfProviderSummaryRequestType queryPerfProviderSummaryRequestType = new QueryPerfProviderSummaryRequestType();
				queryPerfProviderSummaryRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPerfProviderSummaryRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				result = (PerfProviderSummary)VIConvert.ToVim(this.VimServiceProxy.QueryPerfProviderSummary(new QueryPerfProviderSummaryRequest(queryPerfProviderSummaryRequestType)).QueryPerfProviderSummaryResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PerfMetricId[] QueryAvailablePerfMetric(ManagedObjectReference entity, DateTime? beginTime, DateTime? endTime, int? intervalId)
		{
			PerfMetricId[] result;
			try
			{
				QueryAvailablePerfMetricRequestType queryAvailablePerfMetricRequestType = new QueryAvailablePerfMetricRequestType();
				queryAvailablePerfMetricRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryAvailablePerfMetricRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				queryAvailablePerfMetricRequestType.beginTime = beginTime.GetValueOrDefault();
				queryAvailablePerfMetricRequestType.beginTimeSpecified = beginTime.HasValue;
				queryAvailablePerfMetricRequestType.endTime = endTime.GetValueOrDefault();
				queryAvailablePerfMetricRequestType.endTimeSpecified = endTime.HasValue;
				queryAvailablePerfMetricRequestType.intervalId = intervalId.GetValueOrDefault();
				queryAvailablePerfMetricRequestType.intervalIdSpecified = intervalId.HasValue;
				result = (PerfMetricId[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailablePerfMetric(new QueryAvailablePerfMetricRequest(queryAvailablePerfMetricRequestType)).QueryAvailablePerfMetricResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PerfCounterInfo[] QueryPerfCounter(int[] counterId)
		{
			PerfCounterInfo[] result;
			try
			{
				QueryPerfCounterRequestType queryPerfCounterRequestType = new QueryPerfCounterRequestType();
				queryPerfCounterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPerfCounterRequestType.counterId = counterId;
				result = (PerfCounterInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryPerfCounter(new QueryPerfCounterRequest(queryPerfCounterRequestType)).QueryPerfCounterResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PerfCounterInfo[] QueryPerfCounterByLevel(int level)
		{
			PerfCounterInfo[] result;
			try
			{
				QueryPerfCounterByLevelRequestType queryPerfCounterByLevelRequestType = new QueryPerfCounterByLevelRequestType();
				queryPerfCounterByLevelRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPerfCounterByLevelRequestType.level = level;
				result = (PerfCounterInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryPerfCounterByLevel(new QueryPerfCounterByLevelRequest(queryPerfCounterByLevelRequestType)).QueryPerfCounterByLevelResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PerfEntityMetricBase[] QueryPerf(PerfQuerySpec[] querySpec)
		{
			PerfEntityMetricBase[] result;
			try
			{
				QueryPerfRequestType queryPerfRequestType = new QueryPerfRequestType();
				queryPerfRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPerfRequestType.querySpec = (VimApi_65.PerfQuerySpec[])VIConvert.ToWsdlType(querySpec);
				result = (PerfEntityMetricBase[])VIConvert.ToVim(this.VimServiceProxy.QueryPerf(new QueryPerfRequest(queryPerfRequestType)).QueryPerfResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public PerfCompositeMetric QueryPerfComposite(PerfQuerySpec querySpec)
		{
			PerfCompositeMetric result;
			try
			{
				QueryPerfCompositeRequestType queryPerfCompositeRequestType = new QueryPerfCompositeRequestType();
				queryPerfCompositeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPerfCompositeRequestType.querySpec = (VimApi_65.PerfQuerySpec)VIConvert.ToWsdlType(querySpec);
				result = (PerfCompositeMetric)VIConvert.ToVim(this.VimServiceProxy.QueryPerfComposite(new QueryPerfCompositeRequest(queryPerfCompositeRequestType)).QueryPerfCompositeResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CreatePerfInterval(PerfInterval intervalId)
		{
			try
			{
				CreatePerfIntervalRequestType createPerfIntervalRequestType = new CreatePerfIntervalRequestType();
				createPerfIntervalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createPerfIntervalRequestType.intervalId = (VimApi_65.PerfInterval)VIConvert.ToWsdlType(intervalId);
				this.VimServiceProxy.CreatePerfInterval(new CreatePerfIntervalRequest(createPerfIntervalRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemovePerfInterval(int samplePeriod)
		{
			try
			{
				RemovePerfIntervalRequestType removePerfIntervalRequestType = new RemovePerfIntervalRequestType();
				removePerfIntervalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removePerfIntervalRequestType.samplePeriod = samplePeriod;
				this.VimServiceProxy.RemovePerfInterval(new RemovePerfIntervalRequest(removePerfIntervalRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdatePerfInterval(PerfInterval interval)
		{
			try
			{
				UpdatePerfIntervalRequestType updatePerfIntervalRequestType = new UpdatePerfIntervalRequestType();
				updatePerfIntervalRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updatePerfIntervalRequestType.interval = (VimApi_65.PerfInterval)VIConvert.ToWsdlType(interval);
				this.VimServiceProxy.UpdatePerfInterval(new UpdatePerfIntervalRequest(updatePerfIntervalRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UpdateCounterLevelMapping(PerformanceManagerCounterLevelMapping[] counterLevelMap)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UpdateCounterLevelMappingRequestType updateCounterLevelMappingRequestType = new UpdateCounterLevelMappingRequestType();
				updateCounterLevelMappingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateCounterLevelMappingRequestType.counterLevelMap = (VimApi_65.PerformanceManagerCounterLevelMapping[])VIConvert.ToWsdlType(counterLevelMap);
				this.VimServiceProxy.UpdateCounterLevelMapping(new UpdateCounterLevelMappingRequest(updateCounterLevelMappingRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ResetCounterLevelMapping(int[] counters)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ResetCounterLevelMappingRequestType resetCounterLevelMappingRequestType = new ResetCounterLevelMappingRequestType();
				resetCounterLevelMappingRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				resetCounterLevelMappingRequestType.counters = counters;
				this.VimServiceProxy.ResetCounterLevelMapping(new ResetCounterLevelMappingRequest(resetCounterLevelMappingRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

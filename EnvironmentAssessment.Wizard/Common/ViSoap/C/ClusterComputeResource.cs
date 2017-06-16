using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ClusterComputeResource : ComputeResource
	{
		protected ClusterConfigInfo _configuration;
		protected ClusterRecommendation[] _recommendation;
		protected ClusterDrsRecommendation[] _drsRecommendation;
		protected ClusterDrsMigration[] _migrationHistory;
		protected ClusterActionHistory[] _actionHistory;
		protected ClusterDrsFaults[] _drsFault;
		public ClusterConfigInfo Configuration
		{
			get
			{
				return this._configuration;
			}
		}
		public ClusterRecommendation[] Recommendation
		{
			get
			{
				return this._recommendation;
			}
		}
		public ClusterDrsRecommendation[] DrsRecommendation
		{
			get
			{
				return this._drsRecommendation;
			}
		}
		public ClusterDrsMigration[] MigrationHistory
		{
			get
			{
				return this._migrationHistory;
			}
		}
		public ClusterActionHistory[] ActionHistory
		{
			get
			{
				return this._actionHistory;
			}
		}
		public ClusterDrsFaults[] DrsFault
		{
			get
			{
				return this._drsFault;
			}
		}
		public new ClusterComputeResource_LinkedView LinkedView
		{
			get
			{
				return (ClusterComputeResource_LinkedView)this._linkedView;
			}
		}
		public ClusterComputeResource(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ReconfigureCluster_Task(ClusterConfigSpec spec, bool modify)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureCluster_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ClusterConfigSpec)VIConvert.ToWsdlType(spec), modify));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ReconfigureCluster(ClusterConfigSpec spec, bool modify)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ReconfigureCluster_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ClusterConfigSpec)VIConvert.ToWsdlType(spec), modify));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ApplyRecommendation(string key)
		{
			try
			{
				((VimService)this.Client.VimService).ApplyRecommendation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void CancelRecommendation(string key)
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
				((VimService)this.Client.VimService).CancelRecommendation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ClusterHostRecommendation[] RecommendHostsForVm(ManagedObjectReference vm, ManagedObjectReference pool)
		{
			ClusterHostRecommendation[] result;
			try
			{
				result = (ClusterHostRecommendation[])VIConvert.ToVim(((VimService)this.Client.VimService).RecommendHostsForVm((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(vm), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(pool)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference AddHost_Task(HostConnectSpec spec, bool asConnected, ManagedObjectReference resourcePool, string license)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(spec), asConnected, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool), license));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference AddHost(HostConnectSpec spec, bool asConnected, ManagedObjectReference resourcePool, string license)
		{
			ManagedObjectReference result;
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).AddHost_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostConnectSpec)VIConvert.ToWsdlType(spec), asConnected, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool), license));
				result = (ManagedObjectReference)this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ManagedObjectReference MoveInto_Task(ManagedObjectReference[] host)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveInto_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void MoveInto(ManagedObjectReference[] host)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveInto_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference MoveHostInto_Task(ManagedObjectReference host, ManagedObjectReference resourcePool)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveHostInto_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void MoveHostInto(ManagedObjectReference host, ManagedObjectReference resourcePool)
		{
			try
			{
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).MoveHostInto_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(resourcePool)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RefreshRecommendation()
		{
			try
			{
				((VimService)this.Client.VimService).RefreshRecommendation((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ClusterDasAdvancedRuntimeInfo RetrieveDasAdvancedRuntimeInfo()
		{
			ClusterDasAdvancedRuntimeInfo result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ClusterDasAdvancedRuntimeInfo)VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveDasAdvancedRuntimeInfo((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ClusterEnterMaintenanceResult ClusterEnterMaintenanceMode(ManagedObjectReference[] host, OptionValue[] option)
		{
			ClusterEnterMaintenanceResult result;
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
				result = (ClusterEnterMaintenanceResult)VIConvert.ToVim(((VimService)this.Client.VimService).ClusterEnterMaintenanceMode((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference[])VIConvert.ToWsdlType(host), (VimApi_60.OptionValue[])VIConvert.ToWsdlType(option)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

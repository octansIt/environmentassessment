using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class HealthUpdateManager : ViewBase
	{
		public HealthUpdateManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string RegisterHealthUpdateProvider(string name, HealthUpdateInfo[] healthUpdateInfo)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RegisterHealthUpdateProviderRequestType registerHealthUpdateProviderRequestType = new RegisterHealthUpdateProviderRequestType();
				registerHealthUpdateProviderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				registerHealthUpdateProviderRequestType.name = name;
				registerHealthUpdateProviderRequestType.healthUpdateInfo = (VimApi_65.HealthUpdateInfo[])VIConvert.ToWsdlType(healthUpdateInfo);
				returnval = this.VimServiceProxy.RegisterHealthUpdateProvider(new RegisterHealthUpdateProviderRequest(registerHealthUpdateProviderRequestType)).RegisterHealthUpdateProviderResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void UnregisterHealthUpdateProvider(string providerId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				UnregisterHealthUpdateProviderRequestType unregisterHealthUpdateProviderRequestType = new UnregisterHealthUpdateProviderRequestType();
				unregisterHealthUpdateProviderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unregisterHealthUpdateProviderRequestType.providerId = providerId;
				this.VimServiceProxy.UnregisterHealthUpdateProvider(new UnregisterHealthUpdateProviderRequest(unregisterHealthUpdateProviderRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string[] QueryProviderList()
		{
			string[] queryProviderListResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryProviderListRequestType queryProviderListRequestType = new QueryProviderListRequestType();
				queryProviderListRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryProviderListResponse = this.VimServiceProxy.QueryProviderList(new QueryProviderListRequest(queryProviderListRequestType)).QueryProviderListResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryProviderListResponse;
		}
		public bool HasProvider(string id)
		{
			bool returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HasProviderRequestType hasProviderRequestType = new HasProviderRequestType();
				hasProviderRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hasProviderRequestType.id = id;
				returnval = this.VimServiceProxy.HasProvider(new HasProviderRequest(hasProviderRequestType)).HasProviderResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string QueryProviderName(string id)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryProviderNameRequestType queryProviderNameRequestType = new QueryProviderNameRequestType();
				queryProviderNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryProviderNameRequestType.id = id;
				returnval = this.VimServiceProxy.QueryProviderName(new QueryProviderNameRequest(queryProviderNameRequestType)).QueryProviderNameResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public HealthUpdateInfo[] QueryHealthUpdateInfos(string providerId)
		{
			HealthUpdateInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryHealthUpdateInfosRequestType queryHealthUpdateInfosRequestType = new QueryHealthUpdateInfosRequestType();
				queryHealthUpdateInfosRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryHealthUpdateInfosRequestType.providerId = providerId;
				result = (HealthUpdateInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryHealthUpdateInfos(new QueryHealthUpdateInfosRequest(queryHealthUpdateInfosRequestType)).QueryHealthUpdateInfosResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AddMonitoredEntities(string providerId, ManagedObjectReference[] entities)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				AddMonitoredEntitiesRequestType addMonitoredEntitiesRequestType = new AddMonitoredEntitiesRequestType();
				addMonitoredEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addMonitoredEntitiesRequestType.providerId = providerId;
				addMonitoredEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				this.VimServiceProxy.AddMonitoredEntities(new AddMonitoredEntitiesRequest(addMonitoredEntitiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveMonitoredEntities(string providerId, ManagedObjectReference[] entities)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RemoveMonitoredEntitiesRequestType removeMonitoredEntitiesRequestType = new RemoveMonitoredEntitiesRequestType();
				removeMonitoredEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeMonitoredEntitiesRequestType.providerId = providerId;
				removeMonitoredEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				this.VimServiceProxy.RemoveMonitoredEntities(new RemoveMonitoredEntitiesRequest(removeMonitoredEntitiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference[] QueryMonitoredEntities(string providerId)
		{
			ManagedObjectReference[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryMonitoredEntitiesRequestType queryMonitoredEntitiesRequestType = new QueryMonitoredEntitiesRequestType();
				queryMonitoredEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryMonitoredEntitiesRequestType.providerId = providerId;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryMonitoredEntities(new QueryMonitoredEntitiesRequest(queryMonitoredEntitiesRequestType)).QueryMonitoredEntitiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public bool HasMonitoredEntity(string providerId, ManagedObjectReference entity)
		{
			bool returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				HasMonitoredEntityRequestType hasMonitoredEntityRequestType = new HasMonitoredEntityRequestType();
				hasMonitoredEntityRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hasMonitoredEntityRequestType.providerId = providerId;
				hasMonitoredEntityRequestType.entity = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(entity);
				returnval = this.VimServiceProxy.HasMonitoredEntity(new HasMonitoredEntityRequest(hasMonitoredEntityRequestType)).HasMonitoredEntityResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public ManagedObjectReference[] QueryUnmonitoredHosts(string providerId, ManagedObjectReference cluster)
		{
			ManagedObjectReference[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryUnmonitoredHostsRequestType queryUnmonitoredHostsRequestType = new QueryUnmonitoredHostsRequestType();
				queryUnmonitoredHostsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryUnmonitoredHostsRequestType.providerId = providerId;
				queryUnmonitoredHostsRequestType.cluster = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(cluster);
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryUnmonitoredHosts(new QueryUnmonitoredHostsRequest(queryUnmonitoredHostsRequestType)).QueryUnmonitoredHostsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void PostHealthUpdates(string providerId, HealthUpdate[] updates)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				PostHealthUpdatesRequestType postHealthUpdatesRequestType = new PostHealthUpdatesRequestType();
				postHealthUpdatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				postHealthUpdatesRequestType.providerId = providerId;
				postHealthUpdatesRequestType.updates = (VimApi_65.HealthUpdate[])VIConvert.ToWsdlType(updates);
				this.VimServiceProxy.PostHealthUpdates(new PostHealthUpdatesRequest(postHealthUpdatesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HealthUpdate[] QueryHealthUpdates(string providerId)
		{
			HealthUpdate[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryHealthUpdatesRequestType queryHealthUpdatesRequestType = new QueryHealthUpdatesRequestType();
				queryHealthUpdatesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryHealthUpdatesRequestType.providerId = providerId;
				result = (HealthUpdate[])VIConvert.ToVim(this.VimServiceProxy.QueryHealthUpdates(new QueryHealthUpdatesRequest(queryHealthUpdatesRequestType)).QueryHealthUpdatesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public string AddFilter(string providerId, string filterName, string[] infoIds)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				AddFilterRequestType addFilterRequestType = new AddFilterRequestType();
				addFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addFilterRequestType.providerId = providerId;
				addFilterRequestType.filterName = filterName;
				addFilterRequestType.infoIds = infoIds;
				returnval = this.VimServiceProxy.AddFilter(new AddFilterRequest(addFilterRequestType)).AddFilterResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string[] QueryFilterList(string providerId)
		{
			string[] queryFilterListResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryFilterListRequestType queryFilterListRequestType = new QueryFilterListRequestType();
				queryFilterListRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryFilterListRequestType.providerId = providerId;
				queryFilterListResponse = this.VimServiceProxy.QueryFilterList(new QueryFilterListRequest(queryFilterListRequestType)).QueryFilterListResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryFilterListResponse;
		}
		public string QueryFilterName(string filterId)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryFilterNameRequestType queryFilterNameRequestType = new QueryFilterNameRequestType();
				queryFilterNameRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryFilterNameRequestType.filterId = filterId;
				returnval = this.VimServiceProxy.QueryFilterName(new QueryFilterNameRequest(queryFilterNameRequestType)).QueryFilterNameResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string[] QueryFilterInfoIds(string filterId)
		{
			string[] queryFilterInfoIdsResponse;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryFilterInfoIdsRequestType queryFilterInfoIdsRequestType = new QueryFilterInfoIdsRequestType();
				queryFilterInfoIdsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryFilterInfoIdsRequestType.filterId = filterId;
				queryFilterInfoIdsResponse = this.VimServiceProxy.QueryFilterInfoIds(new QueryFilterInfoIdsRequest(queryFilterInfoIdsRequestType)).QueryFilterInfoIdsResponse1;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return queryFilterInfoIdsResponse;
		}
		public ManagedObjectReference[] QueryFilterEntities(string filterId)
		{
			ManagedObjectReference[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				QueryFilterEntitiesRequestType queryFilterEntitiesRequestType = new QueryFilterEntitiesRequestType();
				queryFilterEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryFilterEntitiesRequestType.filterId = filterId;
				result = (ManagedObjectReference[])VIConvert.ToVim(this.VimServiceProxy.QueryFilterEntities(new QueryFilterEntitiesRequest(queryFilterEntitiesRequestType)).QueryFilterEntitiesResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void AddFilterEntities(string filterId, ManagedObjectReference[] entities)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				AddFilterEntitiesRequestType addFilterEntitiesRequestType = new AddFilterEntitiesRequestType();
				addFilterEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				addFilterEntitiesRequestType.filterId = filterId;
				addFilterEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				this.VimServiceProxy.AddFilterEntities(new AddFilterEntitiesRequest(addFilterEntitiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveFilterEntities(string filterId, ManagedObjectReference[] entities)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RemoveFilterEntitiesRequestType removeFilterEntitiesRequestType = new RemoveFilterEntitiesRequestType();
				removeFilterEntitiesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeFilterEntitiesRequestType.filterId = filterId;
				removeFilterEntitiesRequestType.entities = (VimApi_65.ManagedObjectReference[])VIConvert.ToWsdlType(entities);
				this.VimServiceProxy.RemoveFilterEntities(new RemoveFilterEntitiesRequest(removeFilterEntitiesRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RemoveFilter(string filterId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim65);
				RemoveFilterRequestType removeFilterRequestType = new RemoveFilterRequestType();
				removeFilterRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				removeFilterRequestType.filterId = filterId;
				this.VimServiceProxy.RemoveFilter(new RemoveFilterRequest(removeFilterRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class IpPoolManager : ViewBase
	{
		public IpPoolManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public IpPool[] QueryIpPools(ManagedObjectReference dc)
		{
			IpPool[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				QueryIpPoolsRequestType queryIpPoolsRequestType = new QueryIpPoolsRequestType();
				queryIpPoolsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryIpPoolsRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				result = (IpPool[])VIConvert.ToVim(this.VimServiceProxy.QueryIpPools(new QueryIpPoolsRequest(queryIpPoolsRequestType)).QueryIpPoolsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public int CreateIpPool(ManagedObjectReference dc, IpPool pool)
		{
			int returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				CreateIpPoolRequestType createIpPoolRequestType = new CreateIpPoolRequestType();
				createIpPoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createIpPoolRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				createIpPoolRequestType.pool = (VimApi_65.IpPool)VIConvert.ToWsdlType(pool);
				returnval = this.VimServiceProxy.CreateIpPool(new CreateIpPoolRequest(createIpPoolRequestType)).CreateIpPoolResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void UpdateIpPool(ManagedObjectReference dc, IpPool pool)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateIpPoolRequestType updateIpPoolRequestType = new UpdateIpPoolRequestType();
				updateIpPoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateIpPoolRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				updateIpPoolRequestType.pool = (VimApi_65.IpPool)VIConvert.ToWsdlType(pool);
				this.VimServiceProxy.UpdateIpPool(new UpdateIpPoolRequest(updateIpPoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DestroyIpPool(ManagedObjectReference dc, int id, bool force)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				DestroyIpPoolRequestType destroyIpPoolRequestType = new DestroyIpPoolRequestType();
				destroyIpPoolRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				destroyIpPoolRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				destroyIpPoolRequestType.id = id;
				destroyIpPoolRequestType.force = force;
				this.VimServiceProxy.DestroyIpPool(new DestroyIpPoolRequest(destroyIpPoolRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string AllocateIpv4Address(ManagedObjectReference dc, int poolId, string allocationId)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				AllocateIpv4AddressRequestType allocateIpv4AddressRequestType = new AllocateIpv4AddressRequestType();
				allocateIpv4AddressRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				allocateIpv4AddressRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				allocateIpv4AddressRequestType.poolId = poolId;
				allocateIpv4AddressRequestType.allocationId = allocationId;
				returnval = this.VimServiceProxy.AllocateIpv4Address(new AllocateIpv4AddressRequest(allocateIpv4AddressRequestType)).AllocateIpv4AddressResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public string AllocateIpv6Address(ManagedObjectReference dc, int poolId, string allocationId)
		{
			string returnval;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				AllocateIpv6AddressRequestType allocateIpv6AddressRequestType = new AllocateIpv6AddressRequestType();
				allocateIpv6AddressRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				allocateIpv6AddressRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				allocateIpv6AddressRequestType.poolId = poolId;
				allocateIpv6AddressRequestType.allocationId = allocationId;
				returnval = this.VimServiceProxy.AllocateIpv6Address(new AllocateIpv6AddressRequest(allocateIpv6AddressRequestType)).AllocateIpv6AddressResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public void ReleaseIpAllocation(ManagedObjectReference dc, int poolId, string allocationId)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ReleaseIpAllocationRequestType releaseIpAllocationRequestType = new ReleaseIpAllocationRequestType();
				releaseIpAllocationRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				releaseIpAllocationRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				releaseIpAllocationRequestType.poolId = poolId;
				releaseIpAllocationRequestType.allocationId = allocationId;
				this.VimServiceProxy.ReleaseIpAllocation(new ReleaseIpAllocationRequest(releaseIpAllocationRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public IpPoolManagerIpAllocation[] QueryIPAllocations(ManagedObjectReference dc, int poolId, string extensionKey)
		{
			IpPoolManagerIpAllocation[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				QueryIPAllocationsRequestType queryIPAllocationsRequestType = new QueryIPAllocationsRequestType();
				queryIPAllocationsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryIPAllocationsRequestType.dc = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(dc);
				queryIPAllocationsRequestType.poolId = poolId;
				queryIPAllocationsRequestType.extensionKey = extensionKey;
				result = (IpPoolManagerIpAllocation[])VIConvert.ToVim(this.VimServiceProxy.QueryIPAllocations(new QueryIPAllocationsRequest(queryIPAllocationsRequestType)).QueryIPAllocationsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

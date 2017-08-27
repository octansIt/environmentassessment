using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class IscsiManager : ViewBase
	{
		public IscsiManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public IscsiStatus QueryVnicStatus(string vnicDevice)
		{
			IscsiStatus result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryVnicStatusRequestType queryVnicStatusRequestType = new QueryVnicStatusRequestType();
				queryVnicStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryVnicStatusRequestType.vnicDevice = vnicDevice;
				result = (IscsiStatus)VIConvert.ToVim(this.VimServiceProxy.QueryVnicStatus(new QueryVnicStatusRequest(queryVnicStatusRequestType)).QueryVnicStatusResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public IscsiStatus QueryPnicStatus(string pnicDevice)
		{
			IscsiStatus result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryPnicStatusRequestType queryPnicStatusRequestType = new QueryPnicStatusRequestType();
				queryPnicStatusRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPnicStatusRequestType.pnicDevice = pnicDevice;
				result = (IscsiStatus)VIConvert.ToVim(this.VimServiceProxy.QueryPnicStatus(new QueryPnicStatusRequest(queryPnicStatusRequestType)).QueryPnicStatusResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public IscsiPortInfo[] QueryBoundVnics(string iScsiHbaName)
		{
			IscsiPortInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryBoundVnicsRequestType queryBoundVnicsRequestType = new QueryBoundVnicsRequestType();
				queryBoundVnicsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryBoundVnicsRequestType.iScsiHbaName = iScsiHbaName;
				result = (IscsiPortInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryBoundVnics(new QueryBoundVnicsRequest(queryBoundVnicsRequestType)).QueryBoundVnicsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public IscsiPortInfo[] QueryCandidateNics(string iScsiHbaName)
		{
			IscsiPortInfo[] result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryCandidateNicsRequestType queryCandidateNicsRequestType = new QueryCandidateNicsRequestType();
				queryCandidateNicsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryCandidateNicsRequestType.iScsiHbaName = iScsiHbaName;
				result = (IscsiPortInfo[])VIConvert.ToVim(this.VimServiceProxy.QueryCandidateNics(new QueryCandidateNicsRequest(queryCandidateNicsRequestType)).QueryCandidateNicsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void BindVnic(string iScsiHbaName, string vnicDevice)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				BindVnicRequestType bindVnicRequestType = new BindVnicRequestType();
				bindVnicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				bindVnicRequestType.iScsiHbaName = iScsiHbaName;
				bindVnicRequestType.vnicDevice = vnicDevice;
				this.VimServiceProxy.BindVnic(new BindVnicRequest(bindVnicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void UnbindVnic(string iScsiHbaName, string vnicDevice, bool force)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				UnbindVnicRequestType unbindVnicRequestType = new UnbindVnicRequestType();
				unbindVnicRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				unbindVnicRequestType.iScsiHbaName = iScsiHbaName;
				unbindVnicRequestType.vnicDevice = vnicDevice;
				unbindVnicRequestType.force = force;
				this.VimServiceProxy.UnbindVnic(new UnbindVnicRequest(unbindVnicRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public IscsiMigrationDependency QueryMigrationDependencies(string[] pnicDevice)
		{
			IscsiMigrationDependency result;
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				QueryMigrationDependenciesRequestType queryMigrationDependenciesRequestType = new QueryMigrationDependenciesRequestType();
				queryMigrationDependenciesRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryMigrationDependenciesRequestType.pnicDevice = pnicDevice;
				result = (IscsiMigrationDependency)VIConvert.ToVim(this.VimServiceProxy.QueryMigrationDependencies(new QueryMigrationDependenciesRequest(queryMigrationDependenciesRequestType)).QueryMigrationDependenciesResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

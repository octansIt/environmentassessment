using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePlanningManager : ViewBase
	{
		public ResourcePlanningManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DatabaseSizeEstimate EstimateDatabaseSize(DatabaseSizeParam dbSizeParam)
		{
			DatabaseSizeEstimate result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				EstimateDatabaseSizeRequestType estimateDatabaseSizeRequestType = new EstimateDatabaseSizeRequestType();
				estimateDatabaseSizeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				estimateDatabaseSizeRequestType.dbSizeParam = (VimApi_65.DatabaseSizeParam)VIConvert.ToWsdlType(dbSizeParam);
				result = (DatabaseSizeEstimate)VIConvert.ToVim(this.VimServiceProxy.EstimateDatabaseSize(new EstimateDatabaseSizeRequest(estimateDatabaseSizeRequestType)).EstimateDatabaseSizeResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}

using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ResourcePlanningManager : ViewBase
	{
		public ResourcePlanningManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public DatabaseSizeEstimate EstimateDatabaseSize(DatabaseSizeParam dbSizeParam)
		{
			DatabaseSizeEstimate result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (DatabaseSizeEstimate)VIConvert.ToVim(((VimService)this.Client.VimService).EstimateDatabaseSize((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.DatabaseSizeParam)VIConvert.ToWsdlType(dbSizeParam)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

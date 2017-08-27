
using System.ServiceModel;
using VimApi_65;namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterProfile : Profile
	{
		public new ClusterProfile_LinkedView LinkedView
		{
			get
			{
				return (ClusterProfile_LinkedView)this._linkedView;
			}
		}
		public ClusterProfile(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateClusterProfile(ClusterProfileConfigSpec config)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim4);
				UpdateClusterProfileRequestType updateClusterProfileRequestType = new UpdateClusterProfileRequestType();
				updateClusterProfileRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				updateClusterProfileRequestType.config = (VimApi_65.ClusterProfileConfigSpec)VIConvert.ToWsdlType(config);
				this.VimServiceProxy.UpdateClusterProfile(new UpdateClusterProfileRequest(updateClusterProfileRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

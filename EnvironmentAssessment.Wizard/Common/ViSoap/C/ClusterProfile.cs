using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public ClusterProfile(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void UpdateClusterProfile(ClusterProfileConfigSpec config)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).UpdateClusterProfile((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ClusterProfileConfigSpec)VIConvert.ToWsdlType(config));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

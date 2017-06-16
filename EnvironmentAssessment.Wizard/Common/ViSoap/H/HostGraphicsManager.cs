using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostGraphicsManager : ExtensibleManagedObject
	{
		protected HostGraphicsInfo[] _graphicsInfo;
		public HostGraphicsInfo[] GraphicsInfo
		{
			get
			{
				return this._graphicsInfo;
			}
		}
		public HostGraphicsManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void RefreshGraphicsManager()
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
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				((VimService)this.Client.VimService).RefreshGraphicsManager((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public bool IsSharedGraphicsActive()
		{
			bool result;
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
				if (this.Client.Version == VimVersion.Vim50)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = ((VimService)this.Client.VimService).IsSharedGraphicsActive((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

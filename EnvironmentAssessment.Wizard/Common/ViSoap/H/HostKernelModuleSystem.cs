using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostKernelModuleSystem : ViewBase
	{
		public HostKernelModuleSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public KernelModuleInfo[] QueryModules()
		{
			KernelModuleInfo[] result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (KernelModuleInfo[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryModules((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void UpdateModuleOptionString(string name, string options)
		{
			try
			{
				((VimService)this.Client.VimService).UpdateModuleOptionString((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name, options);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public string QueryConfiguredModuleOptionString(string name)
		{
			string result;
			try
			{
				result = ((VimService)this.Client.VimService).QueryConfiguredModuleOptionString((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), name);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

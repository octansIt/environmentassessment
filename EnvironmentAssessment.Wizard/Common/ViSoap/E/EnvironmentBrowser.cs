using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class EnvironmentBrowser : ViewBase
	{
		protected ManagedObjectReference _datastoreBrowser;
		protected EnvironmentBrowser_LinkedView _linkedView;
		public ManagedObjectReference DatastoreBrowser
		{
			get
			{
				return this._datastoreBrowser;
			}
		}
		public EnvironmentBrowser_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public EnvironmentBrowser(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public VirtualMachineConfigOptionDescriptor[] QueryConfigOptionDescriptor()
		{
			VirtualMachineConfigOptionDescriptor[] result;
			try
			{
				result = (VirtualMachineConfigOptionDescriptor[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryConfigOptionDescriptor((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public VirtualMachineConfigOption QueryConfigOption(string key, ManagedObjectReference host)
		{
			VirtualMachineConfigOption result;
			try
			{
				result = (VirtualMachineConfigOption)VIConvert.ToVim(((VimService)this.Client.VimService).QueryConfigOption((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), key, (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ConfigTarget QueryConfigTarget(ManagedObjectReference host)
		{
			ConfigTarget result;
			try
			{
				result = (ConfigTarget)VIConvert.ToVim(((VimService)this.Client.VimService).QueryConfigTarget((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostCapability QueryTargetCapabilities(ManagedObjectReference host)
		{
			HostCapability result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (HostCapability)VIConvert.ToVim(((VimService)this.Client.VimService).QueryTargetCapabilities((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(host)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

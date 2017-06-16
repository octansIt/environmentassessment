using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class PropertyCollector : ViewBase
	{
		protected ManagedObjectReference[] _filter;
		protected PropertyCollector_LinkedView _linkedView;
		public ManagedObjectReference[] Filter
		{
			get
			{
				return this._filter;
			}
		}
		public PropertyCollector_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public PropertyCollector(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference CreateFilter(PropertyFilterSpec spec, bool partialUpdates)
		{
			ManagedObjectReference result;
			try
			{
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreateFilter((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PropertyFilterSpec)VIConvert.ToWsdlType(spec), partialUpdates));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public ObjectContent[] RetrieveProperties(PropertyFilterSpec[] specSet)
		{
			ObjectContent[] result;
			try
			{
				result = (ObjectContent[])VIConvert.ToVim(((VimService)this.Client.VimService).RetrieveProperties((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PropertyFilterSpec[])VIConvert.ToWsdlType(specSet)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UpdateSet CheckForUpdates(string version)
		{
			UpdateSet result;
			try
			{
				result = (UpdateSet)VIConvert.ToVim(((VimService)this.Client.VimService).CheckForUpdates((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), version));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public UpdateSet WaitForUpdates(string version)
		{
			UpdateSet result;
			try
			{
				result = (UpdateSet)VIConvert.ToVim(((VimService)this.Client.VimService).WaitForUpdates((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), version));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CancelWaitForUpdates()
		{
			try
			{
				((VimService)this.Client.VimService).CancelWaitForUpdates((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public UpdateSet WaitForUpdatesEx(string version, WaitOptions options)
		{
			UpdateSet result;
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
				result = (UpdateSet)VIConvert.ToVim(((VimService)this.Client.VimService).WaitForUpdatesEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), version, (VimApi_60.WaitOptions)VIConvert.ToWsdlType(options)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public RetrieveResult RetrievePropertiesEx(PropertyFilterSpec[] specSet, RetrieveOptions options)
		{
			RetrieveResult result;
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
				result = (RetrieveResult)VIConvert.ToVim(((VimService)this.Client.VimService).RetrievePropertiesEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.PropertyFilterSpec[])VIConvert.ToWsdlType(specSet), (VimApi_60.RetrieveOptions)VIConvert.ToWsdlType(options)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public RetrieveResult ContinueRetrievePropertiesEx(string token)
		{
			RetrieveResult result;
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
				result = (RetrieveResult)VIConvert.ToVim(((VimService)this.Client.VimService).ContinueRetrievePropertiesEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), token));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CancelRetrievePropertiesEx(string token)
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
				((VimService)this.Client.VimService).CancelRetrievePropertiesEx((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), token);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public ManagedObjectReference CreatePropertyCollector()
		{
			ManagedObjectReference result;
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
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).CreatePropertyCollector((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void DestroyPropertyCollector()
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
				((VimService)this.Client.VimService).DestroyPropertyCollector((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

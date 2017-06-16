using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class SimpleCommand : ViewBase
	{
		protected SimpleCommandEncoding _encodingType;
		protected ServiceManagerServiceInfo _entity;
		public SimpleCommandEncoding EncodingType
		{
			get
			{
				return this._encodingType;
			}
		}
		public ServiceManagerServiceInfo Entity
		{
			get
			{
				return this._entity;
			}
		}
		public SimpleCommand(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string ExecuteSimpleCommand(string[] arguments)
		{
			string result;
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
				result = ((VimService)this.Client.VimService).ExecuteSimpleCommand((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), arguments);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
	}
}

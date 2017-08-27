using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
		public SimpleCommand(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public string ExecuteSimpleCommand(string[] arguments)
		{
			string returnval;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim51);
				ExecuteSimpleCommandRequestType executeSimpleCommandRequestType = new ExecuteSimpleCommandRequestType();
				executeSimpleCommandRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				executeSimpleCommandRequestType.arguments = arguments;
				returnval = this.VimServiceProxy.ExecuteSimpleCommand(new ExecuteSimpleCommandRequest(executeSimpleCommandRequestType)).ExecuteSimpleCommandResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
	}
}

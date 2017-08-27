using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class View : ViewBase
	{
		public View(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void DestroyView()
		{
			try
			{
				DestroyViewRequestType destroyViewRequestType = new DestroyViewRequestType();
				destroyViewRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyView(new DestroyViewRequest(destroyViewRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

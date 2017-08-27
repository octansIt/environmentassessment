using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HistoryCollector : ViewBase
	{
		protected object _filter;
		public object Filter
		{
			get
			{
				return this._filter;
			}
		}
		public HistoryCollector(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void SetCollectorPageSize(int maxCount)
		{
			try
			{
				SetCollectorPageSizeRequestType setCollectorPageSizeRequestType = new SetCollectorPageSizeRequestType();
				setCollectorPageSizeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setCollectorPageSizeRequestType.maxCount = maxCount;
				this.VimServiceProxy.SetCollectorPageSize(new SetCollectorPageSizeRequest(setCollectorPageSizeRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void RewindCollector()
		{
			try
			{
				RewindCollectorRequestType rewindCollectorRequestType = new RewindCollectorRequestType();
				rewindCollectorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.RewindCollector(new RewindCollectorRequest(rewindCollectorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void ResetCollector()
		{
			try
			{
				ResetCollectorRequestType resetCollectorRequestType = new ResetCollectorRequestType();
				resetCollectorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.ResetCollector(new ResetCollectorRequest(resetCollectorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void DestroyCollector()
		{
			try
			{
				DestroyCollectorRequestType destroyCollectorRequestType = new DestroyCollectorRequestType();
				destroyCollectorRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.DestroyCollector(new DestroyCollectorRequest(destroyCollectorRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

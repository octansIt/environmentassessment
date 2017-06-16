using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
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
		public HistoryCollector(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public void SetCollectorPageSize(int maxCount)
		{
			try
			{
				((VimService)this.Client.VimService).SetCollectorPageSize((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), maxCount);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void RewindCollector()
		{
			try
			{
				((VimService)this.Client.VimService).RewindCollector((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void ResetCollector()
		{
			try
			{
				((VimService)this.Client.VimService).ResetCollector((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public void DestroyCollector()
		{
			try
			{
				((VimService)this.Client.VimService).DestroyCollector((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

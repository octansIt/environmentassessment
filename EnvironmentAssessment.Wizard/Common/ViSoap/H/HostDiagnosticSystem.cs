using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiagnosticSystem : ViewBase
	{
		protected HostDiagnosticPartition _activePartition;
		public HostDiagnosticPartition ActivePartition
		{
			get
			{
				return this._activePartition;
			}
		}
		public HostDiagnosticSystem(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public HostDiagnosticPartition[] QueryAvailablePartition()
		{
			HostDiagnosticPartition[] result;
			try
			{
				result = (HostDiagnosticPartition[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryAvailablePartition((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void SelectActivePartition(HostScsiDiskPartition partition)
		{
			try
			{
				((VimService)this.Client.VimService).SelectActivePartition((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostScsiDiskPartition)VIConvert.ToWsdlType(partition));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
		public HostDiagnosticPartitionCreateOption[] QueryPartitionCreateOptions(string storageType, string diagnosticType)
		{
			HostDiagnosticPartitionCreateOption[] result;
			try
			{
				result = (HostDiagnosticPartitionCreateOption[])VIConvert.ToVim(((VimService)this.Client.VimService).QueryPartitionCreateOptions((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), storageType, diagnosticType));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public HostDiagnosticPartitionCreateDescription QueryPartitionCreateDesc(string diskUuid, string diagnosticType)
		{
			HostDiagnosticPartitionCreateDescription result;
			try
			{
				result = (HostDiagnosticPartitionCreateDescription)VIConvert.ToVim(((VimService)this.Client.VimService).QueryPartitionCreateDesc((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), diskUuid, diagnosticType));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void CreateDiagnosticPartition(HostDiagnosticPartitionCreateSpec spec)
		{
			try
			{
				((VimService)this.Client.VimService).CreateDiagnosticPartition((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostDiagnosticPartitionCreateSpec)VIConvert.ToWsdlType(spec));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}

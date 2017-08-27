using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				QueryAvailablePartitionRequestType queryAvailablePartitionRequestType = new QueryAvailablePartitionRequestType();
				queryAvailablePartitionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (HostDiagnosticPartition[])VIConvert.ToVim(this.VimServiceProxy.QueryAvailablePartition(new QueryAvailablePartitionRequest(queryAvailablePartitionRequestType)).QueryAvailablePartitionResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void SelectActivePartition(HostScsiDiskPartition partition)
		{
			try
			{
				SelectActivePartitionRequestType selectActivePartitionRequestType = new SelectActivePartitionRequestType();
				selectActivePartitionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				selectActivePartitionRequestType.partition = (VimApi_65.HostScsiDiskPartition)VIConvert.ToWsdlType(partition);
				this.VimServiceProxy.SelectActivePartition(new SelectActivePartitionRequest(selectActivePartitionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public HostDiagnosticPartitionCreateOption[] QueryPartitionCreateOptions(string storageType, string diagnosticType)
		{
			HostDiagnosticPartitionCreateOption[] result;
			try
			{
				QueryPartitionCreateOptionsRequestType queryPartitionCreateOptionsRequestType = new QueryPartitionCreateOptionsRequestType();
				queryPartitionCreateOptionsRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPartitionCreateOptionsRequestType.storageType = storageType;
				queryPartitionCreateOptionsRequestType.diagnosticType = diagnosticType;
				result = (HostDiagnosticPartitionCreateOption[])VIConvert.ToVim(this.VimServiceProxy.QueryPartitionCreateOptions(new QueryPartitionCreateOptionsRequest(queryPartitionCreateOptionsRequestType)).QueryPartitionCreateOptionsResponse1);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostDiagnosticPartitionCreateDescription QueryPartitionCreateDesc(string diskUuid, string diagnosticType)
		{
			HostDiagnosticPartitionCreateDescription result;
			try
			{
				QueryPartitionCreateDescRequestType queryPartitionCreateDescRequestType = new QueryPartitionCreateDescRequestType();
				queryPartitionCreateDescRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				queryPartitionCreateDescRequestType.diskUuid = diskUuid;
				queryPartitionCreateDescRequestType.diagnosticType = diagnosticType;
				result = (HostDiagnosticPartitionCreateDescription)VIConvert.ToVim(this.VimServiceProxy.QueryPartitionCreateDesc(new QueryPartitionCreateDescRequest(queryPartitionCreateDescRequestType)).QueryPartitionCreateDescResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void CreateDiagnosticPartition(HostDiagnosticPartitionCreateSpec spec)
		{
			try
			{
				CreateDiagnosticPartitionRequestType createDiagnosticPartitionRequestType = new CreateDiagnosticPartitionRequestType();
				createDiagnosticPartitionRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createDiagnosticPartitionRequestType.spec = (VimApi_65.HostDiagnosticPartitionCreateSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.CreateDiagnosticPartition(new CreateDiagnosticPartitionRequest(createDiagnosticPartitionRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}

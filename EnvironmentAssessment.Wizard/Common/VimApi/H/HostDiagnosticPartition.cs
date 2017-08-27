namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiagnosticPartition : DynamicData
	{
		protected string _storageType;
		protected string _diagnosticType;
		protected int _slots;
		protected HostScsiDiskPartition _id;
		public string StorageType
		{
			get
			{
				return this._storageType;
			}
			set
			{
				this._storageType = value;
			}
		}
		public string DiagnosticType
		{
			get
			{
				return this._diagnosticType;
			}
			set
			{
				this._diagnosticType = value;
			}
		}
		public int Slots
		{
			get
			{
				return this._slots;
			}
			set
			{
				this._slots = value;
			}
		}
		public HostScsiDiskPartition Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
	}
}

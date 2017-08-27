namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDiagnosticPartitionCreateDescription : DynamicData
	{
		protected HostDiskPartitionLayout _layout;
		protected string _diskUuid;
		protected HostDiagnosticPartitionCreateSpec _spec;
		public HostDiskPartitionLayout Layout
		{
			get
			{
				return this._layout;
			}
			set
			{
				this._layout = value;
			}
		}
		public string DiskUuid
		{
			get
			{
				return this._diskUuid;
			}
			set
			{
				this._diskUuid = value;
			}
		}
		public HostDiagnosticPartitionCreateSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}

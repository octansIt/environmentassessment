namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDiskPartitionInfo : DynamicData
	{
		protected string _deviceName;
		protected HostDiskPartitionSpec _spec;
		protected HostDiskPartitionLayout _layout;
		public string DeviceName
		{
			get
			{
				return this._deviceName;
			}
			set
			{
				this._deviceName = value;
			}
		}
		public HostDiskPartitionSpec Spec
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
	}
}

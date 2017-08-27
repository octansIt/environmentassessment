namespace EnvironmentAssessment.Common.VimApi
{
	public class HostScsiTopologyInterface : DynamicData
	{
		protected string _key;
		protected string _adapter;
		protected HostScsiTopologyTarget[] _target;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
		public HostScsiTopologyTarget[] Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
	}
}

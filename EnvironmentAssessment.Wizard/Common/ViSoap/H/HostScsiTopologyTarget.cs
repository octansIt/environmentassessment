namespace EnvironmentAssessment.Common.VISoap
{
    public class HostScsiTopologyTarget : DynamicData
	{
		protected string _key;
		protected int _target;
		protected HostScsiTopologyLun[] _lun;
		protected HostTargetTransport _transport;
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
		public int Target
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
		public HostScsiTopologyLun[] Lun
		{
			get
			{
				return this._lun;
			}
			set
			{
				this._lun = value;
			}
		}
		public HostTargetTransport Transport
		{
			get
			{
				return this._transport;
			}
			set
			{
				this._transport = value;
			}
		}
	}
}

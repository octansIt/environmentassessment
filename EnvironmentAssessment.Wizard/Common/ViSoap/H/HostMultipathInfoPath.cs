namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMultipathInfoPath : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string _pathState;
		protected string _state;
		protected bool? _isWorkingPath;
		protected string _adapter;
		protected string _lun;
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string PathState
		{
			get
			{
				return this._pathState;
			}
			set
			{
				this._pathState = value;
			}
		}
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public bool? IsWorkingPath
		{
			get
			{
				return this._isWorkingPath;
			}
			set
			{
				this._isWorkingPath = value;
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
		public string Lun
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

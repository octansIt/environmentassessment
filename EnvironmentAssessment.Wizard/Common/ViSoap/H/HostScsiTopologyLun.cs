namespace EnvironmentAssessment.Common.VISoap
{
    public class HostScsiTopologyLun : DynamicData
	{
		protected string _key;
		protected int _lun;
		protected string _scsiLun;
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
		public int Lun
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
		public string ScsiLun
		{
			get
			{
				return this._scsiLun;
			}
			set
			{
				this._scsiLun = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSHostLocalPortInfo : DynamicData
	{
		protected string _switchUuid;
		protected string _portKey;
		protected DVPortSetting _setting;
		protected string _vnic;
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
		public DVPortSetting Setting
		{
			get
			{
				return this._setting;
			}
			set
			{
				this._setting = value;
			}
		}
		public string Vnic
		{
			get
			{
				return this._vnic;
			}
			set
			{
				this._vnic = value;
			}
		}
	}
}

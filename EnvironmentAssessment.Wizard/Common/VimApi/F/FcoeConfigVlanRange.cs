namespace EnvironmentAssessment.Common.VimApi
{
	public class FcoeConfigVlanRange : DynamicData
	{
		protected int _vlanLow;
		protected int _vlanHigh;
		public int VlanLow
		{
			get
			{
				return this._vlanLow;
			}
			set
			{
				this._vlanLow = value;
			}
		}
		public int VlanHigh
		{
			get
			{
				return this._vlanHigh;
			}
			set
			{
				this._vlanHigh = value;
			}
		}
	}
}

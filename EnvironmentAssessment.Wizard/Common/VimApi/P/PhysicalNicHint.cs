namespace EnvironmentAssessment.Common.VimApi
{
	public class PhysicalNicHint : DynamicData
	{
		protected int? _vlanId;
		public int? VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
			}
		}
	}
}

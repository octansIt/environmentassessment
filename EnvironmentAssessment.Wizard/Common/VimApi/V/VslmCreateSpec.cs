namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmCreateSpec : DynamicData
	{
		protected string _name;
		protected VslmCreateSpecBackingSpec _backingSpec;
		protected long _capacityInMB;
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
		public VslmCreateSpecBackingSpec BackingSpec
		{
			get
			{
				return this._backingSpec;
			}
			set
			{
				this._backingSpec = value;
			}
		}
		public long CapacityInMB
		{
			get
			{
				return this._capacityInMB;
			}
			set
			{
				this._capacityInMB = value;
			}
		}
	}
}

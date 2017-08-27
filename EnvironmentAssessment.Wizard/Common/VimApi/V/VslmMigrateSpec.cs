namespace EnvironmentAssessment.Common.VimApi
{
	public class VslmMigrateSpec : DynamicData
	{
		protected VslmCreateSpecBackingSpec _backingSpec;
		protected bool? _consolidate;
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
		public bool? Consolidate
		{
			get
			{
				return this._consolidate;
			}
			set
			{
				this._consolidate = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSPolicy : DynamicData
	{
		protected bool? _autoPreInstallAllowed;
		protected bool? _autoUpgradeAllowed;
		protected bool? _partialUpgradeAllowed;
		public bool? AutoPreInstallAllowed
		{
			get
			{
				return this._autoPreInstallAllowed;
			}
			set
			{
				this._autoPreInstallAllowed = value;
			}
		}
		public bool? AutoUpgradeAllowed
		{
			get
			{
				return this._autoUpgradeAllowed;
			}
			set
			{
				this._autoUpgradeAllowed = value;
			}
		}
		public bool? PartialUpgradeAllowed
		{
			get
			{
				return this._partialUpgradeAllowed;
			}
			set
			{
				this._partialUpgradeAllowed = value;
			}
		}
	}
}

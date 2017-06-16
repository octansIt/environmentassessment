namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasMetroHASettings : DynamicData
	{
		protected bool? _enabled;
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
	}
}

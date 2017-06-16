namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDrsFaults : DynamicData
	{
		protected string _reason;
		protected ClusterDrsFaultsFaultsByVm[] _faultsByVm;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public ClusterDrsFaultsFaultsByVm[] FaultsByVm
		{
			get
			{
				return this._faultsByVm;
			}
			set
			{
				this._faultsByVm = value;
			}
		}
	}
}

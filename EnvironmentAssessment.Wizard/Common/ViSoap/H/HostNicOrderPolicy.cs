namespace EnvironmentAssessment.Common.VISoap
{
    public class HostNicOrderPolicy : DynamicData
	{
		protected string[] _activeNic;
		protected string[] _standbyNic;
		public string[] ActiveNic
		{
			get
			{
				return this._activeNic;
			}
			set
			{
				this._activeNic = value;
			}
		}
		public string[] StandbyNic
		{
			get
			{
				return this._standbyNic;
			}
			set
			{
				this._standbyNic = value;
			}
		}
	}
}

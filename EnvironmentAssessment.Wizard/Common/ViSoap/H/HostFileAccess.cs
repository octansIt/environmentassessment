namespace EnvironmentAssessment.Common.VISoap
{
    public class HostFileAccess : DynamicData
	{
		protected string _who;
		protected string _what;
		public string Who
		{
			get
			{
				return this._who;
			}
			set
			{
				this._who = value;
			}
		}
		public string What
		{
			get
			{
				return this._what;
			}
			set
			{
				this._what = value;
			}
		}
	}
}

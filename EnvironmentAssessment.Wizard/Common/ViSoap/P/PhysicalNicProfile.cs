namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicProfile : ApplyProfile
	{
		protected string _key;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
	}
}

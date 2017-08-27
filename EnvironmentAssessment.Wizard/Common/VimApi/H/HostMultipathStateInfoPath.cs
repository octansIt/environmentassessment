namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMultipathStateInfoPath : DynamicData
	{
		protected string _name;
		protected string _pathState;
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
		public string PathState
		{
			get
			{
				return this._pathState;
			}
			set
			{
				this._pathState = value;
			}
		}
	}
}

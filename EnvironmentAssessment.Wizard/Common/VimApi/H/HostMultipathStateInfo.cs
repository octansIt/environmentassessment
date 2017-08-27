namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMultipathStateInfo : DynamicData
	{
		protected HostMultipathStateInfoPath[] _path;
		public HostMultipathStateInfoPath[] Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
	}
}

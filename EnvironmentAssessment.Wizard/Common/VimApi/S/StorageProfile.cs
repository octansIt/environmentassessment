namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageProfile : ApplyProfile
	{
		protected NasStorageProfile[] _nasStorage;
		public NasStorageProfile[] NasStorage
		{
			get
			{
				return this._nasStorage;
			}
			set
			{
				this._nasStorage = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegKeyNameSpec : DynamicData
	{
		protected string _registryPath;
		protected string _wowBitness;
		public string RegistryPath
		{
			get
			{
				return this._registryPath;
			}
			set
			{
				this._registryPath = value;
			}
		}
		public string WowBitness
		{
			get
			{
				return this._wowBitness;
			}
			set
			{
				this._wowBitness = value;
			}
		}
	}
}

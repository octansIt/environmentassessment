namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVMotionConfig : DynamicData
	{
		protected string _vmotionNicKey;
		protected bool _enabled;
		public string VmotionNicKey
		{
			get
			{
				return this._vmotionNicKey;
			}
			set
			{
				this._vmotionNicKey = value;
			}
		}
		public bool Enabled
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

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNasVolumeConfig : DynamicData
	{
		protected string _changeOperation;
		protected HostNasVolumeSpec _spec;
		public string ChangeOperation
		{
			get
			{
				return this._changeOperation;
			}
			set
			{
				this._changeOperation = value;
			}
		}
		public HostNasVolumeSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
	}
}

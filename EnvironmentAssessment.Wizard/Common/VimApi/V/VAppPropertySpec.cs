namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppPropertySpec : ArrayUpdateSpec
	{
		protected VAppPropertyInfo _info;
		public VAppPropertyInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppProductSpec : ArrayUpdateSpec
	{
		protected VAppProductInfo _info;
		public VAppProductInfo Info
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

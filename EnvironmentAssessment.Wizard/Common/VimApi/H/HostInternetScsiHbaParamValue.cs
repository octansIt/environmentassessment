namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaParamValue : OptionValue
	{
		protected bool? _isInherited;
		public bool? IsInherited
		{
			get
			{
				return this._isInherited;
			}
			set
			{
				this._isInherited = value;
			}
		}
	}
}

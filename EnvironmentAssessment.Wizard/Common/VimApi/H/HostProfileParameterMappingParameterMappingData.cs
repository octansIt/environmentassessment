namespace EnvironmentAssessment.Common.VimApi
{
    public class HostProfileParameterMappingParameterMappingData : HostProfileMappingData
	{
		protected bool _isKey;
		public bool IsKey
		{
			get
			{
				return this._isKey;
			}
			set
			{
				this._isKey = value;
			}
		}
	}
}

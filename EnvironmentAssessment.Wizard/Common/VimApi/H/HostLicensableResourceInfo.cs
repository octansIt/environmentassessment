namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLicensableResourceInfo : DynamicData
	{
		protected KeyAnyValue[] _resource;
		public KeyAnyValue[] Resource
		{
			get
			{
				return this._resource;
			}
			set
			{
				this._resource = value;
			}
		}
	}
}

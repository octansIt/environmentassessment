namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPatchManagerResult : DynamicData
	{
		protected string _version;
		protected HostPatchManagerStatus[] _status;
		protected string _xmlResult;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public HostPatchManagerStatus[] Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string XmlResult
		{
			get
			{
				return this._xmlResult;
			}
			set
			{
				this._xmlResult = value;
			}
		}
	}
}

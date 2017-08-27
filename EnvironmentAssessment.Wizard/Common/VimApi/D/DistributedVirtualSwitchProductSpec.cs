namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchProductSpec : DynamicData
	{
		protected string _name;
		protected string _vendor;
		protected string _version;
		protected string _build;
		protected string _forwardingClass;
		protected string _bundleId;
		protected string _bundleUrl;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
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
		public string Build
		{
			get
			{
				return this._build;
			}
			set
			{
				this._build = value;
			}
		}
		public string ForwardingClass
		{
			get
			{
				return this._forwardingClass;
			}
			set
			{
				this._forwardingClass = value;
			}
		}
		public string BundleId
		{
			get
			{
				return this._bundleId;
			}
			set
			{
				this._bundleId = value;
			}
		}
		public string BundleUrl
		{
			get
			{
				return this._bundleUrl;
			}
			set
			{
				this._bundleUrl = value;
			}
		}
	}
}

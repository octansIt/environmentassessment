namespace EnvironmentAssessment.Common.VimApi
{
	public class HostService : DynamicData
	{
		protected string _key;
		protected string _label;
		protected bool _required;
		protected bool _uninstallable;
		protected bool _running;
		protected string[] _ruleset;
		protected string _policy;
		protected HostServiceSourcePackage _sourcePackage;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				this._label = value;
			}
		}
		public bool Required
		{
			get
			{
				return this._required;
			}
			set
			{
				this._required = value;
			}
		}
		public bool Uninstallable
		{
			get
			{
				return this._uninstallable;
			}
			set
			{
				this._uninstallable = value;
			}
		}
		public bool Running
		{
			get
			{
				return this._running;
			}
			set
			{
				this._running = value;
			}
		}
		public string[] Ruleset
		{
			get
			{
				return this._ruleset;
			}
			set
			{
				this._ruleset = value;
			}
		}
		public string Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public HostServiceSourcePackage SourcePackage
		{
			get
			{
				return this._sourcePackage;
			}
			set
			{
				this._sourcePackage = value;
			}
		}
	}
}

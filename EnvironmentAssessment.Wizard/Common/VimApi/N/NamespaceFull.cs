namespace EnvironmentAssessment.Common.VimApi
{
	public class NamespaceFull : VimFault
	{
		protected string _name;
		protected long _currentMaxSize;
		protected long? _requiredSize;
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
		public long CurrentMaxSize
		{
			get
			{
				return this._currentMaxSize;
			}
			set
			{
				this._currentMaxSize = value;
			}
		}
		public long? RequiredSize
		{
			get
			{
				return this._requiredSize;
			}
			set
			{
				this._requiredSize = value;
			}
		}
	}
}

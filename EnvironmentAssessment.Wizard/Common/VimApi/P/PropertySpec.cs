namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertySpec : DynamicData
	{
		protected string _type;
		protected bool? _all;
		protected string[] _pathSet;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public bool? All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}
		public string[] PathSet
		{
			get
			{
				return this._pathSet;
			}
			set
			{
				this._pathSet = value;
			}
		}
	}
}

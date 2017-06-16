namespace EnvironmentAssessment.Common.VISoap
{
    public class TraversalSpec : SelectionSpec
	{
		protected string _type;
		protected string _path;
		protected bool? _skip;
		protected SelectionSpec[] _selectSet;
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
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public bool? Skip
		{
			get
			{
				return this._skip;
			}
			set
			{
				this._skip = value;
			}
		}
		public SelectionSpec[] SelectSet
		{
			get
			{
				return this._selectSet;
			}
			set
			{
				this._selectSet = value;
			}
		}
	}
}

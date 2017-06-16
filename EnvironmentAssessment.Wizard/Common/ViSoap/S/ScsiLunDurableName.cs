namespace EnvironmentAssessment.Common.VISoap
{
    public class ScsiLunDurableName : DynamicData
	{
		protected string _namespace;
		protected sbyte _namespaceId;
		protected sbyte[] _data;
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				this._namespace = value;
			}
		}
		public sbyte NamespaceId
		{
			get
			{
				return this._namespaceId;
			}
			set
			{
				this._namespaceId = value;
			}
		}
		public sbyte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
	}
}

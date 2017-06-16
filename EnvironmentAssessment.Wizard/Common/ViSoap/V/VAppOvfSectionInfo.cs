namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppOvfSectionInfo : DynamicData
	{
		protected int? _key;
		protected string _namespace;
		protected string _type;
		protected bool? _atEnvelopeLevel;
		protected string _contents;
		public int? Key
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
		public bool? AtEnvelopeLevel
		{
			get
			{
				return this._atEnvelopeLevel;
			}
			set
			{
				this._atEnvelopeLevel = value;
			}
		}
		public string Contents
		{
			get
			{
				return this._contents;
			}
			set
			{
				this._contents = value;
			}
		}
	}
}

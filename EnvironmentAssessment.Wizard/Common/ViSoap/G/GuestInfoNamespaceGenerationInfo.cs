namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestInfoNamespaceGenerationInfo : DynamicData
	{
		protected string _key;
		protected int _generationNo;
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
		public int GenerationNo
		{
			get
			{
				return this._generationNo;
			}
			set
			{
				this._generationNo = value;
			}
		}
	}
}

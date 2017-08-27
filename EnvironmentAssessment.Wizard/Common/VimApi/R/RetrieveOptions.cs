namespace EnvironmentAssessment.Common.VimApi
{
	public class RetrieveOptions : DynamicData
	{
		protected int? _maxObjects;
		public int? MaxObjects
		{
			get
			{
				return this._maxObjects;
			}
			set
			{
				this._maxObjects = value;
			}
		}
	}
}

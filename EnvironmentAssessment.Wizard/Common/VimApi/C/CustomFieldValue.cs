namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomFieldValue : DynamicData
	{
		protected int _key;
		public int Key
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
	}
}

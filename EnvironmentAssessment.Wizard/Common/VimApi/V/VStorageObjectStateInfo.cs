namespace EnvironmentAssessment.Common.VimApi
{
	public class VStorageObjectStateInfo : DynamicData
	{
		protected bool? _tentative;
		public bool? Tentative
		{
			get
			{
				return this._tentative;
			}
			set
			{
				this._tentative = value;
			}
		}
	}
}

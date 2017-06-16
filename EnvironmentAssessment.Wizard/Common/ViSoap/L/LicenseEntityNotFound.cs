namespace EnvironmentAssessment.Common.VISoap
{
    public class LicenseEntityNotFound : VimFault
	{
		protected string _entityId;
		public string EntityId
		{
			get
			{
				return this._entityId;
			}
			set
			{
				this._entityId = value;
			}
		}
	}
}

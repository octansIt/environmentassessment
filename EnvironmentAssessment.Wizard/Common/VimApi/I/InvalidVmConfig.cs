namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidVmConfig : VmConfigFault
	{
		protected string _property;
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
	}
}

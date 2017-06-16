namespace EnvironmentAssessment.Common.VISoap
{
    public class InventoryHasStandardAloneHosts : NotEnoughLicenses
	{
		protected string[] _hosts;
		public string[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
	}
}

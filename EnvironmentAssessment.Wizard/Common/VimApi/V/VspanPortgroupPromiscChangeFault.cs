namespace EnvironmentAssessment.Common.VimApi
{
	public class VspanPortgroupPromiscChangeFault : DvsFault
	{
		protected string _portgroupName;
		public string PortgroupName
		{
			get
			{
				return this._portgroupName;
			}
			set
			{
				this._portgroupName = value;
			}
		}
	}
}

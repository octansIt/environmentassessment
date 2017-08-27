namespace EnvironmentAssessment.Common.VimApi
{
	public class VspanPortgroupTypeChangeFault : DvsFault
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

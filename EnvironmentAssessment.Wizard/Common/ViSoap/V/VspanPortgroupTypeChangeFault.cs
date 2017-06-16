namespace EnvironmentAssessment.Common.VISoap
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

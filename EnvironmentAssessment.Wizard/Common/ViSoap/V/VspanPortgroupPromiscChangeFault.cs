namespace EnvironmentAssessment.Common.VISoap
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

namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsPortVendorSpecificStateChangeEvent : DvsEvent
	{
		protected string _portKey;
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
	}
}
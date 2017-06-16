namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicNameHint : PhysicalNicHint
	{
		protected string _network;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
	}
}

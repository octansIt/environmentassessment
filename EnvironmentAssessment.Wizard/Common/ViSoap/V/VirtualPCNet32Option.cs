namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualPCNet32Option : VirtualEthernetCardOption
	{
		protected bool _supportsMorphing;
		public bool SupportsMorphing
		{
			get
			{
				return this._supportsMorphing;
			}
			set
			{
				this._supportsMorphing = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VimApi
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

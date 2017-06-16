namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualSriovEthernetCard : VirtualEthernetCard
	{
		protected bool? _allowGuestOSMtuChange;
		protected VirtualSriovEthernetCardSriovBackingInfo _sriovBacking;
		public bool? AllowGuestOSMtuChange
		{
			get
			{
				return this._allowGuestOSMtuChange;
			}
			set
			{
				this._allowGuestOSMtuChange = value;
			}
		}
		public VirtualSriovEthernetCardSriovBackingInfo SriovBacking
		{
			get
			{
				return this._sriovBacking;
			}
			set
			{
				this._sriovBacking = value;
			}
		}
	}
}

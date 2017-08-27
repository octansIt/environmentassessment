namespace EnvironmentAssessment.Common.VimApi
{
	public class HostFibreChannelOverEthernetHba : HostFibreChannelHba
	{
		protected string _underlyingNic;
		protected HostFibreChannelOverEthernetHbaLinkInfo _linkInfo;
		protected bool _isSoftwareFcoe;
		protected bool _markedForRemoval;
		public string UnderlyingNic
		{
			get
			{
				return this._underlyingNic;
			}
			set
			{
				this._underlyingNic = value;
			}
		}
		public HostFibreChannelOverEthernetHbaLinkInfo LinkInfo
		{
			get
			{
				return this._linkInfo;
			}
			set
			{
				this._linkInfo = value;
			}
		}
		public bool IsSoftwareFcoe
		{
			get
			{
				return this._isSoftwareFcoe;
			}
			set
			{
				this._isSoftwareFcoe = value;
			}
		}
		public bool MarkedForRemoval
		{
			get
			{
				return this._markedForRemoval;
			}
			set
			{
				this._markedForRemoval = value;
			}
		}
	}
}

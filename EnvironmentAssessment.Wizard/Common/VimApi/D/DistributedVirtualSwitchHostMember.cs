namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostMember : DynamicData
	{
		protected DistributedVirtualSwitchHostMemberRuntimeState _runtimeState;
		protected DistributedVirtualSwitchHostMemberConfigInfo _config;
		protected DistributedVirtualSwitchProductSpec _productInfo;
		protected string[] _uplinkPortKey;
		protected string _status;
		protected string _statusDetail;
		public DistributedVirtualSwitchHostMemberRuntimeState RuntimeState
		{
			get
			{
				return this._runtimeState;
			}
			set
			{
				this._runtimeState = value;
			}
		}
		public DistributedVirtualSwitchHostMemberConfigInfo Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
		public DistributedVirtualSwitchProductSpec ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
		public string[] UplinkPortKey
		{
			get
			{
				return this._uplinkPortKey;
			}
			set
			{
				this._uplinkPortKey = value;
			}
		}
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string StatusDetail
		{
			get
			{
				return this._statusDetail;
			}
			set
			{
				this._statusDetail = value;
			}
		}
	}
}

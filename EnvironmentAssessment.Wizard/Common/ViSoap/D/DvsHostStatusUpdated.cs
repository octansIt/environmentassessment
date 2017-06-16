namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsHostStatusUpdated : DvsEvent
	{
		protected HostEventArgument _hostMember;
		protected string _oldStatus;
		protected string _newStatus;
		protected string _oldStatusDetail;
		protected string _newStatusDetail;
		public HostEventArgument HostMember
		{
			get
			{
				return this._hostMember;
			}
			set
			{
				this._hostMember = value;
			}
		}
		public string OldStatus
		{
			get
			{
				return this._oldStatus;
			}
			set
			{
				this._oldStatus = value;
			}
		}
		public string NewStatus
		{
			get
			{
				return this._newStatus;
			}
			set
			{
				this._newStatus = value;
			}
		}
		public string OldStatusDetail
		{
			get
			{
				return this._oldStatusDetail;
			}
			set
			{
				this._oldStatusDetail = value;
			}
		}
		public string NewStatusDetail
		{
			get
			{
				return this._newStatusDetail;
			}
			set
			{
				this._newStatusDetail = value;
			}
		}
	}
}

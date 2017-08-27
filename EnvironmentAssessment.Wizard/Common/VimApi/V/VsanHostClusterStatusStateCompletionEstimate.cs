using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostClusterStatusStateCompletionEstimate : DynamicData
	{
		protected DateTime? _completeTime;
		protected int? _percentComplete;
		public DateTime? CompleteTime
		{
			get
			{
				return this._completeTime;
			}
			set
			{
				this._completeTime = value;
			}
		}
		public int? PercentComplete
		{
			get
			{
				return this._percentComplete;
			}
			set
			{
				this._percentComplete = value;
			}
		}
	}
}

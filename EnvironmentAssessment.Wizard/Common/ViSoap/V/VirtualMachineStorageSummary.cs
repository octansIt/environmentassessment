using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class VirtualMachineStorageSummary : DynamicData
	{
		protected long _committed;
		protected long _uncommitted;
		protected long _unshared;
		protected DateTime _timestamp;
		public long Committed
		{
			get
			{
				return this._committed;
			}
			set
			{
				this._committed = value;
			}
		}
		public long Uncommitted
		{
			get
			{
				return this._uncommitted;
			}
			set
			{
				this._uncommitted = value;
			}
		}
		public long Unshared
		{
			get
			{
				return this._unshared;
			}
			set
			{
				this._unshared = value;
			}
		}
		public DateTime Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
	}
}

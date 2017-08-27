namespace EnvironmentAssessment.Common.VimApi
{
	public class InsufficientHostCpuCapacityFault : InsufficientHostCapacityFault
	{
		protected long _unreserved;
		protected long _requested;
		public long Unreserved
		{
			get
			{
				return this._unreserved;
			}
			set
			{
				this._unreserved = value;
			}
		}
		public long Requested
		{
			get
			{
				return this._requested;
			}
			set
			{
				this._requested = value;
			}
		}
		public new InsufficientHostCpuCapacityFault_LinkedView LinkedView
		{
			get
			{
				return (InsufficientHostCpuCapacityFault_LinkedView)this._linkedView;
			}
		}
	}
}

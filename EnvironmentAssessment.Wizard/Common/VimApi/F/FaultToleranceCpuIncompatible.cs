namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceCpuIncompatible : CpuIncompatible
	{
		protected bool _model;
		protected bool _family;
		protected bool _stepping;
		public bool Model
		{
			get
			{
				return this._model;
			}
			set
			{
				this._model = value;
			}
		}
		public bool Family
		{
			get
			{
				return this._family;
			}
			set
			{
				this._family = value;
			}
		}
		public bool Stepping
		{
			get
			{
				return this._stepping;
			}
			set
			{
				this._stepping = value;
			}
		}
		public new FaultToleranceCpuIncompatible_LinkedView LinkedView
		{
			get
			{
				return (FaultToleranceCpuIncompatible_LinkedView)this._linkedView;
			}
		}
	}
}

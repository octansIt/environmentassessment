namespace EnvironmentAssessment.Common.VimApi
{
	public class CpuIncompatible81EDX : CpuIncompatible
	{
		protected bool _nx;
		protected bool _ffxsr;
		protected bool _rdtscp;
		protected bool _lm;
		protected bool _other;
		protected bool _otherOnly;
		public bool Nx
		{
			get
			{
				return this._nx;
			}
			set
			{
				this._nx = value;
			}
		}
		public bool Ffxsr
		{
			get
			{
				return this._ffxsr;
			}
			set
			{
				this._ffxsr = value;
			}
		}
		public bool Rdtscp
		{
			get
			{
				return this._rdtscp;
			}
			set
			{
				this._rdtscp = value;
			}
		}
		public bool Lm
		{
			get
			{
				return this._lm;
			}
			set
			{
				this._lm = value;
			}
		}
		public bool Other
		{
			get
			{
				return this._other;
			}
			set
			{
				this._other = value;
			}
		}
		public bool OtherOnly
		{
			get
			{
				return this._otherOnly;
			}
			set
			{
				this._otherOnly = value;
			}
		}
		public new CpuIncompatible81EDX_LinkedView LinkedView
		{
			get
			{
				return (CpuIncompatible81EDX_LinkedView)this._linkedView;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VimApi
{
	public class CpuIncompatible1ECX : CpuIncompatible
	{
		protected bool _sse3;
		protected bool _pclmulqdq;
		protected bool _ssse3;
		protected bool _sse41;
		protected bool _sse42;
		protected bool _aes;
		protected bool _other;
		protected bool _otherOnly;
		public bool Sse3
		{
			get
			{
				return this._sse3;
			}
			set
			{
				this._sse3 = value;
			}
		}
		public bool Pclmulqdq
		{
			get
			{
				return this._pclmulqdq;
			}
			set
			{
				this._pclmulqdq = value;
			}
		}
		public bool Ssse3
		{
			get
			{
				return this._ssse3;
			}
			set
			{
				this._ssse3 = value;
			}
		}
		public bool Sse41
		{
			get
			{
				return this._sse41;
			}
			set
			{
				this._sse41 = value;
			}
		}
		public bool Sse42
		{
			get
			{
				return this._sse42;
			}
			set
			{
				this._sse42 = value;
			}
		}
		public bool Aes
		{
			get
			{
				return this._aes;
			}
			set
			{
				this._aes = value;
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
		public new CpuIncompatible1ECX_LinkedView LinkedView
		{
			get
			{
				return (CpuIncompatible1ECX_LinkedView)this._linkedView;
			}
		}
	}
}

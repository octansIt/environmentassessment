namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInternetScsiHbaAuthenticationCapabilities : DynamicData
	{
		protected bool _chapAuthSettable;
		protected bool _krb5AuthSettable;
		protected bool _srpAuthSettable;
		protected bool _spkmAuthSettable;
		protected bool? _mutualChapSettable;
		protected bool? _targetChapSettable;
		protected bool? _targetMutualChapSettable;
		public bool ChapAuthSettable
		{
			get
			{
				return this._chapAuthSettable;
			}
			set
			{
				this._chapAuthSettable = value;
			}
		}
		public bool Krb5AuthSettable
		{
			get
			{
				return this._krb5AuthSettable;
			}
			set
			{
				this._krb5AuthSettable = value;
			}
		}
		public bool SrpAuthSettable
		{
			get
			{
				return this._srpAuthSettable;
			}
			set
			{
				this._srpAuthSettable = value;
			}
		}
		public bool SpkmAuthSettable
		{
			get
			{
				return this._spkmAuthSettable;
			}
			set
			{
				this._spkmAuthSettable = value;
			}
		}
		public bool? MutualChapSettable
		{
			get
			{
				return this._mutualChapSettable;
			}
			set
			{
				this._mutualChapSettable = value;
			}
		}
		public bool? TargetChapSettable
		{
			get
			{
				return this._targetChapSettable;
			}
			set
			{
				this._targetChapSettable = value;
			}
		}
		public bool? TargetMutualChapSettable
		{
			get
			{
				return this._targetMutualChapSettable;
			}
			set
			{
				this._targetMutualChapSettable = value;
			}
		}
	}
}

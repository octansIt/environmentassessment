namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaAuthenticationProperties : DynamicData
	{
		protected bool _chapAuthEnabled;
		protected string _chapName;
		protected string _chapSecret;
		protected string _chapAuthenticationType;
		protected bool? _chapInherited;
		protected string _mutualChapName;
		protected string _mutualChapSecret;
		protected string _mutualChapAuthenticationType;
		protected bool? _mutualChapInherited;
		public bool ChapAuthEnabled
		{
			get
			{
				return this._chapAuthEnabled;
			}
			set
			{
				this._chapAuthEnabled = value;
			}
		}
		public string ChapName
		{
			get
			{
				return this._chapName;
			}
			set
			{
				this._chapName = value;
			}
		}
		public string ChapSecret
		{
			get
			{
				return this._chapSecret;
			}
			set
			{
				this._chapSecret = value;
			}
		}
		public string ChapAuthenticationType
		{
			get
			{
				return this._chapAuthenticationType;
			}
			set
			{
				this._chapAuthenticationType = value;
			}
		}
		public bool? ChapInherited
		{
			get
			{
				return this._chapInherited;
			}
			set
			{
				this._chapInherited = value;
			}
		}
		public string MutualChapName
		{
			get
			{
				return this._mutualChapName;
			}
			set
			{
				this._mutualChapName = value;
			}
		}
		public string MutualChapSecret
		{
			get
			{
				return this._mutualChapSecret;
			}
			set
			{
				this._mutualChapSecret = value;
			}
		}
		public string MutualChapAuthenticationType
		{
			get
			{
				return this._mutualChapAuthenticationType;
			}
			set
			{
				this._mutualChapAuthenticationType = value;
			}
		}
		public bool? MutualChapInherited
		{
			get
			{
				return this._mutualChapInherited;
			}
			set
			{
				this._mutualChapInherited = value;
			}
		}
	}
}

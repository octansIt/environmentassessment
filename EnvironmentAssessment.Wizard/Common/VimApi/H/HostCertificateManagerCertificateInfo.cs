using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCertificateManagerCertificateInfo : DynamicData
	{
		protected string _issuer;
		protected DateTime? _notBefore;
		protected DateTime? _notAfter;
		protected string _subject;
		protected string _status;
		public string Issuer
		{
			get
			{
				return this._issuer;
			}
			set
			{
				this._issuer = value;
			}
		}
		public DateTime? NotBefore
		{
			get
			{
				return this._notBefore;
			}
			set
			{
				this._notBefore = value;
			}
		}
		public DateTime? NotAfter
		{
			get
			{
				return this._notAfter;
			}
			set
			{
				this._notAfter = value;
			}
		}
		public string Subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				this._subject = value;
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
	}
}

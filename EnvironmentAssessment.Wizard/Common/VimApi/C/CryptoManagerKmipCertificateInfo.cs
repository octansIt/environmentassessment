using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManagerKmipCertificateInfo : DynamicData
	{
		protected string _subject;
		protected string _issuer;
		protected string _serialNumber;
		protected DateTime _notBefore;
		protected DateTime _notAfter;
		protected string _fingerprint;
		protected DateTime _checkTime;
		protected int? _secondsSinceValid;
		protected int? _secondsBeforeExpire;
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
		public string SerialNumber
		{
			get
			{
				return this._serialNumber;
			}
			set
			{
				this._serialNumber = value;
			}
		}
		public DateTime NotBefore
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
		public DateTime NotAfter
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
		public string Fingerprint
		{
			get
			{
				return this._fingerprint;
			}
			set
			{
				this._fingerprint = value;
			}
		}
		public DateTime CheckTime
		{
			get
			{
				return this._checkTime;
			}
			set
			{
				this._checkTime = value;
			}
		}
		public int? SecondsSinceValid
		{
			get
			{
				return this._secondsSinceValid;
			}
			set
			{
				this._secondsSinceValid = value;
			}
		}
		public int? SecondsBeforeExpire
		{
			get
			{
				return this._secondsBeforeExpire;
			}
			set
			{
				this._secondsBeforeExpire = value;
			}
		}
	}
}

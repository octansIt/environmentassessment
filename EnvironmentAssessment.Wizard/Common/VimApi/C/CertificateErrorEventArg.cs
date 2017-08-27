using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
namespace EnvironmentAssessment.Common.VimApi
{
	public class CertificateErrorEventArg : EventArgs
	{
		private X509Certificate _certificate;
		private X509Chain _chain;
		private SslPolicyErrors _sslPolicyErrors;
		private bool _ignoreError;
		private readonly object _sender;
		public object Sender
		{
			get
			{
				return this._sender;
			}
		}
		public X509Certificate Certificate
		{
			get
			{
				return this._certificate;
			}
		}
		public X509Chain Chain
		{
			get
			{
				return this._chain;
			}
		}
		public SslPolicyErrors SslPolicyErrors
		{
			get
			{
				return this._sslPolicyErrors;
			}
		}
		public bool IgnoreError
		{
			get
			{
				return this._ignoreError;
			}
			set
			{
				this._ignoreError = value;
			}
		}
		public CertificateErrorEventArg(X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, bool ignoreError)
		{
			this._certificate = certificate;
			this._chain = chain;
			this._sslPolicyErrors = sslPolicyErrors;
			this._ignoreError = ignoreError;
		}
		public CertificateErrorEventArg(X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, bool ignoreError, object sender)
		{
			this._certificate = certificate;
			this._chain = chain;
			this._sslPolicyErrors = sslPolicyErrors;
			this._ignoreError = ignoreError;
			this._sender = sender;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Security;
namespace EnvironmentAssessment.Common.VimApi
{
	internal sealed class SecurePasswordField
	{
		private SecureString _value;
		public SecureString Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
		public SecurePasswordField(PasswordField passwordField)
		{
			this.Value = SecurePasswordField.StringToSecureString(passwordField.Value);
		}
		public PasswordField ToPasswordField()
		{
			return new PasswordField
			{
				Value = SecurePasswordField.SecureStringToString(this.Value)
			};
		}
		private static SecureString StringToSecureString(string value)
		{
			if (value == null)
			{
				return null;
			}
			SecureString secureString = new SecureString();
			for (int i = 0; i < value.Length; i++)
			{
				char c = value[i];
				secureString.AppendChar(c);
			}
			secureString.MakeReadOnly();
			return secureString;
		}
		private static string SecureStringToString(SecureString value)
		{
			IntPtr intPtr = IntPtr.Zero;
			string result;
			try
			{
				intPtr = Marshal.SecureStringToGlobalAllocUnicode(value);
				result = Marshal.PtrToStringUni(intPtr);
			}
			finally
			{
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
			}
			return result;
		}
	}
}

using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestRegKeySpec : DynamicData
	{
		protected GuestRegKeyNameSpec _keyName;
		protected string _classType;
		protected DateTime _lastWritten;
		public GuestRegKeyNameSpec KeyName
		{
			get
			{
				return this._keyName;
			}
			set
			{
				this._keyName = value;
			}
		}
		public string ClassType
		{
			get
			{
				return this._classType;
			}
			set
			{
				this._classType = value;
			}
		}
		public DateTime LastWritten
		{
			get
			{
				return this._lastWritten;
			}
			set
			{
				this._lastWritten = value;
			}
		}
	}
}

using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestWindowsFileAttributes : GuestFileAttributes
	{
		protected bool? _hidden;
		protected bool? _readOnly;
		protected DateTime? _createTime;
		public bool? Hidden
		{
			get
			{
				return this._hidden;
			}
			set
			{
				this._hidden = value;
			}
		}
		public bool? ReadOnly
		{
			get
			{
				return this._readOnly;
			}
			set
			{
				this._readOnly = value;
			}
		}
		public DateTime? CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				this._createTime = value;
			}
		}
	}
}

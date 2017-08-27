using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestFileAttributes : DynamicData
	{
		protected DateTime? _modificationTime;
		protected DateTime? _accessTime;
		protected string _symlinkTarget;
		public DateTime? ModificationTime
		{
			get
			{
				return this._modificationTime;
			}
			set
			{
				this._modificationTime = value;
			}
		}
		public DateTime? AccessTime
		{
			get
			{
				return this._accessTime;
			}
			set
			{
				this._accessTime = value;
			}
		}
		public string SymlinkTarget
		{
			get
			{
				return this._symlinkTarget;
			}
			set
			{
				this._symlinkTarget = value;
			}
		}
	}
}

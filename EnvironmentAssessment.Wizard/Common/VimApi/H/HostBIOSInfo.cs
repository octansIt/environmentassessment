using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostBIOSInfo : DynamicData
	{
		protected string _biosVersion;
		protected DateTime? _releaseDate;
		protected string _vendor;
		protected int? _majorRelease;
		protected int? _minorRelease;
		protected int? _firmwareMajorRelease;
		protected int? _firmwareMinorRelease;
		public string BiosVersion
		{
			get
			{
				return this._biosVersion;
			}
			set
			{
				this._biosVersion = value;
			}
		}
		public DateTime? ReleaseDate
		{
			get
			{
				return this._releaseDate;
			}
			set
			{
				this._releaseDate = value;
			}
		}
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public int? MajorRelease
		{
			get
			{
				return this._majorRelease;
			}
			set
			{
				this._majorRelease = value;
			}
		}
		public int? MinorRelease
		{
			get
			{
				return this._minorRelease;
			}
			set
			{
				this._minorRelease = value;
			}
		}
		public int? FirmwareMajorRelease
		{
			get
			{
				return this._firmwareMajorRelease;
			}
			set
			{
				this._firmwareMajorRelease = value;
			}
		}
		public int? FirmwareMinorRelease
		{
			get
			{
				return this._firmwareMinorRelease;
			}
			set
			{
				this._firmwareMinorRelease = value;
			}
		}
	}
}

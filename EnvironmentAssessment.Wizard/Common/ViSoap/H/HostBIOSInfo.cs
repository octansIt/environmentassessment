using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostBIOSInfo : DynamicData
	{
		protected string _biosVersion;
		protected DateTime? _releaseDate;
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
	}
}

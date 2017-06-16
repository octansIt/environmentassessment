using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class GuestProcessInfo : DynamicData
	{
		protected string _name;
		protected long _pid;
		protected string _owner;
		protected string _cmdLine;
		protected DateTime _startTime;
		protected DateTime? _endTime;
		protected int? _exitCode;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public long Pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				this._pid = value;
			}
		}
		public string Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
			}
		}
		public string CmdLine
		{
			get
			{
				return this._cmdLine;
			}
			set
			{
				this._cmdLine = value;
			}
		}
		public DateTime StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				this._startTime = value;
			}
		}
		public DateTime? EndTime
		{
			get
			{
				return this._endTime;
			}
			set
			{
				this._endTime = value;
			}
		}
		public int? ExitCode
		{
			get
			{
				return this._exitCode;
			}
			set
			{
				this._exitCode = value;
			}
		}
	}
}

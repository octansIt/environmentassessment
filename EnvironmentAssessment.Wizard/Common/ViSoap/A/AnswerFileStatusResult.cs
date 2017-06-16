using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class AnswerFileStatusResult : DynamicData
	{
		protected DateTime _checkedTime;
		protected ManagedObjectReference _host;
		protected string _status;
		protected AnswerFileStatusError[] _error;
		protected AnswerFileStatusResult_LinkedView _linkedView;
		public DateTime CheckedTime
		{
			get
			{
				return this._checkedTime;
			}
			set
			{
				this._checkedTime = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
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
		public AnswerFileStatusError[] Error
		{
			get
			{
				return this._error;
			}
			set
			{
				this._error = value;
			}
		}
		public AnswerFileStatusResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}

using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class AnswerFile : DynamicData
	{
		protected ProfileDeferredPolicyOptionParameter[] _userInput;
		protected DateTime _createdTime;
		protected DateTime _modifiedTime;
		public ProfileDeferredPolicyOptionParameter[] UserInput
		{
			get
			{
				return this._userInput;
			}
			set
			{
				this._userInput = value;
			}
		}
		public DateTime CreatedTime
		{
			get
			{
				return this._createdTime;
			}
			set
			{
				this._createdTime = value;
			}
		}
		public DateTime ModifiedTime
		{
			get
			{
				return this._modifiedTime;
			}
			set
			{
				this._modifiedTime = value;
			}
		}
	}
}

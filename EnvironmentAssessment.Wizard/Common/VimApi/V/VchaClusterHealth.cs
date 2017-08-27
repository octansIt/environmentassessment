namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterHealth : DynamicData
	{
		protected VchaClusterRuntimeInfo _runtimeInfo;
		protected LocalizableMessage[] _healthMessages;
		protected LocalizableMessage[] _additionalInformation;
		public VchaClusterRuntimeInfo RuntimeInfo
		{
			get
			{
				return this._runtimeInfo;
			}
			set
			{
				this._runtimeInfo = value;
			}
		}
		public LocalizableMessage[] HealthMessages
		{
			get
			{
				return this._healthMessages;
			}
			set
			{
				this._healthMessages = value;
			}
		}
		public LocalizableMessage[] AdditionalInformation
		{
			get
			{
				return this._additionalInformation;
			}
			set
			{
				this._additionalInformation = value;
			}
		}
	}
}

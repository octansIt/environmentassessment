namespace EnvironmentAssessment.Common.VimApi
{
	public class ImportSpec : DynamicData
	{
		protected VAppEntityConfigInfo _entityConfig;
		protected OvfConsumerOstNode _instantiationOst;
		public VAppEntityConfigInfo EntityConfig
		{
			get
			{
				return this._entityConfig;
			}
			set
			{
				this._entityConfig = value;
			}
		}
		public OvfConsumerOstNode InstantiationOst
		{
			get
			{
				return this._instantiationOst;
			}
			set
			{
				this._instantiationOst = value;
			}
		}
	}
}

namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfConsumerOstNode : DynamicData
	{
		protected string _id;
		protected string _type;
		protected OvfConsumerOvfSection[] _section;
		protected OvfConsumerOstNode[] _child;
		protected ManagedObjectReference _entity;
		protected OvfConsumerOstNode_LinkedView _linkedView;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public OvfConsumerOvfSection[] Section
		{
			get
			{
				return this._section;
			}
			set
			{
				this._section = value;
			}
		}
		public OvfConsumerOstNode[] Child
		{
			get
			{
				return this._child;
			}
			set
			{
				this._child = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public OvfConsumerOstNode_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}

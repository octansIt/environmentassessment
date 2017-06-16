namespace EnvironmentAssessment.Common.VISoap
{
    public class ManagedObjectReference
	{
		protected string _type;
		protected string _value;
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
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
		public override string ToString()
		{
			return string.Format("{0}-{1}", this._type, this._value);
		}
		public override bool Equals(object obj)
		{
			return obj != null && obj is ManagedObjectReference && ((ManagedObjectReference)obj).Type == this._type && ((ManagedObjectReference)obj).Value == this._value;
		}
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}
		public ManagedObjectReference(string id)
		{
			if (id.StartsWith("/"))
			{
				id = id.Trim("/".ToCharArray());
				int num = id.LastIndexOf("=");
				if (num > 0)
				{
					id = id.Substring(num + 1);
				}
			}
			if (string.IsNullOrEmpty(id))
			{
				this._type = null;
				this._value = null;
				return;
			}
			int num2 = id.IndexOf('-');
			if (num2 != -1)
			{
				this._type = id.Substring(0, num2);
				this._value = id.Substring(num2 + 1);
				return;
			}
			this._type = null;
			this._value = id;
		}
		public ManagedObjectReference()
		{
		}
	}
}

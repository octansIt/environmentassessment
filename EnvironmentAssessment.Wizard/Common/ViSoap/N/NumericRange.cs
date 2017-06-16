namespace EnvironmentAssessment.Common.VISoap
{
    public class NumericRange : DynamicData
	{
		protected int _start;
		protected int _end;
		public int Start
		{
			get
			{
				return this._start;
			}
			set
			{
				this._start = value;
			}
		}
		public int End
		{
			get
			{
				return this._end;
			}
			set
			{
				this._end = value;
			}
		}
	}
}

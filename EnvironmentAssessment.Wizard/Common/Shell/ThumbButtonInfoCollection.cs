using System.Windows;

namespace EnvironmentAssessment.Common.Shell
{
    public class ThumbButtonInfoCollection : FreezableCollection<ThumbButtonInfo>
	{
		private static ThumbButtonInfoCollection s_empty;

		internal static ThumbButtonInfoCollection Empty
		{
			get
			{
				if (ThumbButtonInfoCollection.s_empty == null)
				{
					ThumbButtonInfoCollection thumbButtonInfoCollection = new ThumbButtonInfoCollection();
					thumbButtonInfoCollection.Freeze();
					ThumbButtonInfoCollection.s_empty = thumbButtonInfoCollection;
				}
				return ThumbButtonInfoCollection.s_empty;
			}
		}

		protected override Freezable CreateInstanceCore()
		{
			return new ThumbButtonInfoCollection();
		}
	}
}

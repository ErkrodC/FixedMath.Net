using System;

namespace FixMath.NET {
	[Serializable]
	public struct FixVector2 {
		public Fix64 x;
		public Fix64 y;

		public static Fix64 Distance(FixVector2 vec0, FixVector2 vec1) {
			Fix64 dx = vec0.x - vec1.x;
			Fix64 dy = vec0.y - vec1.y;
			return Fix64.Sqrt(dx * dx + dy * dy);
		}
	}
}
using System;

namespace DunGen
{
	[Serializable]
	public sealed class KeyLockPlacement
	{
		public int ID;
		public IntRange Range = new IntRange(0, 1);
	}
}


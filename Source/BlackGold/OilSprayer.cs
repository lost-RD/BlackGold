using System;
using Verse;
using RimWorld;

namespace BlackGold
{
	public class OilSprayer
	{
		private const int MinTicksBetweenSprays = 100;

		private const int MaxTicksBetweenSprays = 600;

		private const int MinSprayDuration = 500;

		private const int MaxSprayDuration = 1000;

		private const float SprayThickness = 0.6f;

		private Thing parent;

		private int ticksUntilSpray = 100;

		private int sprayTicksLeft;

		public Action startSprayCallback;

		public Action endSprayCallback;

        public OilSprayer(Thing parent)
		{
			this.parent = parent;
		}

		public void OilSprayerTick()
		{
			if (this.sprayTicksLeft > 0)
			{
				this.sprayTicksLeft--;
				if (Rand.Value < 0.6f)
				{
					MoteThrower.ThrowOilPuffUp(this.parent.TrueCenter());
				}
				if (this.sprayTicksLeft <= 0)
				{
					if (this.endSprayCallback != null)
					{
						this.endSprayCallback();
					}
					this.ticksUntilSpray = Rand.RangeInclusive(500, 2000);
				}
			}
			else
			{
				this.ticksUntilSpray--;
				if (this.ticksUntilSpray <= 0)
				{
					if (this.startSprayCallback != null)
					{
						this.startSprayCallback();
					}
					this.sprayTicksLeft = Rand.RangeInclusive(200, 500);
				}
			}
		}
	}
}

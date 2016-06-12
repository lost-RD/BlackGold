using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace BlackGold
{
	public static class MoteThrower
	{
        private static MoteThrown NewBaseOilPuff()
        {
            MoteThrown moteThrown = (MoteThrown)ThingMaker.MakeThing(ThingDefOf.Mote_OilPuff, null);
            moteThrown.ScaleUniform = 1.5f;
            moteThrown.exactRotationRate = (float)Rand.RangeInclusive(-4, 4);
            return moteThrown;
        }
        public static void ThrowOilPuffUp(Vector3 loc)
        {
            if (!loc.ToIntVec3().ShouldSpawnMotesAt() || MoteCounter.SaturatedLowPriority)
            {
                return;
            }
            MoteThrown moteThrown = MoteThrower.NewBaseOilPuff();
            moteThrown.exactPosition = loc;
            moteThrown.exactPosition += new Vector3(Rand.Range(-0.02f, 0.02f), 0f, Rand.Range(-0.02f, 0.02f));
            moteThrown.SetVelocityAngleSpeed((float)Rand.Range(-15, 15), Rand.Range(0.06f, 0.2f));
            GenSpawn.Spawn(moteThrown, loc.ToIntVec3());
        }
	}
}

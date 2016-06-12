using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI;
using Verse.Sound;
using UnityEngine;
using BlackGold;

namespace BlackGold
{
    public class PlaceWorker_OnOilGusher : PlaceWorker
    {
        public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot)
        {
            Thing thing = Find.ThingGrid.ThingAt(loc, ThingDefOf.OilGusher);
            if (thing == null)
            {
                return "Thing is null";
            }
            if (thing.Position != loc)
            {
	            return "MustPlaceOnOilGusher".Translate() + " - " + thing;
            }
            return true;
        }
    }
}

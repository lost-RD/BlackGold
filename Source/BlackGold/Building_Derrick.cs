using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI;
using Verse.Sound;
using UnityEngine;

namespace BlackGold
{
	public class Building_Derrick : Building_WorkTable
    {
        private OilSprayer oilSprayer;

        private OilGusher gusher;

        public override void SpawnSetup()
        {
            base.SpawnSetup();
            this.oilSprayer = new OilSprayer(this);
        }

        public override void Tick()
        {
            base.Tick();
            if (this.gusher == null)
            {
                this.gusher = (OilGusher)Find.ThingGrid.ThingAt(base.Position, ThingDefOf.OilGusher);
            }
            if (this.gusher != null)
            {
                this.gusher.harvester = this;
                //this.oilSprayer.OilSprayerTick();
            }
        }

        public override void DeSpawn()
        {
            base.DeSpawn();
            if (this.gusher != null)
            {
                this.gusher.harvester = null;
            }
        }
    }
}

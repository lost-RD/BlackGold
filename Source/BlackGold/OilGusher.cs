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
    public class OilGusher : Thing
    {
        private OilSprayer oilSprayer;

        public Building harvester;

        private Sustainer spraySustainer;

        private int spraySustainerStartTick = -999;

        public override void SpawnSetup()
        {
            base.SpawnSetup();
            this.oilSprayer = new OilSprayer(this);
            this.oilSprayer.startSprayCallback = new Action(this.StartSpray);
            this.oilSprayer.endSprayCallback = new Action(this.EndSpray);
        }

        private void StartSpray()
        {
            SnowUtility.AddSnowRadial(this.OccupiedRect().RandomCell, 4f, -0.06f);
            this.spraySustainer = SoundDefOf.GeyserSpray.TrySpawnSustainer(base.Position);
            this.spraySustainerStartTick = Find.TickManager.TicksGame;
        }

        private void EndSpray()
        {
            if (this.spraySustainer != null)
            {
                this.spraySustainer.End();
                this.spraySustainer = null;
            }
        }

        public override void Tick()
        {
            if (this.harvester == null)
            {
                this.oilSprayer.OilSprayerTick();
            }
            if (this.spraySustainer != null && Find.TickManager.TicksGame > this.spraySustainerStartTick + 1000)
            {
                Log.Message("Gusher spray sustainer still playing after 1000 ticks. Force-ending.");
                this.spraySustainer.End();
                this.spraySustainer = null;
            }
        }
    }
}
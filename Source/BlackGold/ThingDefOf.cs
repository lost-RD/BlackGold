using RimWorld;
using Verse;

namespace BlackGold
{
    [StaticConstructorOnStartup]
    public static class ThingDefOf
    {
        public static ThingDef OilGusher;
		
		public static ThingDef Pumpjack;
		
        public static ThingDef EmptyBarrel;
		
        public static ThingDef OilBarrel;

        public static ThingDef Mote_OilPuff;

        public static void RebindDefs()
        {
            DefOfHelper.BindDefsFor<ThingDef>(typeof(ThingDefOf));
        }

        static ThingDefOf()
        {
            RebindDefs();
        }
    }
}
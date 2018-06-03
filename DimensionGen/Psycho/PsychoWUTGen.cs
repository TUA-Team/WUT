using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria.World.Generation;

namespace WUT.DimensionGen.Psycho
{
    class PsychoWUTGen : Dimlibs.API.DimGenerator
    {
        public override void ModifyGenerationPass(int seed, GenerationProgress customProgressObject)
        {
            AddGenerationPass("Generating intial Terrain", delegate (GenerationProgress progress)
            {

            });
        }
    }
}
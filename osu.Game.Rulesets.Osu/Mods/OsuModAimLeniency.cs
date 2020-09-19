// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModAimLeniency : Mod
    {
        public override string Name => "Aim Leniency";
        public override string Acronym => "AL";
        public override ModType Type => ModType.DifficultyReduction;

        public override double ScoreMultiplier => 1.0;
        public override bool Ranked => false;
    }
}
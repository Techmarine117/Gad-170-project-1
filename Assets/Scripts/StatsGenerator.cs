using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
/// I  assigned a random number value to luck. I assigned values to XP, rythym and style.
public static class StatsGenerator
{
    public static void InitialStats(Stats stats)
    {
        int points = 10;
        stats.luck = Random.Range(0, points);
        stats.xp = 25;
        stats.rhythm =3;
        stats.style = 4;
    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Static class with method (function) to determine the outcome of a dance battle based on the player and NPC that are 
///     dancing off against each other.
///     
/// TODO:
///     Battle needs to use stats and random to determine the winner of the dance off
///       - outcome value to be a float value between 1 and negative 1. 1 being the biggest possible player win over NPC, 
///         through to -1 being the most decimating defeat of the player possible.
/// </summary>
public static class BattleHandler
{
    public static void Battle(BattleEventData data)
    {
        //This needs to be replaced with some actual battle logic, present 
        // we just award the maximum possible win to the player
        // Battle logic added. 
        //Each battle is determined by stats and luck. Luck has a random value.
        int points = 0;
        int tj = 0;


        if (data.player.luck > 5)
        {
            points = Random.Range(-6, 7);
            
        }
        else
        {
            points = Random.Range(-7, 6);

           
        }

        tj = (data.player.style + data.player.luck - data.player.rhythm) / 2 + points;

        if (tj > 0)

        {
            Debug.Log("Win");

        }
        else
        {
            Debug.Log("Loss");

        }


        float outcome = tj;
        //float rand = Random.Range(-1.0f,1.0f);
        var results = new BattleResultEventData(data.player, data.npc, outcome);

        GameEvents.FinishedBattle(results);
    }
}
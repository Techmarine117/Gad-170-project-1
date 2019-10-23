using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()

/// I added two game events classes so that upon conclusion of the battle, the player will gain XP. 
    {
        GameEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {
        GameEvents.OnBattleConclude -= GainXP;
    }

    public void GainXP(BattleResultEventData data)
    {/// I created an if statement which states that if the outcome is greater than zero, the player will gain XP. 
     ///This will tally at the end of the battle. If the XP is greater than 1000, the player levels up.
        if (data.outcome > 0)
        {
            data.player.xp = 25;
        }

        int xpre = 1000;

        if (data.player.xp >= xpre)
        {
            data.player.xp = 0;
            data.player.level += 1;
        Debug.Log("XP Gained");
        }
        
       
        
    }
}

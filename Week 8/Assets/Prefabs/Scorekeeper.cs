using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] private int pointsPerPickup = 1;
    private int score1 = 0;
    private int score2 = 0;
    private int playerNum;

    public float getScore1
    {
        get
        {
            return score1;
        }
    }
    public float getScore2
    {
        get
        {
            return score2;
        }
    }
    public int getPlayerNum
    {
        get
        {
            return playerNum;
        }
    }

    public void IncreaseScore(int num)
    {
        playerNum = num;
        if (playerNum == 1)
        {
            score1 += pointsPerPickup;
        }
        else if (playerNum == 2)
        {
            score2 += pointsPerPickup;
        }
    }
}

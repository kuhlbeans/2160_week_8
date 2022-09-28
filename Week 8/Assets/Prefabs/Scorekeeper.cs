using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] private int pointsPerPickup = 1;
    private int score = 0;

    public float getScore
    {
        get
        {
            return score;
        }
    }

    private void IncreaseScore()
    {
        score += pointsPerPickup;
    }
}

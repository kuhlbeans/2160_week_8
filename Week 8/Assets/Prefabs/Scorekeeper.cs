using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] private int value = 1;
    private int score = 0;

    private void IncreaseScore()
    {
        score += value;
    }
}

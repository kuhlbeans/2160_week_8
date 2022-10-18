using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text player1Text;
    [SerializeField] private Text player2Text;
    [SerializeField] private Scorekeeper scorekeeper;

    // Update is called once per frame
    void Update()
    {
        if (scorekeeper.getPlayerNum == 1)
        {
            player1Text.text = "Player 1 score: " + scorekeeper.getScore1.ToString();
        }
        else if (scorekeeper.getPlayerNum == 2)
        {
            player2Text.text = "Player 2 score: " + scorekeeper.getScore2.ToString();
        }

    }
}

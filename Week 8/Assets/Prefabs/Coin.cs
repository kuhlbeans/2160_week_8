using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Scorekeeper scorekeeper;
    private int playerNum = 0;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player1"))
        {
            playerNum = 1;
            scorekeeper.IncreaseScore(playerNum);
            Destroy(this.gameObject);
        }
        else if (player.CompareTag("Player2"))
        {
            playerNum = 2;
            scorekeeper.IncreaseScore(playerNum);
            Destroy(this.gameObject);
        }
    }
}

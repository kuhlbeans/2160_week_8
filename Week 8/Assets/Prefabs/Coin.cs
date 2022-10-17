using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Scorekeeper scorekeeper;

    // Start is called before the first frame update
    void OnTriggerEnter3D(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            scorekeeper.IncreaseScore();
            Destroy(this.gameObject);
            
        }
    }
}

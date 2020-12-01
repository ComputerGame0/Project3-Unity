using UnityEngine;

public class Collectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        ScoreCounter player = other.GetComponent<ScoreCounter>();
        if (player)
        {
            player.CollectCoin();
            Destroy(gameObject);
        }
    }
}
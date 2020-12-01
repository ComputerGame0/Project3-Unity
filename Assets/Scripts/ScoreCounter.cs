using TMPro;
using UnityEngine;

/**
 * This component tracks the score of the player.
 * The score increases when the player picks a coin.
 */
public class ScoreCounter : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] int scorePerCoin = 1;

    private int score = 0;

    void Start()
    {
        SetScore(0);
    }

    private void SetScore(int s)
    {
        score = s;
        Debug.Log("score=" + score);
       
    }

    public void CollectCoin()
    {
        SetScore(score + scorePerCoin);
    }
}
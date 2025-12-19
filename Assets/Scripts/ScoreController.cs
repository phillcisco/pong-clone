using System;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] ScoreUI scoreUI;
    void OnTriggerEnter2D(Collider2D other)
    {
        int dir = 1;
        if (gameObject.CompareTag("TAG_LeftTrigger"))
        {
            scoreUI.UpdateAiScore();
            dir = 1;
        }

        if (gameObject.CompareTag("TAG_RightTrigger"))
        {
            scoreUI.UpdatePlayerScore();
            dir = -1;
        }
            
        GameManager.Instance.RepositionBall(dir);
    }

}
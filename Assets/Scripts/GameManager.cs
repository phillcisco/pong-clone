using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallController ballController;
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RepositionBall(int dir)
    {
        ballController.RestartGame(dir);
    }
}

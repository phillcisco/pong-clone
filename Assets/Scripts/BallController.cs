using UnityEngine;

public class BallController : MonoBehaviour
{

    Rigidbody2D _ballRb;
    void Awake()
    {
        _ballRb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //_ballRb.AddForce(new Vector2(7,0), ForceMode2D.Impulse);
        _ballRb.linearVelocityX = 7;
    }

    public void RestartGame(int dir)
    {
        _ballRb.transform.position = Vector3.zero;
        _ballRb.linearVelocityX = 7 * dir;
        //_ballRb.AddForce(new Vector2(7*dir,0), ForceMode2D.Impulse);
    }
}

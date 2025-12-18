using System;
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
        _ballRb.AddForce(new Vector2(10,0), ForceMode2D.Impulse);
    }
}

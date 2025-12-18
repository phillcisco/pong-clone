using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{

    Rigidbody2D _paddleRb;
    float _xPaddleValue;
    Camera _mainCamera;
    Vector2 _paddlePos;
    void Awake()
    {
        _paddleRb = GetComponent<Rigidbody2D>();
        _xPaddleValue = transform.position.x;
        _mainCamera = Camera.main;
        _paddlePos = new Vector2(_xPaddleValue, 0);
    }

    void Update()
    {
        _paddlePos.y = _mainCamera.ScreenToWorldPoint(Mouse.current.position.value).y;
        _paddleRb.transform.position = _paddlePos;
    }
}

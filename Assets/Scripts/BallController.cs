using UnityEngine;

public class BallController : MonoBehaviour
{

    Rigidbody2D _ballRb;
    float _ballSpeed;
    Vector2 _ballCurrentDirection;
    Vector2 _ballCurrentSpeed;
    RaycastHit2D hit;
    void Awake()
    {
        _ballRb = GetComponent<Rigidbody2D>();
        _ballSpeed = 9;
    }

    void Start()
    {
        _ballRb.linearVelocity = new Vector2(_ballSpeed,_ballSpeed*0.5f);
        hit = Physics2D.Raycast(_ballRb.position, _ballRb.linearVelocity.normalized);
        _ballCurrentSpeed = _ballRb.linearVelocity;
        _ballCurrentDirection = _ballCurrentSpeed.normalized;
        print(_ballRb.linearVelocity.magnitude);
    }

    public void RestartGame(int dir)
    {
        _ballRb.transform.position = Vector3.zero;
        //_ballRb.linearVelocityX = _ballSpeed * dir;
        _ballRb.linearVelocity = new Vector2(_ballSpeed,_ballSpeed) * dir;
        //_ballRb.AddForce(new Vector2(7*dir,0), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        print("colidiu");
        Vector2 reflectedDir = Reflect(other.GetContact(0).normal, _ballCurrentSpeed);
        
        // _ballRb.linearVelocity = new Vector2(
        //     _ballSpeed*reflectedDir.x,
        //     _ballSpeed*reflectedDir.y
        // );
        _ballRb.linearVelocity = reflectedDir;
        _ballCurrentSpeed = _ballRb.linearVelocity;
        _ballCurrentDirection = _ballRb.linearVelocity.normalized;

    }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     print("Trigger");
    //     _ballCurrentVelocity = _ballRb.linearVelocity;
    // }

    Vector2 Reflect(Vector2 hitNormal, Vector2 hitDirection)
    {
        float projecaoEscalar = Vector2.Dot(hitDirection, hitNormal);
            
        Vector2 reflectVector =  new Vector2(
            hitDirection.x - 2*projecaoEscalar*hitNormal.x,
            hitDirection.y - 2*projecaoEscalar*hitNormal.y
            );

        //float anguloVetor = Mathf.Atan2(reflectVector.y, reflectVector.x);
        //print(anguloVetor*Mathf.Rad2Deg);
        // if (reflectVector.x < 0)
        //     anguloVetor += 180;
        //if (reflectVector.x < 0)
          //  anguloVetor += Mathf.PI;
        //print(anguloVetor);
        
        // float cosX1 = Mathf.Cos(anguloVetor);
        // float senX1 = Mathf.Sin(anguloVetor);
        //
        // float x = _ballCurrentSpeed.x;
        // float y = _ballCurrentSpeed.y;
        //
        // float x2 = cosX1 * x - senX1 * y;
        // float y2 = senX1 * x + senX1 * y;
        //
        // Vector2 newVec = new Vector2(x2, y2);
        // print(x2 + " " + y2);
        //
        // print("Magnitudes");
        // print(_ballCurrentSpeed.magnitude + " " + newVec.magnitude);
        
        
        
        return reflectVector;

    }
}

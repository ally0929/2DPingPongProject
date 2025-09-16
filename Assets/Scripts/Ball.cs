 using UnityEngine;

public class Ball : MonoBehaviour
{
   
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.67f;
    public float moveSpeed = 1f;
    public float maxSyartY = 4f;

    private float startx = 0f;
    
    private void Start()
    {
       InitialPush();

    }

    private void InitialPush()
    {
        Vector2 dir = Vector2.left;
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = dir * moveSpeed;

    }

    private void ResetBall()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
        if(scoreZone)
        {
            Debug.Log("do something!");
        }
    }

}
 
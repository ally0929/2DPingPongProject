using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb2d;
    
    private void Start()
    {
        rb2d.linearVelocity = Vector2.left;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 
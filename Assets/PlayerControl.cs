
using UnityEngine;


public class PlayerControl : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update () {

        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0f, speed);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0f, -speed);
        }
        
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(speed, 0f);
        }
        
    }
}

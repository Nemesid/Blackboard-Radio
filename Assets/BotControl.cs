using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotControl : MonoBehaviour {

    public Rigidbody2D rb;
    public Transform finishLine;
    public float speed = 5f;

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);

        if(hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            //Debug.Log(distance);
            if(distance < 4f)
            {
                Debug.Log("Obstacle Ahead");
                rb.velocity = new Vector2(5f,0f);
            }
        }

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,finishLine.position,step);
    }
}

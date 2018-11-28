using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BotCollision : MonoBehaviour {

    public Rigidbody2D rb;
    bool timer = true;
    public Text BotScore;
    public Text BotHitScore;
    public float timeCount = 0f;
    float finalCount = 0f;
    int HitCount = 0;
    public bool isfinished = false;
    private void Update()
    {
        if (timer)
        {
            timeCount += Time.timeScale;
            var minutes = Mathf.Floor(timeCount / 60);
            var seconds = timeCount % 60;//Use the euclidean division for the seconds.
            var fraction = (timeCount * 100) % 100;
            BotScore.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle1")
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0f, -4f, 0f);
            Debug.Log("Collided Player");
            HitCount += 1;
        }
        if (collision.collider.tag == "Obstacle2")
        {
            StartCoroutine(Stick());
            Debug.Log("Collided Player");
            HitCount += 1;
        }
        if (collision.collider.tag == "FinishLine")
        {
            isfinished = true;
            Debug.Log("Reached Line");
            timer = false;
            
            BotHitScore.text = HitCount.ToString();
        }

    }

    IEnumerator Stick()
    {
        rb.bodyType = RigidbodyType2D.Static;

        yield return new WaitForSeconds(2f);
        gameObject.transform.position = gameObject.transform.position + new Vector3(0f, -0.5f, 0f);
        rb.bodyType = RigidbodyType2D.Dynamic;

    }
}

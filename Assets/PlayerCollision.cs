using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCollision : MonoBehaviour {

    public Rigidbody2D rb;
    public GameObject gameOverPannel;
    public GameObject ScoreText;
    public Text Score;
    public Text PlayerScore;
    public Text PlayerHitScore;
    public float timeCount = 0f;
    float finalCount = 0f;
    int HitCount = 0;
    public BotCollision BC;
    bool timer = true;
    public bool isfinished = false;
 
    private void Update()
    {
        if (timer)
        {
            timeCount += Time.timeScale;
            var minutes = Mathf.Floor(timeCount / 60);
            var seconds = timeCount % 60;//Use the euclidean division for the seconds.
            var fraction = (timeCount * 100) % 100;
            Score.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
            PlayerScore.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Obstacle1")
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
            timer = false;
            Debug.Log("Reached Line");
            PlayerHitScore.text = HitCount.ToString();
            
            ScoreText.SetActive(false);
            isfinished = true;
        }
    }

    IEnumerator Stick()
    {
        rb.bodyType = RigidbodyType2D.Static;
        
        yield return new WaitForSeconds(2f);
        gameObject.transform.position = gameObject.transform.position + new Vector3(0f, -0.8f, 0f);
        rb.bodyType = RigidbodyType2D.Dynamic;
        
    }
}


using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject PlayerBall;

	
	void Update () {
        gameObject.transform.position = new Vector3(-0.1f, PlayerBall.transform.position.y + 4f,-10f);
	}
}

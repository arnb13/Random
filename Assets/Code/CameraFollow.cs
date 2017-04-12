using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Vector3 velocity;
    public float timeX = 0.05f;
    public float timeY = 0.05f;

    public GameObject player;
     
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, timeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, timeY);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}

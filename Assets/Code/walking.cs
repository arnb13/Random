using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class walking : MonoBehaviour {

    Rigidbody2D rb;
    Animator a;

    public float speed = 10;
    public static float velX = 0;
    public static float velY = 0;
    Vector2 max = new Vector2(3, 5);
    public bool j = false;
    
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        velX = 0;
        velY = 0;


        float absX = Mathf.Abs(rb.velocity.x);


        

        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0)
        {
            if(absX < max.x)
            {
                velX = speed;
            }
            transform.localScale = new Vector3(1, 1, 1);
            a.SetInteger("anim", 1);
        } else if(CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
            if (absX < max.x)
            {
                velX = -speed;
            }
            transform.localScale = new Vector3(-1, 1, 1);
            a.SetInteger("anim", 1);
        } else
        {
            a.SetInteger("anim", 0);
        }
        rb.AddForce(new Vector2(velX, velY));
        
    }
    public void jump0()
    {


        float absY = Mathf.Abs(rb.velocity.y);
        if (absY < 0.2)
        {
            rb.velocity = new Vector2(0, 7);
        }

    }
    public void jump1()
    {
        velY = 0;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 0.1f;
    [Range(1,10)] public float vel = 5f;
    [SerializeField] private Rigidbody2D craigsRigidbody;

    public int HP = 100;

    private void Awake()
    {
        //Debug.Log("Craig is a sparkle in his fathers eye...");
    }

    // Use this for initialization
    void Start () {
        //Debug.Log("CRAIG WAS BORN");
        craigsRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Craig breathes...");
        //Debug.Log("X = " + transform.position.x + ", Y= " + transform.position.y);
        if (HP > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                craigsRigidbody.velocity = new Vector2(0, vel);
                //transform.position = new Vector3(transform.position.x, transform.position.y+ moveSpeed, transform.position.z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                craigsRigidbody.velocity = new Vector2(-vel, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                craigsRigidbody.velocity = new Vector2(0, -vel);
            }
            if (Input.GetKey(KeyCode.D))
            {
                craigsRigidbody.velocity = new Vector2(vel, 0);
            }
        }
        else
        {
            //dead code
        }

    }

    public void doDamage(int amountOfDamage)
    {
        HP -= amountOfDamage;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "hurtything")
    //    {
    //        HP -= 10;
    //        Debug.Log("HP: " + HP);
    //    }    
    //}

}

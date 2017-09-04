using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtyThing : MonoBehaviour {
    public PlayerController craig;
    public int damageAmount;

    private void Start()
    {
        //craig = FindObjectOfType<PlayerController>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            craig.doDamage(damageAmount);
            //Debug.Log("HP: " + craig.HP);
        }
    }
}

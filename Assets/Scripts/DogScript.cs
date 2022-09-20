using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    public Animation dogstay;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "RipTag")
        {
            Game.aliveDog = false;
            Game.changeHomeOrRes = true;
            if (Game.oneAnimAlive == false)
            {
                dogstay.Play("dogrip");
            }
        }
        if (collision.gameObject.tag == "BirdTag")
        {
            Game.aliveDog = false;
            Game.changeHomeOrRes = true;
            if (Game.oneAnimAlive == false)
            {
                dogstay.Play("dogrip");
            }
        }
    }
}

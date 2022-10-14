using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    public Animation dogstay;

    public GameObject adManager;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "RipTag")
        {
            if (Game.aliveDog == true)
            {
                if (Game._isAd == true)
                {
                    Game.liveToAd++;
                    if (Game.liveToAd >= 4)
                    {
                        Game.goShowAd = true;

                        adManager = GameObject.FindGameObjectWithTag("AdManagerTag");
                        adManager.GetComponent<butda2haX>().ShowAd();
                    }
                }
            }

            Game.aliveDog = false;

           



            Game.changeHomeOrRes = true;
            if (Game.oneAnimAlive == false)
            {
                dogstay.Play("dogrip");
            }
        }
        if (collision.gameObject.tag == "BirdTag")
        {
            if(Game.aliveDog == true)
            {
                if (Game._isAd == true)
                {
                    Game.liveToAd++;
                    if (Game.liveToAd >= 4)
                    {
                        Game.goShowAd = true;

                        adManager = GameObject.FindGameObjectWithTag("AdManagerTag");
                        adManager.GetComponent<butda2haX>().ShowAd();
                    }
                }
            }

            Game.aliveDog = false;
            Game.changeHomeOrRes = true;

            


            if (Game.oneAnimAlive == false)
            {
                dogstay.Play("dogrip");
            }
        }
    }
}

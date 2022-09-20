using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnims : MonoBehaviour
{
    public Animation dogstay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Game.aliveDog == true)
        {
            dogstay.Play("dogstay");
        }
    }
}

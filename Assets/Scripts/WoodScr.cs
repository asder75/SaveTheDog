using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodScr : MonoBehaviour
{
    public Animation woodanim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Game.aliveDog == true)
        {
            woodanim.Play("woodanim");
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }
}

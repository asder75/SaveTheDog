using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCir : MonoBehaviour
{
    public Animation circlewood;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Game.aliveDog == true)
        {
            circlewood.Play("circlewood");
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }
}

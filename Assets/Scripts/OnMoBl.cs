using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMoBl : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        Game.onMouseBlock = true;
    }
    private void OnMouseExit()
    {
        Game.onMouseBlock = false;
    }
}

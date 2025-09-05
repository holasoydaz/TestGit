using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public float coins;
    void Start()
    {

        GetComponent<BoxCollider>().isTrigger = true;

        coins++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public float coins;
    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

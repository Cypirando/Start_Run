using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGrid : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }

}
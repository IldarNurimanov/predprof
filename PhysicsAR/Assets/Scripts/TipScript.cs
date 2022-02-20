using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipScript : MonoBehaviour
{
    public GameObject text;
    public GameObject info;
    public GameObject positioner;
    public GameObject obj;
    void Update()
    {
        if (obj.GetComponent<MeshRenderer>().enabled){
            text.SetActive(false);
            info.SetActive(true);
            positioner.SetActive(false);
        }   
    }
}

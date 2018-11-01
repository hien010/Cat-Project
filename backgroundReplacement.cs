using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundReplacement : MonoBehaviour {
    public GameObject backgroundDestructionPoint;


    void Start()
    {
        backgroundDestructionPoint = GameObject.Find("GroundDestroyPoint");
    }


    void Update()
    {
        if (transform.position.x < backgroundDestructionPoint.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + 85,
                                             transform.position.y,
                                             transform.position.z);
        }
    }
}

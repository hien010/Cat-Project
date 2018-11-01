using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestructer : MonoBehaviour {

    public GameObject groundDestructionPoint;

    void Start()
    {
        groundDestructionPoint = GameObject.Find("GroundDestroyPoint");
    }


    void Update()
    {
        if (transform.position.x < groundDestructionPoint.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + 130,
                                             transform.position.y,
                                             transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public CatPlayer thePlayer;
    public Vector3 lastPlayerPosition;
    public float distancetToMove;

	void Start () {
        thePlayer = FindObjectOfType<CatPlayer>();
        lastPlayerPosition = thePlayer.transform.position;
    }
	
	void Update () {
        distancetToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
        transform.position = new Vector3(lastPlayerPosition.x + distancetToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
	}
}

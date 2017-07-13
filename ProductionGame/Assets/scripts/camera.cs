using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {


    public Transform playerT;

    public float xOffSet = -15f;
    public float yOffSet = 8f;
    public float zOffSet = 0f;


    void Update ()
    {
        transform.position = new Vector3(playerT.position.x + xOffSet, playerT.position.y + yOffSet, playerT.position.z + zOffSet);
	}
}

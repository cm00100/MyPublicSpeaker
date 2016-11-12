using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	void Start () {
        offset = transform.position;
	}
	
	// Update is called once per frame
	void LastUpdate () {
        transform.position = player.transform.position + offset;
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTanks : MonoBehaviour {

    public Transform player1;
    public Transform player2;

    private Vector3 offset;

    private Camera camera;

	void Start () {
        offset = transform.position - (player1.position + player2.position) / 2;
        camera = gameObject.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player1 == null || player2 == null) return;
         transform.position = (player1.position + player2.position) / 2 + offset;
         float distance = Vector3.Distance(player1.position, player2.position);
         float size = distance * 1.4f;
         camera.orthographicSize = size;
       
	}
}

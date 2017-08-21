using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShell : MonoBehaviour {

    private Transform firePosition;

    public GameObject shell;
    public KeyCode key;

    public float shellSpeed = 10;

    public AudioClip audioFire;
	// Use this for initialization
	void Start () {
        firePosition = gameObject.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key)) {
            AudioSource.PlayClipAtPoint(audioFire, transform.position, 2);
            GameObject s =  GameObject.Instantiate(shell, firePosition.position, firePosition.rotation);
            s.GetComponent<Rigidbody>().velocity = s.transform.forward * shellSpeed;

        }
	}
}

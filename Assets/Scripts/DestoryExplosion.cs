using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryExplosion : MonoBehaviour {

    public float t = 1.5f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, t);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

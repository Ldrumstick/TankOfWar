using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosion : MonoBehaviour {

    public GameObject explosion;
    public AudioClip audioShellExplosion;

	void Start () {
        
	}
	

	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(audioShellExplosion, other.transform.position, 2);
        GameObject.Instantiate(explosion, transform.position, transform.rotation);  
        Destroy(this.gameObject);

        if (other.tag == "Tank") {
            other.SendMessage("TakeDamage");
        }
    }
}

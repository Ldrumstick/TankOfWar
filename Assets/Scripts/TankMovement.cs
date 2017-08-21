using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

    public float speed = 5.0f;
	public float angularSpeed = 10.0f;
	public int num = 1;

	private Rigidbody m_rigidbody;

    public AudioClip audioIdle;
    public AudioClip audioDriving;

    private AudioSource audio;

	// Use this for initialization
	void Start () {

		m_rigidbody = gameObject.GetComponent<Rigidbody> ();

        audio = gameObject.GetComponent<AudioSource>();
	}
	
	void Update () {
		float v = Input.GetAxis ("VerticalPlay" + num);
		m_rigidbody.velocity = transform.forward * v * speed;

		float h = Input.GetAxis ("HorizontalPlay" + num);
		m_rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if ((Mathf.Abs(v) >= 0.1) || (Mathf.Abs(h) >= 0.1))
        {
            if (audio.isPlaying == false)
            {
                audio.clip = audioDriving;
                audio.Play();
            }
        }
        else {
            if (audio.isPlaying == false)
            {
                audio.clip = audioIdle;
                audio.Play();
            }
        }
	}
}

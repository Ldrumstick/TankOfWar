using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;
    public GameObject tankExplosion;
    public AudioClip audioTankExplosion;

    public Slider hpSlider;

    private int hpTotal;
	void Start () {
        hpTotal = hp;
	}
	
	void Update () {
		
	}

    void TakeDamage() {

        if (hp <= 0) return;
        hp -= Random.Range(10, 20);
        hpSlider.value = (float)hp / hpTotal;
        if (hp <= 0) {
            AudioSource.PlayClipAtPoint(audioTankExplosion, transform.position, 2.0f);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}

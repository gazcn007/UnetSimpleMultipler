using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		Debug.Log (col.gameObject.name);
		if (col.gameObject.name == "Player(Clone)"||col.gameObject.name == "Enemy(Clone)") {
			GameObject hit = col.gameObject;
			Health health = hit.GetComponent<Health> ();
			if (health != null) {
				health.TakeDamage (10);
			}
			Destroy(this.gameObject);
		}
	}
}

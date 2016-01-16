using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag(k_Tags.Trigger)){
			//this.gameObject.SetActive(false);
		}
	}

}

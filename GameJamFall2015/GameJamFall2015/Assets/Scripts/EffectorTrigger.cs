using UnityEngine;
using System.Collections;

public class EffectorTrigger : MonoBehaviour {

    public GameObject Effector;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Bullet")){
            if (Effector.activeInHierarchy) {
                Effector.SetActive(false);
                other.gameObject.SetActive(false);
            }
            else {
                Effector.SetActive(true);
            }
        }
    }
}

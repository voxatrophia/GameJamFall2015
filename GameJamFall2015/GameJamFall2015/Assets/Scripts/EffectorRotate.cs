using UnityEngine;
using System.Collections;

public class EffectorRotate : MonoBehaviour {

    public float rotateSpeed;


    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(k_Tags.Freeze)) {
            rotateSpeed = 0;
        }
    }

}

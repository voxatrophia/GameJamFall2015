using UnityEngine;
using System.Collections;

public class Catcher : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(k_Tags.Player)) {
            //Debug.Log("Game Over");
            GameManager.i.ResetGame();
        }
    }

}

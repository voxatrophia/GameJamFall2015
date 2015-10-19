using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(k_Tags.Player)){
            //Play sound effect
            //Particle effect
            GameManager.i.NextLevel();
        }
    }

}

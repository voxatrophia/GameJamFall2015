using UnityEngine;
using System.Collections;

public class TriggerFreeze : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(k_Tags.Player))
        {
            EventManager.TriggerEvent(k_Triggers.Freeze);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(k_Tags.Player))
        {
            EventManager.TriggerEvent(k_Triggers.Clear);
        }
    }
}

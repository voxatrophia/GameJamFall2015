using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIAction : MonoBehaviour {

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void OnEnable()
    {
        EventManager.StartListening(k_Triggers.Clear, ClearAction);
        EventManager.StartListening(k_Triggers.Jump, SetJump);
        EventManager.StartListening(k_Triggers.Shoot, SetShoot);
        EventManager.StartListening(k_Triggers.Freeze, SetFreeze);
    }

    void OnDisable()
    {
        EventManager.StopListening(k_Triggers.Clear, ClearAction);
        EventManager.StopListening(k_Triggers.Jump, SetJump);
        EventManager.StopListening(k_Triggers.Shoot, SetShoot);
        EventManager.StopListening(k_Triggers.Freeze, SetFreeze);
    }
    
    void ClearAction() {
        text.text = "";
    }

    void SetJump()
    {
        text.text = "Jump";
    }
    void SetShoot()
    {
        text.text = "Shoot";
    }
    void SetFreeze()
    {
        text.text = "Freeze";
    }

}

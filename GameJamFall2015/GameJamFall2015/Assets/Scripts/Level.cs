using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level : MonoBehaviour {
    Text levelText;
    void Start() {
        levelText = GetComponent<Text>();
        levelText.text = "Level " + Application.loadedLevel;
    }

}

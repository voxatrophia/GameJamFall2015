using UnityEngine;
using System.Collections;
using SimpleJSON;

class DataElement{
	public float posX;
	public float posY;
	public float rot;
	bool startEnabled;
}

public class SaveLevel : MonoBehaviour {

	GameObject[] elements;
	DataElement[] data;

	public void CountElements(){
		elements = GameObject.FindGameObjectsWithTag("Element");
		Debug.Log(elements.Length);

		data = new DataElement[elements.Length];
		for(int i = 0; i < elements.Length; i++){
			data[i] = new DataElement();
			data[i].posX = elements[i].transform.position.x;
			data[i].rot = elements[i].transform.eulerAngles.z;
		}

		Debug.Log(data[0].rot);
	}
}

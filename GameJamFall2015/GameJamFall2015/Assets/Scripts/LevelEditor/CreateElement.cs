using UnityEngine;
using System.Collections;

public class CreateElement : MonoBehaviour {

	public GameObject prefab;
	public Transform parentObject;
	private Vector3 screenPoint;
	private Vector3 offset;
	Collider2D col;
	GameObject newElement;

	public void OnMouseDown()
	{

		//gets the offset between the mouse position and gameObject position
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		newElement = (GameObject)Instantiate(prefab, screenPoint, Quaternion.identity);
	}
	
	void OnMouseDrag()
	{
		//sets the gameObject position equal to mouse positon plus offset
		if(newElement != null){
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			newElement.transform.position = curPosition;
		}
	}

	void OnMouseUp(){

	}
}

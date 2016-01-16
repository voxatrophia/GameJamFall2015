using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class DragObject : MonoBehaviour 
{
		
	private Vector3 screenPoint;
	private Vector3 offset;
	Collider2D col;

	void Start(){
		col = GetComponent<Collider2D> ();
	}

	void OnMouseDown()
	{
		//gets the offset between the mouse position and gameObject position
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

		//Changes layer to interact with core
//		gameObject.layer = 8;
		//Send this object to CoreCombos script
//		CoreCombos.i.setItem (col);
	}
	
	void OnMouseDrag()
	{
		//sets the gameObject position equal to mouse positon plus offset
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

	void OnMouseUp(){
		//Stop dragging, so change layer back (if not destroyed on collision)
//		gameObject.layer = 0;
	}
}

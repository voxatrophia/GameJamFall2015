using UnityEngine;
using System.Collections;

public class ObjectRotator : MonoBehaviour {

	private Vector3 mousePoint;
	private Vector3 newPoint;
	public float multiplier = 1f;
	float difference;

	public void RotateObject(float rotate){
	 		Vector3 temp = new Vector3(0,0,rotate);
	 		transform.eulerAngles = temp;
	}

	// void OnMouseDown(){
	// 	mousePoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	// }

	// void OnMouseDrag(){
	// 	newPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	// 	if(newPoint != mousePoint){
	// 		difference = gameObject.transform.position.y - newPoint.y;
	// 		rotate = difference * multiplier;

	// 		Vector3 temp = new Vector3(0,0,transform.eulerAngles.z + rotate);
	// 		transform.eulerAngles = temp;

	// 		mousePoint = newPoint;

	// 	}
	// }

}
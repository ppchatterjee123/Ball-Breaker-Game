using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 PaddlePosition = new Vector3 ( 0.5f, this.transform.position.y ,0f);;
	//print (Input.mousePosition.x / Screen.width * 16);
		float MousePosInBlocks = Input.mousePosition.x / Screen.width * 8;
	// print (MousePosInBlocks);
	
		PaddlePosition.x = Mathf.Clamp(MousePosInBlocks, 0.5f ,7.5f);;
		
		
	
		this.transform.position = PaddlePosition ; 
	
	}
}

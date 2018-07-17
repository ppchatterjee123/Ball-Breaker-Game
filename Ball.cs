using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
private bool hasstarted = false;

public paddle paddle; 
private Vector3 paddletoball;
	// Use this for initialization
	void Start () {
	paddletoball = this.transform.position - paddle.transform.position;
	// print(paddletoball.y);            0.296
	}
	
	// Update is called once per frame
	void Update () {
	if (!hasstarted){
	//lock the ball to the paddle
	this.transform.position = paddle.transform.position + paddletoball;
	
	if(Input.GetMouseButtonDown(0))
	{
	print("mouseclicked");
	//unlock the ball after start game with true bool
	hasstarted = true;
	this.rigidbody2D.velocity = new Vector2(2f, 6f);
	}
	}
	}
}

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	
	
	private bool hasStarted = false;
	private bool canClick = true;
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start () {
		//get ball distance relative to the paddle
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted){
			//set ball position so it sit atop paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}
		
		//if mouse clciked down...
		if(canClick && Input.GetMouseButtonDown(0)){
			hasStarted = true;
			//add velocity to ball from paddle to launch
			this.rigidbody2D.velocity  = new Vector2(0,15);
			canClick = false;
		}
		
	}
	void OnCollisionEnter2D(Collision2D collision){
		if(hasStarted){
			audio.Play();
		}
	}
}

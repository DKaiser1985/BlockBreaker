using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;
	// Use this for initialization
	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
			
	}
	
	void OnTriggerEnter2D(Collider2D trigger){
		Debug.Log("Trigger");
	}
	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log("Collision");
		levelManager.LoadLevel("Lose Screen");
		Brick.breakableCount = 0;
	}
}

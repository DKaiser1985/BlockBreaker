using UnityEngine;
using System.Collections;


	
public class Brick : MonoBehaviour {
	public int maxHits;
	
	private LevelManager levelManager;
	private int timesHit;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		//Programaticly find Level Manager
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		
	}
	
	void OnCollisionEnter2D(){
		timesHit++;
		if(timesHit >= maxHits){
			Destroy(gameObject);
		}
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	//TODO Remove once game can be won
	public void SimulateWin(){
		//Call laod Next Level from levelManager
		levelManager.LoadNextLevel();
	}
}

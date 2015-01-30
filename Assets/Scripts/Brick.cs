using UnityEngine;
using System.Collections;


	
public class Brick : MonoBehaviour {
	public static int breakableCount = 0;
	public Sprite[] hitSprites;	
	
	private LevelManager levelManager;
	private int timesHit;
	public bool isBreakable;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		isBreakable = (this.tag == "Breakable");
		if (isBreakable){
			breakableCount++;
			print(breakableCount);
		}
		
		//Programaticly find Level Manager
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		
	}
	
	void OnCollisionEnter2D(){
		if (isBreakable == true){
			HandleHits();
			print(breakableCount);
		}
		
	}
	
	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits){
			breakableCount--;
			Destroy(gameObject);
			levelManager.BrickDestroyed();
			
		}else{
			LoadSprites();
		}
	
	}
	// Update is called once per frame
	void Update () {

		
	}
	void LoadSprites(){
		int spriteIndex = timesHit -1;
		if(hitSprites[spriteIndex]){
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	//TODO Remove once game can be won
	public void SimulateWin(){
		//Call laod Next Level from levelManager
		levelManager.LoadNextLevel();
	}
}
using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	
	static Music instance = null;
	
	void Awake() {
		if (instance != null){
		Destroy(gameObject);
		Debug.Log("Music Player Destroyed");
		Debug.Log("Music Player Awake " + GetInstanceID());
	}else{
		instance = this;
		GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

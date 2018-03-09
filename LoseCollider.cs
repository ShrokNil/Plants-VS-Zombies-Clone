using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	public LevelManager sceneManager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		sceneManager = GameObject.FindObjectOfType<LevelManager>();
		sceneManager.LoadLevel("Lose");
	}
		
	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}

}

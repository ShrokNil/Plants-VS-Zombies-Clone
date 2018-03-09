using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
	print (PlayerPrefsManager.GetMasterVolume());
	PlayerPrefsManager.SetMasterVolume (0.8f);
	print (PlayerPrefsManager.GetDifficulty());
	PlayerPrefsManager.SetDifficulty (2f);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}

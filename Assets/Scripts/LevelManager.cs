﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level){
		print (""+level);
		Application.LoadLevel(level);
	}
}

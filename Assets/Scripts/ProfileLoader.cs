﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Utils;

public class ProfileLoader : MonoBehaviour {

    // Use this for initialization
    public Text text;
	void Start () {
		if (GameSettings.user != null) {
			GetComponent<Image> ().sprite =
				Sprite.Create (GameSettings.user.profile_pic, 
					new Rect (0, 0, 128, 128), new Vector2 ());

            text.text = GameSettings.user.first_name;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

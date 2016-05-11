using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HudController : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> vidas;

    int vida;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        vida = PlayerPrefs.GetInt("vida");

        switch(vida)
        {
            case 3:
                vidas[0].SetActive(true);
                vidas[1].SetActive(true);
                vidas[2].SetActive(true);
                break;
            case 2:
                vidas[2].SetActive(false);
                break;
            case 1:
                vidas[2].SetActive(false);
                vidas[1].SetActive(false);
                break;
        }

	}
}

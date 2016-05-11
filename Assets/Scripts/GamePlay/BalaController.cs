using UnityEngine;
using System.Collections;

public class BalaController : MonoBehaviour {

    // Use this for initialization
    float maxY;
    float minY;

    public static BalaController instance;

    public int puntaje;
	void Start () {
        puntaje = 0;
        setBoundsXY();
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 5f * Time.deltaTime, 0f);
        
        if(transform.position.y >= maxY)
        {
            PlayerPrefs.SetInt("puntaje", BalaController.instance.puntaje);
            gameObject.SetActive(false);
        }
	}

    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
                             Screen.width, Screen.height, 0));
        maxY = bounds.y - 0.5f;
        minY = -bounds.y + 0.5f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch(col.gameObject.tag)
        {
            case "nave1":
                puntaje += 100;
                col.gameObject.SetActive(false);
                gameObject.SetActive(false);
                break;

            case "nave2":
                puntaje += 150;
                col.gameObject.SetActive(false);
                gameObject.SetActive(false);
                break;

            case "nave3":
                puntaje += 250;
                col.gameObject.SetActive(false);
                gameObject.SetActive(false);
                break;
        }
        PlayerPrefs.SetInt("puntaje", BalaController.instance.puntaje);
    }
}

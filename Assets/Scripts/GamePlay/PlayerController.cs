using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    // Use this for initialization


    private int isLeft;
    private int isRight;
    private int isFire;

    public GameObject balaSpawner;
    public GameObject bala;
    public Text textPuntaje;

    public int vida;
    int puntaje;

    private float maxX, minX;
    void Start () {

        PlayerPrefs.DeleteAll();
        setBoundsXY();
        vida = 3;
    }
	
	// Update is called once per frame
	void Update () {
        UpdateButtons();
        UpdateScore();
        if(isLeft == 1)
        {
            if(transform.position.x > minX)
            transform.position -= new Vector3(5f * Time.deltaTime, 0f, 0f);
        }
        if(isRight == 1)
        {
            if (transform.position.x < maxX)
                transform.position += new Vector3(5f * Time.deltaTime, 0f, 0f);
        }
        if(isFire == 1)
        {
            if (!bala.activeInHierarchy)
            {
                bala.SetActive(true);
                bala.transform.position = balaSpawner.transform.position;
            }
        }
	}

    void UpdateButtons()
    {
        isLeft = PlayerPrefs.GetInt("left");
        isRight = PlayerPrefs.GetInt("right");
        isFire = PlayerPrefs.GetInt("fire");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        vida--;
        PlayerPrefs.SetInt("vida", vida);
        if (vida <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
   
    void UpdateScore()
    {
        puntaje = PlayerPrefs.GetInt("puntaje");

        textPuntaje.text = "puntaje: " + puntaje;
    }

    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
                             Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }

}

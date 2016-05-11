using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    // Use this for initialization
    public Button restartBtn;
    public Text text;
	void Start () {
        restartBtn.onClick.AddListener(() => Restart());
        text.text = "puntaje: " + PlayerPrefs.GetInt("puntaje");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Restart()
    {
        SceneManager.LoadScene("GamePlay");
    }
}

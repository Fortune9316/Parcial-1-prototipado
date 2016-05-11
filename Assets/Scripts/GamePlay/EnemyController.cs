using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyController : MonoBehaviour {

    // Use this for initialization
    float cont;
    public List<GameObject> enemigos;
    public GameObject enemySpawner;

    private float maxX, minX;


	void Start () {
        cont = 0f;
        setBoundsXY();
	}
	
	// Update is called once per frame
	void Update () {
        cont += Time.deltaTime;
        if(cont >= 1f)
        {
          
                int random = Random.Range(0, enemigos.Count);
                if (!enemigos[random].activeInHierarchy)
                {
                    enemigos[random].SetActive(true);
                    enemigos[random].transform.position = new Vector3(Random.RandomRange(minX, maxX), enemySpawner.transform.position.y, enemySpawner.transform.position.z);
                  
                }
          
            cont = 0f;
        }

	}

    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
                             Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }
}

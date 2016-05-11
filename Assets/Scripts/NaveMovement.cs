using UnityEngine;
using System.Collections;

public class NaveMovement : MonoBehaviour {

    // Use this for initialization
    float maxY;
    float minY;
    void Start () {
        setBoundsXY();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(0f, 5f * Time.deltaTime, 0f);

        if (transform.position.y <= minY)
        {
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
}

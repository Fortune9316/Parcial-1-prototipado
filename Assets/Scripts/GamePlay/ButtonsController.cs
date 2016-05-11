using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class ButtonsController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    void Start()
    {


    }

    public void OnPointerDown(PointerEventData data)
    {
        switch (gameObject.name)
        {
            case "BtnLeft":
                PlayerPrefs.SetInt("left", 1);
                break;
            case "BtnRight":
                PlayerPrefs.SetInt("right", 1);
                break;
            case "BtnFire":
                PlayerPrefs.SetInt("fire", 1);
                break;
        }
    }

    public void OnPointerUp(PointerEventData data)
    {
        switch (gameObject.name)
        {
            case "BtnLeft":
                PlayerPrefs.SetInt("left", 0);
                break;
            case "BtnRight":
                PlayerPrefs.SetInt("right", 0);
                break;
            case "BtnFire":
                PlayerPrefs.SetInt("fire", 0);
                break;
        }
    }

}

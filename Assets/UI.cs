using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject circle;   //in the real app, you would probably use FindGameObjectWithTag or something instead

    private Circle circleScript;

    void Start()
    {
        circleScript = circle.GetComponent<Circle>();
    }

    void OnMouseDown()
    {
        Debug.Log("clicked");
        circleScript.CircleAnim();
    }
}

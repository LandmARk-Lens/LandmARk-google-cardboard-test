using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

    public GameObject panel;    //remove this later; circle should call line and line should call panel;
    Panel panelScript;

    public int size = 20;

    public bool isGrowing = true;

	public void CircleAnim()
    {
        StartCoroutine("Grow");
    }

    void Start()
    {
        panelScript = panel.GetComponent<Panel>();
    }

    void Update()
    {
        if (!isGrowing) //if the Grow coroutine has finished
        {
            Debug.Log("isGrowing");
            StartCoroutine("Shrink");
            isGrowing = true;
            panelScript.StartPanel();
        }
    }

    IEnumerator Grow()
    {
        for (int i = 0; i <= size; i++)
        {
            gameObject.transform.localScale = new Vector3(i, i, 0);
            if (i >= size)
            {
                isGrowing = false;
            }
            yield return new WaitForSeconds(.005f);
        }
    }

    IEnumerator Shrink()
    {
        for (int j = size; j >= 0; j--)
        {
            gameObject.transform.localScale = new Vector3(j, j, 0);
            yield return new WaitForSeconds(.005f);
        }
    }
}

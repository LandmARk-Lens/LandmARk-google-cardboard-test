using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour {

    public int size = 200;

    private RectTransform rt;
    private float width;

    void Start()
    {
        rt = gameObject.GetComponent<RectTransform>();
        width = rt.sizeDelta.x;
    }

	public void StartPanel()
    {
        StartCoroutine("PanelGrow");
    }

    IEnumerator PanelGrow()
    {
        for (int i = 0; i < size; i += 5)
        {
            rt.sizeDelta = new Vector2(width, i);
            yield return new WaitForSeconds(.001f);
        }
    }
}

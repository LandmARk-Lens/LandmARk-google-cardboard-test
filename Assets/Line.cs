using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    public GameObject circle;   //for now, just drag the references in the inspector
    public GameObject panel;

    public Vector3 circlePos;
    public Vector3 panelPos;

    private Vector3 midpoint;

    private LineRenderer lr;

	public void StartLine()
    {
        circlePos = circle.transform.position;
        panelPos = panel.transform.position;
        midpoint = new Vector3((circlePos.x + panelPos.x) / 2, panelPos.y, 0);

        lr = gameObject.GetComponent<LineRenderer>();
        lr.SetPosition(0, circlePos);
        lr.SetPosition(1, circlePos);
        lr.SetPosition(2, circlePos);
    }

    IEnumerator LineGrow()
    {
        //for (int i = )
        yield return new WaitForSeconds(.1f);
    }
}

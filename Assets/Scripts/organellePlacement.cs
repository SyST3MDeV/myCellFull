using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organellePlacement : MonoBehaviour {
    public buyViewManager buyManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp()
    {
        if (buyManager.getBuyMode())
        {
            Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition).x);
            Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            buyManager.placeOrganelle(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y));
        }
    }
}

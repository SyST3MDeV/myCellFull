using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOnTab : MonoBehaviour {
    public navigationManager navigationManager;
    public int tabToShowOn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(navigationManager.getCurrentTab() == tabToShowOn)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationManager : MonoBehaviour {
    private int currentTab = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getCurrentTab()
    {
        return currentTab;
    }

    public void setCurrentTab(int tabToSet)
    {
        currentTab = tabToSet;
    }
}

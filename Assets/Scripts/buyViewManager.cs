using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyViewManager : MonoBehaviour {
    public Image mitochondria;
    public Image chloroplast;
    public Image vacuole;
    public Image test;
    public navigationManager navManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (navManager.getCurrentTab() == 2)
        {
            mitochondria.gameObject.SetActive(true);
            chloroplast.gameObject.SetActive(true);
            vacuole.gameObject.SetActive(true);
            test.gameObject.SetActive(true);
        }
        else
        {
            mitochondria.gameObject.SetActive(false);
            chloroplast.gameObject.SetActive(false);
            vacuole.gameObject.SetActive(false);
            test.gameObject.SetActive(false);
        }
	}
}

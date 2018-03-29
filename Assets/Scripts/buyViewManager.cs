using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyViewManager : MonoBehaviour {
    public Image mitochondria;
    public Image mitochondriaBuy;
    public Image mitochondriaInfo;
    public Image mitochondriaDescription;
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
            //Mitochondria
            mitochondria.gameObject.SetActive(true);
            mitochondriaBuy.gameObject.SetActive(true);
            mitochondriaInfo.gameObject.SetActive(true);
            mitochondriaDescription.gameObject.SetActive(true);

            chloroplast.gameObject.SetActive(true);
            vacuole.gameObject.SetActive(true);
            test.gameObject.SetActive(true);
        }
        else
        {
            //Mitochondria
            mitochondria.gameObject.SetActive(false);
            mitochondriaBuy.gameObject.SetActive(false);
            mitochondriaInfo.gameObject.SetActive(false);
            mitochondriaDescription.gameObject.SetActive(false);

            chloroplast.gameObject.SetActive(false);
            vacuole.gameObject.SetActive(false);
            test.gameObject.SetActive(false);
        }
	}
}
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
    public Image placeText;
    public Image buyShade;
    public navigationManager navManager;
    public bool buyMode;
    public GameObject mitochondriaPrefab;
    public resourceManager resourceManager;
    Vector2 placeToPut;
    bool isTouched = false;

    private bool itemIsSelected = false;
    private string itemSelected = "";
    private int amountSelected;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        if (navManager.getCurrentTab() == 2)
        {
            //Mitochondria
            mitochondria.gameObject.SetActive(true);
            mitochondriaBuy.gameObject.SetActive(true);
            //mitochondriaInfo.gameObject.SetActive(true);
            mitochondriaDescription.gameObject.SetActive(true);

            buyShade.enabled = true;
            chloroplast.gameObject.SetActive(true);
            vacuole.gameObject.SetActive(true);
            test.gameObject.SetActive(true);
        }
        else
        {
            //Mitochondria
            mitochondria.gameObject.SetActive(false);
            mitochondriaBuy.gameObject.SetActive(false);
            //mitochondriaInfo.gameObject.SetActive(false);
            mitochondriaDescription.gameObject.SetActive(false);

            buyShade.enabled = false;
            chloroplast.gameObject.SetActive(false);
            vacuole.gameObject.SetActive(false);
            test.gameObject.SetActive(false);
        }

        if (itemIsSelected && navManager.getCurrentTab() == 1)
        {
            buyMode = true;
        }

        if (buyMode)
        {
            placeText.gameObject.SetActive(true);
            if (isTouched)
            {
                Instantiate(mitochondriaPrefab, placeToPut, Quaternion.identity);
                amountSelected--;
                isTouched = false;
            }

            if(amountSelected == 0)
            {
                buyMode = false;
                itemIsSelected = false;
                itemSelected = "";
                amountSelected = 0;
            }
            //Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position)
        }
        else
        {
            placeText.gameObject.SetActive(false);
        }
	}

    public bool getItemIsSelected()
    {
        return itemIsSelected;
    }

    public string getItemSelected()
    {
        return itemSelected;
    }

    public void selectItem(string itemToSelect)
    {
        if(itemSelected == itemToSelect)
        {
            amountSelected++;
        }
        else
        {
            itemSelected = itemToSelect;
            amountSelected = 1;
            itemIsSelected = true;
        }
    }

    public void cancelPurchase()
    {
        buyMode = false;
        itemIsSelected = false;
        if(itemSelected == "mitochondria")
        {
            resourceManager.addResource("ATP", amountSelected);
        }
        itemSelected = "";
        amountSelected = 0;
    }

    public bool getBuyMode()
    {
        return buyMode;
    }

    public void placeOrganelle(Vector2 placeToInstantiate)
    {
        placeToPut = placeToInstantiate;
        isTouched = true;
    }
}
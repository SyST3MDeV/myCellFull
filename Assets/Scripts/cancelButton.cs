using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelButton : MonoBehaviour {
    public buyViewManager buyManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (buyManager.getBuyMode())
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
	}

    void OnMouseDown()
    {
        Debug.Log("Cancel Registered");
        buyManager.cancelPurchase();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyButton : MonoBehaviour {
    public Sprite normal;
    public Sprite disabled;
    public Sprite disabledDueToCost;
    public Sprite selected;
    public Image buyButtonToChange;
    public buyViewManager buyManager;
    public resourceManager resourceManager;
    public int costOfOrganelle;
    public string nameOfOrganelle;

    private bool isSelected = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (buyManager.getItemIsSelected() && !(buyManager.getItemSelected() == nameOfOrganelle))
        {
            buyButtonToChange.sprite = disabled;
        }
        else if (resourceManager.getResource("ATP") < costOfOrganelle)
        {
            buyButtonToChange.sprite = disabledDueToCost;
        }
        else if (isSelected)
        {
            buyButtonToChange.sprite = selected;
        }
        else
        {
            buyButtonToChange.sprite = normal;
        }
	}

    public void OnClick()
    {
        Debug.Log("Click Registered");
        if (!buyManager.getItemIsSelected() && (resourceManager.getResource("ATP") >= costOfOrganelle))
        {
            buyManager.selectItem(nameOfOrganelle);
            resourceManager.addResource("ATP", costOfOrganelle * -1);
        }
        else if((buyManager.getItemSelected() == nameOfOrganelle) && (resourceManager.getResource("ATP") >= costOfOrganelle))
        {
            buyManager.selectItem(nameOfOrganelle);
            resourceManager.addResource("ATP", costOfOrganelle * -1);
        }
    }
}

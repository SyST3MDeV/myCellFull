using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navButton : MonoBehaviour {
    public navigationManager navigationManager;
    public int tabToActivate = 1;
    public Sprite notActive;
    public Sprite active;
    private SpriteRenderer spriteRend;

	// Use this for initialization
	void Start () {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (navigationManager.getCurrentTab() == tabToActivate)
        {
            spriteRend.sprite = active;
        }
        else
        {
            spriteRend.sprite = notActive;
        }
	}

    void OnMouseDown()
    {
        navigationManager.setCurrentTab(tabToActivate);
    }
}

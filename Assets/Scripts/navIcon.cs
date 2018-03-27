using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navIcon : MonoBehaviour {
    public int tabToSelectOn;
    public Sprite notActive;
    public Sprite active;
    public navigationManager navManager;
    private SpriteRenderer spriteRend;

	// Use this for initialization
	void Start () {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (navManager.getCurrentTab() == tabToSelectOn)
        {
            spriteRend.sprite = active;
        }
        else
        {
            spriteRend.sprite = notActive;
        }
    }
}

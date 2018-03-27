using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resourceManager : MonoBehaviour {
    public int ATP = 1;
    public int ATPMax = 5;
    public Text ATPCounter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ATPCounter.text = "ATP: " + ATP.ToString() + "/" + ATPMax.ToString();
	}

    int getResource(string resourceToGet)
    {
        if(resourceToGet == "ATP")
        {
            return ATP;
        }
        else if(resourceToGet == "ATPMax")
        {
            return ATPMax;
        }
        else
        {
            return -1;
        }
    }

    void setResource(string resourceToSet, int numToSetTo)
    {
        if (resourceToSet == "ATP")
        {
            ATP = numToSetTo;
        }
        else if (resourceToSet == "ATPMax")
        {
            ATPMax = numToSetTo;
        }
    }

    void addResource(string resourceToAdd, int numToAdd)
    {
        if (resourceToAdd == "ATP")
        {
            ATP += numToAdd;
        }
        else if (resourceToAdd == "ATPMax")
        {
            ATPMax += numToAdd;
        }
    }
}

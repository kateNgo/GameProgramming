using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour {
    public Renderer rend;
    private int i;
    private int random;
    // Use this for initialization
    void Start () {
        i = 0;
        random = Random.Range(200, 250);
    }
	
	// Update is called once per frame
	void Update () {
        i++;
        Debug.Log(rend.gameObject.name + ": " + i);
        if ((rend.gameObject.CompareTag("Red")) && (i == 100))
        {
            rend.gameObject.SetActive(false);
        }
        else if ((rend.gameObject.CompareTag("Blue")) && (i == random))
        {
            rend.enabled = false;
        }
       
    }
}

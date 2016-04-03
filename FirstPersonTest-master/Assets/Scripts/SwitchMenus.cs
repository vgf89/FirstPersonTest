using UnityEngine;
using System.Collections;

public class SwitchMenus : MonoBehaviour {
    public GameObject destinationMenu;
    public GameObject mainMenu;
	// Use this for initialization
	void Start () {
	
	}

    public void onClick()
    {
        mainMenu.SetActive(false);
        destinationMenu.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
	
	}
}

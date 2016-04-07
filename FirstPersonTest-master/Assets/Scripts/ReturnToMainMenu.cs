using UnityEngine;
using System.Collections;

public class ReturnToMainMenu : MonoBehaviour {
    public GameObject currentMenu;
    public GameObject parentMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Back"))
        {
            currentMenu.SetActive(false);
            parentMenu.SetActive(true);
        }
    }
}

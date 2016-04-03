using UnityEngine;
using System.Collections;

public class ReturnToMainMenu : MonoBehaviour {
    public GameObject currentMenu;
    public GameObject mainMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Back"))
        {
            currentMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}

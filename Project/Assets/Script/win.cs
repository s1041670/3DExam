using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {
    public int count;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void loadnewlevel()
    {
        SceneManager.LoadScene("story");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

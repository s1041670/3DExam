using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mouseClick : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "10F")        //如果是10F就跳轉10F的場景
            {
                loadnewlevel10();
            }
			if (hit.transform.name == "9F")        //如果是10F就跳轉9F的場景
			{
				loadnewlevel9();
			}
			if (hit.transform.name == "8F")        //如果是10F就跳轉8F的場景
			{
				loadnewlevel8();
			}
			if (hit.transform.name == "7F")        //如果是10F就跳轉7F的場景
			{
				loadnewlevel7();
			}
			if (hit.transform.name == "6F")        //如果是10F就跳轉6F的場景
			{
				loadnewlevel6();
			}
			if (hit.transform.name == "5F")        //如果是10F就跳轉5F的場景
			{
				loadnewlevel5();
			}
			if (hit.transform.name == "4F")        //如果是10F就跳轉4F的場景
			{
				loadnewlevel4();
			}
			if (hit.transform.name == "3F")        //如果是10F就跳轉3F的場景
			{
				loadnewlevel3();
			}
			if (hit.transform.name == "2F")        //如果是10F就跳轉2F的場景
			{
				loadnewlevel2();
			}

        }
    }
    public void loadnewlevel10()        //10F場景
    {
        SceneManager.LoadScene("lose");

    }
	public void loadnewlevel9()        //9F場景
	{
		SceneManager.LoadScene("lose9");

	}
	public void loadnewlevel8()        //8F場景
	{
		SceneManager.LoadScene("lose8");

	}
	public void loadnewlevel7()        //7F場景
	{
		SceneManager.LoadScene("lose7");

	}
	public void loadnewlevel6()        //6F場景
	{
		SceneManager.LoadScene("lose6");

	}
	public void loadnewlevel5()        //5F場景
	{
		SceneManager.LoadScene("lose5");

	}
	public void loadnewlevel4()        //4F場景
	{
		SceneManager.LoadScene("lose4");

	}
	public void loadnewlevel3()        //3F場景
	{
		SceneManager.LoadScene("lose3");

	}
	public void loadnewlevel2()        //2F場景
	{
		SceneManager.LoadScene("lose2");

	}

}

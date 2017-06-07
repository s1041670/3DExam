using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeToElevator : MonoBehaviour {
    private int count,find;
    private bool b;

    public Text countText;
    public GameObject camera;
    public GameObject image;
    public Sprite origine, meatballs, meatballs1, meatballs2, meatballs3, meatballs4, Dog_palm, dogPalmFin;

    // Use this for initialization
    void Start()
    {
        count = 0;
        find = 0;
        b = false;
    }
    // Update is called once per frame
    void Update()
    {
        //Ray相關的都是滑鼠點擊
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Sprite temp;
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
            Debug.Log(hit.transform.tag);       //顯示你點擊的是什麼
            if (hit.transform.tag == "collect")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    count = count + 1;
                    countText.text = "已收集到的物品：" + count.ToString();
                }
                switch (hit.transform.name)
                {
                    case "Middle meatballs":
                        hit.transform.gameObject.SetActive(false);
                        temp = meatballs;
                        find++;
                        StartCoroutine("nowPlay",temp);
                        break;
                    case "meatballs1":
                        hit.transform.gameObject.SetActive(false);
                        temp = meatballs1;
                        find++;
                        StartCoroutine("nowPlay", temp);
                        break;
                    case "meatballs2":
                        hit.transform.gameObject.SetActive(false);
                        temp = meatballs2;
                        find++;
                        StartCoroutine("nowPlay", temp);
                        break;
                    case "meatballs3":
                        hit.transform.gameObject.SetActive(false);
                        temp = meatballs3;
                        find++;
                        StartCoroutine("nowPlay", temp);
                        break;
                    case "meatballs4":
                        hit.transform.gameObject.SetActive(false);
                        temp = meatballs4;
                        find++;
                        StartCoroutine("nowPlay", temp);
                        break;
                    case "Dog palm":
                        hit.transform.gameObject.SetActive(false);
                        temp = Dog_palm;
                        b = true;
                        StartCoroutine("nowPlay", temp);
                        break;
                }
            }
        }
    }

    IEnumerator nowPlay(Sprite tmp)
    {
        for(float i = 0; i <= 3; i += Time.deltaTime)
        {
            image.GetComponent<Image>().sprite = tmp;
            yield return 0;
        }
        if (find == 5 && b)
        {
            for (float i = 0; i <= 3; i += Time.deltaTime)
            {
                image.GetComponent<Image>().sprite = dogPalmFin;
                yield return 0;
            }
        }
        image.GetComponent<Image>().sprite = origine;
    }

    //電梯轉換
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("elevator2") == 0 && count==6)
        {
            SceneManager.LoadScene("win");
        }
        if (other.tag.CompareTo("elevator1") == 0)
        {
            SceneManager.LoadScene("elevator");
        }
    }
}

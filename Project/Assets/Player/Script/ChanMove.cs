using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanMove : MonoBehaviour {
    public Animator anim;
    public int move;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            move = 1;
        else if (Input.GetKey(KeyCode.DownArrow))
            move = -1;
        else if (Input.GetKey(KeyCode.LeftArrow))
            move = 3;
        else if (Input.GetKey(KeyCode.RightArrow))
            move = 2;
        else
            move = 0;
        anim.SetInteger("move",move);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 50, 0);
    }
}

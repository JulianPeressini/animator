using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megamanControls : MonoBehaviour {

    Animator anim;
	
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("walking", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("walking", false);
        }

        
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("jumping", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("jumping", false);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("shooting", true);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            anim.SetBool("shooting", false);
        }

    }
}

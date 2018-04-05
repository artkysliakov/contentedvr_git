using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JallyAnimationsController : MonoBehaviour {

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	public void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Start Animation");
        }
	}
}

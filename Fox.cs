using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Require component makes sense because the fox is a specilization of an attacker so you always need an attacker component anyway.
[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attacker attacker;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();      
	}
	
	// Update is called once per frame
	void Update () {

       
	}
    //if and else Statements seem to need their own set of brackets
    void OnTriggerEnter2D(Collider2D collider)
    {


        GameObject obj = collider.gameObject;
        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            anim.SetTrigger("jump trigger");


        } else
        {
            anim.SetBool("isAttacking", true);
            attacker.Attack (obj);
        }
        
        
    }
    
}

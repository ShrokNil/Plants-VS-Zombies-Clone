using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]


public class Attacker : MonoBehaviour {
    [Range(-1f,1.5f)]
    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animator;
    // Use this for initialization
	void Start () {
        // Re-apply the two lines of code below to summon a Kinematic rigidbody 2D through this script.
        // Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        // myRigidbody.isKinematic = true;

        
        
        animator = GetComponent<Animator>();
     
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
	}


        void OnTriggerEnter2D()
    {
        Debug.Log (name + " trigger enter");
    }

        public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }
        //called from the animator at the time of actual hit
        public void StrikeCurrentTarget (float damage)
    {
        if (currentTarget)
    {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
    {
                health.DealDamage(damage);
    }

    }

       
    }   //Attack puts the target into attack mode
        public void Attack (GameObject obj)
    {
        currentTarget = obj;
    }
       


}

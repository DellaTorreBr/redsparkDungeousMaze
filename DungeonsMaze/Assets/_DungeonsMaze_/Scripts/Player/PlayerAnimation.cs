using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start() {
       animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update() {
        
        float verticalValue = Input.GetAxis("Vertical");
        float horizontalValue = Input.GetAxis("Horizontal");

        animator.SetFloat("walkingSpeed", verticalValue);
        animator.SetFloat("rotationMultiplier", horizontalValue);
        
        if (verticalValue != 0 || horizontalValue != 0) {
            animator.SetBool("walking", true);
        } else {
            animator.SetBool("walking", false);
        }

        if(Input.GetButtonDown("Jump")){
            animator.SetTrigger("jump");
        }

        if (Input.GetButtonDown("Fire1")) {
            animator.SetTrigger("slice");
        }

        if (Input.GetKeyDown(KeyCode.K)) {
            animator.SetTrigger("death");
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            animator.SetTrigger("respawn");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkStateBehaviour : StateMachineBehaviour {

    public float rotationSpeed = 50.0f;

    void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.transform.Translate(Vector3.forward * 
                                        stateInfo.speedMultiplier *
                                        Time.deltaTime);
        animator.gameObject.transform.Rotate(Vector3.up, rotationSpeed *
                                        animator.GetFloat("rotationMultiplier") *
                                        Time.deltaTime);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : MonoBehaviour
{
    public Animator doorAnimator;

    public void PlayGame() {
        if(doorAnimator != null) {
            doorAnimator.SetTrigger("DoorATrigger");
        }
    }

    public void ExitGame() {
        Application.Quit();
    }

}

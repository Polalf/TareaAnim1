using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlAnim : MonoBehaviour
{
    public Animator PlayerAnimator;

    public KeyCode keyRun;
    public KeyCode keyIdle;
    public KeyCode keyExtra;

    public string AnimRun;
    public string AnimIdle;
    public string AnimExtra;



    void Update()
    {

        if (Input.GetKeyDown(keyRun))
        {
            PlayerAnimator.Play(AnimRun);
        } 
        if (Input.GetKeyDown(keyIdle))
        {
            PlayerAnimator.Play(AnimIdle);
        }
        if (Input.GetKeyDown(keyExtra))
        {
            PlayerAnimator.Play(AnimExtra);
        }
    }
}

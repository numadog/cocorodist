using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveCtrl : MonoBehaviour
{
    private Animator animator;
    public buttonScript buttonScript;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonScript.wave == true)
        {
            animator.SetBool("wave", true);
        }
    }
}

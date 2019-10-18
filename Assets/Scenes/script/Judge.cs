using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    private Animator animator;
    public SrialController SerialController; //シリアル通信用
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //受信した値（SerialController.Action）に対する処理
    void Update()
    {
        // 以下にSerialController.Actionの値に応じた処理を書く
        if (SerialController.Cool == true)
        {
            animator.SetFloat("DistCheck", 2);
        }
        else if (SerialController.Soso == true)
        {
            animator.SetFloat("DistCheck", 3);
        }

        else if (SerialController.Hot == true)
        {
            animator.SetFloat("DistCheck", 4);
        }

        else if (SerialController.Lave == true)
        {
            animator.SetFloat("DistCheck", 5);
        }
        else if (SerialController.Reset == true)
        {
            animator.SetFloat("DistCheck", 0);
        }
    }
}
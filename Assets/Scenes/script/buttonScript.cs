using UnityEngine;
using System.Collections;

public class buttonScript : MonoBehaviour
{
    public bool Particle;
    public bool wave;

    public void ButtonPush()
    {
        Particle = true;
        wave = true;
        Debug.Log("start measure!!");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    void NextScene()
    {
        SceneManager.LoadScene("mainScene");
    }
}

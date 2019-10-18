using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistText : MonoBehaviour
{

    public SrialController SerialController;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "心の距離" + SerialController.comdist + "cm";

        if (SerialController.Cool == true)
        {
            this.GetComponent<Text>().text = "心の距離" + SerialController.comdist + "cm" + "知り合い距離";
        }
        else if (SerialController.Soso == true)
        {
            this.GetComponent<Text>().text = "心の距離" + SerialController.comdist + "cm" + "お友達距離";
        }

        else if (SerialController.Hot == true)
        {
            this.GetComponent<Text>().text = "心の距離" + SerialController.comdist + "cm" + "親友距離";
        }

        else if (SerialController.Lave == true)
        {
            this.GetComponent<Text>().text = "心の距離" + SerialController.comdist + "cm" + "ガチ恋距離";
        }

    }
}

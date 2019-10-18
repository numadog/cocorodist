using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using System.IO.Ports;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class SrialController : MonoBehaviour
{
    public bool Cool;
    public bool Soso;
    public bool Hot;
    public bool Lave;
    public bool Reset;
    public float comdist;

    // シリアル通信用変数
    public string portName;
    public int baurate;

    SerialPort serial;
    bool isLoop = true;

    void Start()
    {
        this.serial = new SerialPort(portName, baurate, Parity.None, 8, StopBits.One);

        try
        {
            this.serial.Open();
            Scheduler.ThreadPool.Schedule(() => ReadData()).AddTo(this);
        }
        catch (Exception)
        {
            Debug.Log("can not open serial port");
        }
    }

    public void ReadData()
    {
        while (this.isLoop)
        {
            //シリアル通信読み込み
            string message = this.serial.ReadLine();
            // String値をfloat値に変換 
            float dist = Convert.ToSingle(message);
            Debug.Log("入力：" + dist);//ログ距離表示
            comdist = dist;
            //distの値を比較して差が10以上だった場合reset


            if (dist <= 70 && dist > 45)
            {
                Cool = true;
                Soso = false;
                Hot = false;
                Lave = false;
            }
            else if (dist <= 45 && dist > 25)
            {
                Soso = true;
                Cool = false;
                Hot = false;
                Lave = false;
            }
            else if (dist <= 25 && dist > 5)
            {
                Hot = true;
                Cool = false;
                Soso = false;
                Lave = false;
            }
            else if (dist <= 5)
            {
                Lave = true;
                Cool = false;
                Soso = false;
                Hot = false;
            }

            else
            {
                Cool = false;
                Soso = false;
                Hot = false;
                Lave = false;
                Reset = true;
            }

        }
    }

    void OnDestroy()
    {
        this.isLoop = false;
        this.serial.Close();
    }
}
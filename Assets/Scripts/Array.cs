using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    private int[] Num = new int[3];
    //private int[] Num1 = new int[]{1,2,3};
    //private int[] Num2 = { 1, 2, 3 };

    void Start()
    {
        Num = new int[] { 1, 2, 3 };
    }

    void Update()
    {

    }

    void Log() //配列の中身を出力したいとき
    {
        Debug.Log(Num[2]);
    }

    void ClearArray() //要素数0の空の配列を代入したい時
    {
        Num = new int[0];
    }

    void ResetArrayValue() //配列の中身を初期化したいとき
    {
        for(int i = 0; i < Num.Length; i++)
        {
            Num[i] = 0;
        }
    }

    void DeleteArray() //配列を完全に消去したいとき
    {
        Num = null;
    }
}

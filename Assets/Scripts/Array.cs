using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    void Start()
    {
        ClearArray();
    }


    void Log() //配列の中身を出力したいとき
    {
        int[] Num = new int[3];
        Num = new int[3]{ 1, 2, 3 };

        Debug.Log(Num[2]);
    }


    void ClearArray() //要素数0の空の配列を代入したい時
    {
        int[] Num = new int[] { 1, 2, 3 };

        Num = new int[0];
    }


    void ResetArrayValue() //配列の中身を初期化したいとき
    {
        int[] Num = { 1, 2, 3 };

        for(int i = 0; i < Num.Length; i++)
        {
            Num[i] = 0;
        }

        Debug.Log(Num[0]);
        Debug.Log(Num[1]);
        Debug.Log(Num[2]);
    }


    void DeleteArray() //配列を完全に消去したいとき
    {
        int[] Num = { 1, 2, 3 };

        Num = null;
    }
}

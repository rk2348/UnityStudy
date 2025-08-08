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


    void Log() //�z��̒��g���o�͂������Ƃ�
    {
        int[] Num = new int[3];
        Num = new int[3]{ 1, 2, 3 };

        Debug.Log(Num[2]);
    }


    void ClearArray() //�v�f��0�̋�̔z�������������
    {
        int[] Num = new int[] { 1, 2, 3 };

        Num = new int[0];
    }


    void ResetArrayValue() //�z��̒��g���������������Ƃ�
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


    void DeleteArray() //�z������S�ɏ����������Ƃ�
    {
        int[] Num = { 1, 2, 3 };

        Num = null;
    }
}

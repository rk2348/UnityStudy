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

    void Log() //�z��̒��g���o�͂������Ƃ�
    {
        Debug.Log(Num[2]);
    }

    void ClearArray() //�v�f��0�̋�̔z�������������
    {
        Num = new int[0];
    }

    void ResetArrayValue() //�z��̒��g���������������Ƃ�
    {
        for(int i = 0; i < Num.Length; i++)
        {
            Num[i] = 0;
        }
    }

    void DeleteArray() //�z������S�ɏ����������Ƃ�
    {
        Num = null;
    }
}

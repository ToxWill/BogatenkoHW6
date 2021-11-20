using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("��� ����� � ������");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("��� ��������� � �������");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("��� ����� �� �������");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Шар вошел в тригер");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Шар находится в тригере");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Шар вышел из тригера");
    }
}

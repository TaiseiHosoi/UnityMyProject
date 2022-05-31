using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject clearText;
    public GameObject nextButtun;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");

        clearText.SetActive(true);
        nextButtun.SetActive(true);
    }
}

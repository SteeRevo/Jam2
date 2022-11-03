using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAreaDetection : MonoBehaviour
{
    public int currentItems = 1;
    

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "OfficeObject"){
            currentItems++;
            Debug.Log("there are " + currentItems);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "OfficeObject"){
            currentItems--;
            Debug.Log("There are " + currentItems);
        }
    }
}

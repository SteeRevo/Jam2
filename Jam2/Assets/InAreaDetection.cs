using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAreaDetection : MonoBehaviour
{
    public int currentItems = 1;
    public string objectToScan;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == objectToScan){
            currentItems++;
            Debug.Log("there are " + currentItems);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == objectToScan){
            currentItems--;
            Debug.Log("There are " + currentItems);
        }
    }
}

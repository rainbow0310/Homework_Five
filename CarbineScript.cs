using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbineScript : MonoBehaviour
{
    [SerializeField] Camera FPCamera; // FP = first person
    [SerializeField] float shootRange = 10f;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) { //developer of the program said that they wanted to use "fire1"
            Shoot();
        }
    }

    private void Shoot() {
            RaycastHit hit;
        if(Physics.Raycast(FPCamera.transform.position,FPCamera.transform.forward, out hit , shootRange)) { 
           if (hit.collider.CompareTag("Enemy")) {
            Debug.Log("I hit an enemy!");
            }  
            else {
            Debug.Log("I hit an object!");
            }
        }
        else {
            return;
        }
    }
}

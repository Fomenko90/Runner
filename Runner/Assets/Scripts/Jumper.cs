using System;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    
    
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    
    void OnTriggerEnter (Collider other){
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<Rigidbody> ().useGravity = false;
            other.gameObject.GetComponent<Mover>().startZPos = other.gameObject.transform.position.z;
            other.gameObject.GetComponent<Mover>().jump = true;
        }
    }

}
   
    
    


    

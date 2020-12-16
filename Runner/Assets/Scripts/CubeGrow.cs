using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubeGrow : MonoBehaviour
{
    bool gameOver = false;
    public float growSpeed = 1f;
    bool toGrow= false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toGrow && transform.position.y < 0.46){
            transform.Translate (Vector3.up * Time.fixedDeltaTime * growSpeed);
            }
        
    }
    
    void OnTriggerEnter (Collider other){
        if (other.gameObject.CompareTag("Screen")){
            toGrow = true;
        }
    }
}

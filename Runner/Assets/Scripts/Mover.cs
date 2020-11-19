using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float speed = 2;
    float zPos; 
    float xPos;
    float yPos;
    
    void Start()
    {
        zPos = transform.position.z;
        xPos = transform.position.x;
        yPos = transform.position.y;
    }


    void Update()
    {
        zPos += speed * Time.deltaTime;
        
        xPos += Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        
        if (Input.GetKey(KeyCode.R))
        {
           zPos = 15.00414f;
           xPos = 2.711f;
           transform.position = new Vector3 (xPos , 5.743417f , zPos); 
           speed = 2;
           //можно ли сделать перезарядку на R
        }
        else if (Input.GetKey(KeyCode.T))
        {
            if(speed <= 20)
            {
                speed = speed + 1;
            }
            
        }
        else if (Input.GetKey(KeyCode.G))
        {
            if(speed >= 2)
            {
                speed = speed - 1;
            }
        }
        
        
        
    
        transform.position = new Vector3 (xPos , transform.position.y , zPos); 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float speed = 2;
    float zPos; 
    float xPos;
    float yPos;
    //static Component rb = gameObject.GetComponent<Rigidbody>();
    //gForceVector = 1000;
    //Vector3 newVelocity = rb.velocity + gForceVector * rb.mass * Time.deltaTime;
    //rb.velocity = newVelocity; 
    
    
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
           
           gameObject.GetComponent<Rigidbody>().useGravity = false;
           gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
           zPos = 15.00414f;
           xPos = 2.511f;
           transform.position = new Vector3 (xPos , 6.643417f , zPos); 
           speed = 2;
<<<<<<< HEAD
           gameObject.GetComponent<Rigidbody>().useGravity = true;
           
=======
           //есть неприятный баг
>>>>>>> 5d6721a484363008027653389f6c2da253a0d605
        }
        else if (Input.GetKey(KeyCode.T))
        {
            if(speed <= 7)
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
    
    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.CompareTag ("Growing Obstacle"))
        {
            gameObject.SetActive(false);
        }
    }
}

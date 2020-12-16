using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float speed = 2;
    float zPos; 
    float xPos;
    float yPos;
<<<<<<< HEAD
    public float startZPos;
    public float amplitude = 10;
    public bool jump = false;
=======
>>>>>>> 6025250fb326e666d63e643589f5ebe40789bd93
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
        
        
        if (jump){
            yPos = 4.7f + Mathf.Sin((transform.position.z - startZPos) / 2f * Mathf.PI / 2f) * amplitude;
        }
        else{
            yPos = transform.position.y;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        
        if (Input.GetKey(KeyCode.R))
        {
           
           gameObject.GetComponent<Rigidbody>().useGravity = false;
           gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
<<<<<<< HEAD
           zPos = 0.0f;
           xPos = 2.511f;
           transform.position = new Vector3 (xPos , 6.643417f , zPos); 
           speed = 2;
           gameObject.GetComponent<Rigidbody>().useGravity = true;
           
=======
           zPos = 15.00414f;
           xPos = 2.511f;
           transform.position = new Vector3 (xPos , 6.643417f , zPos); 
           speed = 2;
<<<<<<< HEAD
           gameObject.GetComponent<Rigidbody>().useGravity = true;
           
=======
           //есть неприятный баг
>>>>>>> 5d6721a484363008027653389f6c2da253a0d605
>>>>>>> 6025250fb326e666d63e643589f5ebe40789bd93
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
        
        
        
    
        transform.position = new Vector3 (xPos , yPos , zPos); 
    }
    
    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.CompareTag ("Growing Obstacle"))
        {
            gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Floor")){
            jump = false;
        }
    }
<<<<<<< HEAD
=======
    
    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.CompareTag ("Growing Obstacle"))
        {
            gameObject.SetActive(false);
        }
    }
>>>>>>> 6025250fb326e666d63e643589f5ebe40789bd93
}

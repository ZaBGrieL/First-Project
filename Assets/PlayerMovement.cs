using UnityEngine;

public class PlayerMovement : MonoBehaviour{
        
           public Rigidbody rb;//назва тіла для подальшого use           
                public float forwardForce = 2000f;
                  public float sidewaysForce = 500f;
     

    void FixedUpdate ()//фіксована обнова кадрів
    {
       //Add a forward Force
        rb.AddForce(0,0,forwardForce * Time.deltaTime);//встановлення +- рівних значень для слабких і мощні ПК

        if (Input.GetKey("d"))
        { 
              rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        { 
              rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }

    }
}

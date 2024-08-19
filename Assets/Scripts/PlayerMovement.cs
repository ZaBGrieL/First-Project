using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;//назва тіла для подальшого use

    public const float ForwardForce = 2000f;
    public const float SidewaysForce = 500f;

    void FixedUpdate()//фіксована обнова кадрів
    {
        //Add a forward Force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);//встановлення +- рівних значень для слабких і мощні ПК

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}

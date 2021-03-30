using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float panSpeed = 30f;

    public float maximumX = 15;
    public float minimumX = -5;

    public float maximumY = 10;
    public float minimumY = -5;

    public float minimumZ = 0.87f;
    public float maximumZ = 5;

    
    


    private void Update()
    {

       // Vector3 bounds = transform.position;

      //  bounds.y = Mathf.Clamp(bounds.x, minimumX, maximumX);


        if (Input.GetKey("w") && (transform.position.x <= maximumX))
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") && (transform.position.x >= -1* minimumX))
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d") && (transform.position.z >= 1* - maximumY))
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a") && (transform.position.z <=  minimumY))
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }


        
       // float xBounds = Transform.

    }

    
}

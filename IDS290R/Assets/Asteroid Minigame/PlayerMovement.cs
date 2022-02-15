using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;
    float shipBoundaryRadius = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ROTATE SHIP

        //GRAB OUR ROTATION QUATERNION
        Quaternion rot = transform.rotation;

        //GRAB THE Z EULER ANGLE
        float z = rot.eulerAngles.z;

        //CHANGE THE Z ANGLE BASED ON INPPUT
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        //RECREEATE THE QUATERNION
        rot = Quaternion.Euler(0, 0, z);

        //FEED THE QUATERNION INTO OUR ROTATION
        transform.rotation = rot;

        //MOVE THE SHIP
        Vector3 pos = transform.position;
        //pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical")* maxSpeed * Time.deltaTime, 0);
        pos += rot * velocity;


        //RESTRICT PLAYER TO CAMERA BOUNDRIES

        //First do vertical, because it's simpler
        if(pos.y+shipBoundaryRadius > Camera.main.orthographicSize){
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
         if(pos.y-shipBoundaryRadius < -Camera.main.orthographicSize){
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }
        /// Now calculate the orthographic width based on the screen ratio
        float screenRatio = (float)Screen.width / (float)Screen.height;   
        float widthOrtho = Camera.main.orthographicSize * screenRatio;  
        

        //Now do the horizontal bounds
        if(pos.x+shipBoundaryRadius > widthOrtho){
            pos.x = widthOrtho - shipBoundaryRadius;
        }
         if(pos.x-shipBoundaryRadius < -widthOrtho){
            pos.x = -widthOrtho + shipBoundaryRadius;
        }          
        //Finally, update the posiition.
        transform.position = pos;

        //transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0))
    }
}

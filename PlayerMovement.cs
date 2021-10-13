using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
  /* we set the max speed = to 5 because The input.getAxis value being added
  to pos sets the ship to move upwards on the y axis on every frame, The game
  runs at 60 frames per second which is giving us too much speed. so
  we set a maxSpeed value of 5 */
  //in csharp in order to get floats we define them then add "f" to the end
  // of decimal values so they are not doubles.
  //GameObject ChangeSpeed = GameObject.find("FollowsPlayer");

  int timer = 1;
  int counter = 0;
  float maxSpeed = 8.0f;
  int j = 0;
  // rotation speed per second
  float rotSpeed = 300f;
// boundaries and size of the ship
  float shipBoundaryRadius = 0.5f;




    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {


      // returns a Float from -1.0 to +1.0
      //This getaxis method works by essentially making any vertical (up) input on the players end
      // be registered as up.

      // Input.GetAxis("Vertical");

      //same process as above for the X axis (horizonal input on the keyboard or joystick)
      /*
      Vector3 pos1 = transform.position;
      pos1.x = pos1.x + Input.GetAxis("Horizontal");
      transform.position = pos1;
*/

      //-----------------------------Ship Rotation-------------------------------------

      Quaternion rot = transform.rotation;
      float z = rot.eulerAngles.z;
      z =  z + -Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;
      rot = Quaternion.Euler(0, 0, z);
      transform.rotation = rot;


      // ----------------------Ship Movement----------------------------------------
      /* the vector 3 object is a unity object that stores
      a 3 decimal positioning values (x,y and z) based on a game object or sprite
      in this case we set the oject equal to a local variable called pos
      we then set pos equal to transform.position, the transform.positioning
      value will change the objects location in real time based on what
      the scripter wants the pos.y value to be. */
      Vector3 pos = transform.position;
      Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * maxSpeed, 0);
      pos += rot * velocity;
      transform.position = pos;
// hello

      // --------------------------------Screen Boundaries -------------------------------

      float screenRatio = (float)Screen.width / (float)Screen.height; // cast screen width and screen height to floats to avoid truncation
      float widthOrtho = Camera.main.orthographicSize * screenRatio;

      if (pos.x + shipBoundaryRadius > widthOrtho)
      {
        pos.x  = widthOrtho - shipBoundaryRadius;
      }

      if (pos.x - shipBoundaryRadius < -widthOrtho)
      {
        pos.x  = -widthOrtho + shipBoundaryRadius;
      }
        /*screen boundaries of the Y axis, pos.y is the current position of the playership model center of mass
        We add this value to the size of the value "shipBoundaryRadius" in order to get the full rectangular
        size of the ship model rather than just the point in the middle. The statement camera.main.orthoggraphicSize
        is the comparison value relating to the vertical boundaries of the ship. So we are comparing the entire shipBoundaryRadius
        to the edge of the screen . If its larger (meaning the ship exceeds the screen boundary) we just set the
        position of the y value of the ship back to edge so it does not exceed it.*/
      if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
      {
        pos.y  = Camera.main.orthographicSize - shipBoundaryRadius;
      }

      if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
      {
        pos.y  = -Camera.main.orthographicSize + shipBoundaryRadius;
      }

      transform.position = pos;
    }

  }

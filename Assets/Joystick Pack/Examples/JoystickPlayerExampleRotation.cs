using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExampleRotation : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
      // rigidbody.rotation =  rigidbody.rotation * Quaternion.AngleAxis( variableJoystick.Horizontal * moveSpeed, Vector3.foward);
      //  move forward on local x when moving joystick up or down
      // float forwardMove =  variableJoystick.Vertical;
      // if( forwardMove >= 0 ){  // don't allow backwards movement
      //             rb.AddForce( transform.right *  forwardMove * 1.0f ); 
      // }
      // rotate on z axis when moving joystick left or right.
      rb.rotation =  rb.rotation * Quaternion.AngleAxis( variableJoystick.Horizontal * 1.0f, Vector3.forward); 

      // float turn = m_HorizontalValue * m_TurnSpeed * Time.deltaTime;

      //   Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

      //   m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation); 
    }
}
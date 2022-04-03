using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        rigidbody.rotation =  rigidbody.rotation * Quaternion.AngleAxis( joystick.Horizontal * moveSpeed, Vector3.foward);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Testing
{
    public class TestMovement : MonoBehaviour
    {        

        void Update()
        {
            transform.position += new Vector3(0, 0, Input.GetAxis("Vertical"))* Time.deltaTime*5f;
            transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal"), 0);
        }
    }
}
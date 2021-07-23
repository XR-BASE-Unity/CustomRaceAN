using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float angle;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 posOffset = gameObject.transform.position;
        Vector3 rotOffset = Vector3.zero;
      
      if (Input.GetKey(KeyCode.W))
      {
            posOffset += new Vector3 (0f, 0f, Time.deltaTime * speed);
      }
      if (Input.GetKey(KeyCode.S))
      {
            posOffset -= new Vector3(0f, 0f, Time.deltaTime * speed);
        }

      if (Input.GetKey(KeyCode.A))
      {
            rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
      }
      if (Input.GetKey(KeyCode.D))
      {
            rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
      }

        gameObject.transform.position = posOffset;
        gameObject.transform.Rotate(rotOffset);
    }
}

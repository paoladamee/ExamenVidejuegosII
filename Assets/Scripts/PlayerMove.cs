using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float Speed = 3.0f;
   void Update()
   {
       transform.Translate(Axis * Speed * Time.deltaTime);
       Debug.Log(Axis);
   } 
   Vector2 Axis = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"));
}

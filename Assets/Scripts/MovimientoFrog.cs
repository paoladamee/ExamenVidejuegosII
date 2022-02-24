using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFrog : MonoBehaviour
{
   public float velocidad;
   public float fuerzaSalto;

   void Update()
   {
       ProcesarMovimiento();
       ProcesarSalto();
   }

   void ProcesarSalto()
    {
       //Lógica de Salto
       float inputSalto = Input.GetAxis("Horizontal");
       Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

       rigidbody.velocity = new Vector2(inputSalto * velocidad, rigidbody.velocity.x);
   }

   void ProcesarMovimiento()
   {
       //Lógica de movimiento
       float inputMovimiento = Input.GetAxis("Vertical");
       Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

       rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);
   }

   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("bananaitem"))
{
   Destroy(col.gameObject);
}

}

}

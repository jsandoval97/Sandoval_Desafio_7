
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.CompareTag("Portal"))
        {
            Debug.Log ("Entrando en colisión con un Shrinker");
        }
        else 
        {
            Debug.Log("Entrando en colisión con -> " + other.gameObject.name);
        }

    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Saliendo de colisión con -> " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("En colisión con -> " + other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrando en -> " + other.gameObject.name);


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saliendo de -> " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Dentro de -> " + other.gameObject.name);
    }
}

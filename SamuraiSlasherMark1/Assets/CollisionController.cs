using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("BlueNinja"))
        {
            Debug.Log("Enter");
        }
    }
    

    private void OnCollisionStay2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("BlueNinja"))
        {
            Debug.Log("Stay");
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    { 
        if (collision.gameObject.name == "BlueNinja")
        {
            Debug.Log("Exit");
        }
    }

}

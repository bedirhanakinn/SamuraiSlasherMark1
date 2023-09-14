using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   private void OnTriggerStay2D(Collider2D other)
   {
    Debug.Log("mid attack");
 if (other.gameObject.CompareTag("BlueNinja"))
        {
                if(Input.GetKey (KeyCode.UpArrow))
                {
                       if(Input.GetKey (KeyCode.Space))
                {
                        Destroy(other.gameObject);
                }
                }     
        }
    
   }

   private void OnTriggerExit2D(Collider2D other)
        {
                Debug.Log("attack over");   
        }
}
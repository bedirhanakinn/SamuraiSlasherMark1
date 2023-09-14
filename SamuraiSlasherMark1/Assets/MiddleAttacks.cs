using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other){
    Debug.Log("mid attack");
    
   }


   private void OnTriggerExit2D(Collider2D other){
    Debug.Log("attack over");
   }


}
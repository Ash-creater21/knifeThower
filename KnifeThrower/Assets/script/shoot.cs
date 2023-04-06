using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet ; 
    public Transform FirePoint ; 

    

   public void Shoot()
   {
        Instantiate(bullet,FirePoint.position,FirePoint.rotation);
   }

  
}

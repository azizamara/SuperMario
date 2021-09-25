using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
   public GameObject Canva;
   public GameObject Player;
   public AudioSource Death;

   void OnTriggerEnter(Collider col) 
   {   Death.Play();
       Player.transform.position=new Vector3 (1,0.5F,0.5F);
       Canva.SetActive(true);
   }
}

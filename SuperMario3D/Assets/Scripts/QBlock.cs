 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QBlock : MonoBehaviour
{       public GameObject QBloc;
       public GameObject Mushroom;
       public GameObject DB; 
       public GameObject MCollider;
       
    
    IEnumerator OnTriggerEnter(Collider col)
 {
   QBloc.SetActive(false);
   //QBloc.GetComponent<MeshRenderer>().enabled=false;
	DB.SetActive(true);
	yield return new WaitForSeconds (0.2F);
	Mushroom.SetActive(true);
   MCollider.SetActive(true);

 }
}

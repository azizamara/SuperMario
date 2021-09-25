using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeExit : MonoBehaviour {
[SerializeField]
 public int StoodOn;
public GameObject FadeScreen;
 public GameObject MainCam;
 public GameObject SecondCam;
 public GameObject MainPlayer;

 IEnumerator OnTriggerEnter (Collider col) {
  StoodOn = 1; 
   FadeScreen.SetActive(true);
   FadeScreen.GetComponent<Animator>().enabled=true;
 
  yield return new WaitForSeconds(0.4F);
   MainCam.SetActive (true);
  SecondCam.SetActive (false);
  MainPlayer.transform.position = new Vector3(19, 3, 0.5F);
    FadeScreen.GetComponent<Animator>().enabled=false;
  
  FadeScreen.SetActive(false);

 }

 void OnTriggerExit (Collider col) {
  StoodOn = 0;
 }

 

 }

 

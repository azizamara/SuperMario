using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAnim : MonoBehaviour {
[SerializeField]
 public Animator PipeAnimation;
 public int StoodOn;
 public Animator Fade;
 public GameObject MainCam;
 public GameObject SecondCam;
 public GameObject MainPlayer;

 void OnTriggerEnter (Collider col) {
  StoodOn = 1;
 }

 void OnTriggerExit (Collider col) {
  StoodOn = 0;
 }

 // Use this for initialization
 void Start () {
  
 }
 
 // Update is called once per frame
 void Update () {
  if (Input.GetKeyDown(KeyCode.C)) {
   if (StoodOn == 1) {
    transform.position = new Vector3 (0, -1000, 0);
    StartCoroutine(WaitingForPipe ());
   }
  }
 }

 IEnumerator WaitingForPipe () {
    
    PipeAnimation.enabled = true;
     yield return new WaitForSeconds (1.5F);

     Fade.enabled=true;
     yield return new WaitForSeconds (0.495F);
     Fade.enabled=false;
     PipeAnimation.enabled = false;

     SecondCam.SetActive (true);
     MainCam.SetActive (false);
    MainPlayer.transform.position = new Vector3(13, -3, 0.5F);
    

      Fade.enabled=true;
     yield return new WaitForSeconds(0.495F);
     Fade.enabled=false;
 
 }
}
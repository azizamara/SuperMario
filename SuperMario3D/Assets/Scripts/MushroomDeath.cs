using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDeath : MonoBehaviour {

 public GameObject MushroomMan;

 IEnumerator OnTriggerEnter(Collider col)
 {
  this.GetComponent<BoxCollider> ().enabled = false;
  MushroomMan.GetComponent<MushroomMove> ().enabled = false;
  MushroomMan.transform.localScale -= new Vector3 (0, 0.8F, 0);
  MushroomMan.transform.localPosition -= new Vector3 (0, 0.3F, 0);
  yield return new WaitForSeconds(1);
  MushroomMan.transform.position =  new Vector3 (0, -1000, 0);
 }
}
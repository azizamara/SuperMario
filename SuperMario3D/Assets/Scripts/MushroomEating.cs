using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomEating : MonoBehaviour
{   public GameObject Player;
    public GameObject Mushroom;
    public AudioSource GrowSound;

    // Start is called before the first frame update
   void OnTriggerEnter ( Collider col) {

       GrowSound.Play();
		this.transform.position = new Vector3(0, -1000, 0);
        Mushroom.transform.position = new Vector3(0,-1000,0);
		Player.transform.localScale = new Vector3(1.15F, 1.15F, 1.15F);
	}
}



using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour {
    public AudioSource audiosource;

void  OnTriggerEnter ( Collider col  ){
 transform.position = new Vector3(0, -1000, 0);
 audiosource.Play();
 GlobalCoins.CoinCount += 1;
}
}
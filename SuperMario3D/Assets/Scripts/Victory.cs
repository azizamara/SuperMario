using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
   public GameObject VictoryCanva;
   public GameObject Player;
   public AudioSource VictorySound;
    public GameObject Score;
  public GameObject Timer;
    public GameObject Temps;


   void OnTriggerEnter(Collider col) 
   {   VictorySound.Play();
       Player.transform.position=new Vector3 (1,0.5F,0.5F);
       VictoryCanva.SetActive(true);
       Score.GetComponent<UnityEngine.UI.Text>().text = "Score: " + GlobalCoins.CoinCount;

        Timer.GetComponent<UITimer>().playing=false;
        Temps.GetComponent<UnityEngine.UI.Text>().text = "Time: "+Timer.GetComponent<UnityEngine.UI.Text>().text ;
    
        

   }
}

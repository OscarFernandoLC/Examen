using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//nuevo
public class Coin : MonoBehaviour
{
	public static int countCoins = 0;
    void Start()
    {
	
        Debug.Log("Moneda creada");
	Coin.countCoins++;
    }


    void Update()
    {
    }

	void OnTriggerEnter(Collider collider){
	Debug.Log("Se ha recolectado la moneda");
	if(collider.CompareTag("Player")){
		Destroy(gameObject);
	 }
	}

	void OnDestroy(){
	Coin.countCoins--;
	if(Coin.countCoins <= 0){
		GameObject timer = GameObject.Find("GameTimer");
		Destroy(timer);
		Debug.Log("El juego ha terminado, has ganado!!");
 	 }
   }




}

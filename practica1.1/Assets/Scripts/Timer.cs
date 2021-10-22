using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float maxTime = 180.0f;
	private float countDown = 0.0f;

    void Start()
    {
	countDown = maxTime;
        Debug.Log("TIEMPO!"+maxTime);
    }

    void Update()
    {
        countDown -= Time.deltaTime;
	Debug.Log("Restan: "+countDown);
	if(countDown <=0){
		Coin.countCoins = 0;
		string currentSceneName = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(currentSceneName);

	}


    }
}

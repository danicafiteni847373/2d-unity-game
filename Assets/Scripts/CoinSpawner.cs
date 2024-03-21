using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	

	public GameObject coin;
	public GameObject coin2;
	public GameObject car;
	
	void Start()
	{
		Instantiate(car, new Vector3(-6, -2, 0), Quaternion.identity);
		StartCoroutine(SpawningCoins());
	
	}

	IEnumerator SpawningCoins()
	{
		GameObject newCoin = Instantiate(coin, new Vector3(-6, 0, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin2 = Instantiate(coin, new Vector3(-6, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);

		GameObject newCoin3 = Instantiate(coin2, new Vector3(-7, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin4 = Instantiate(coin, new Vector3(-6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin5 = Instantiate(coin, new Vector3(-2, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin6 = Instantiate(coin, new Vector3(1, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);

		GameObject newCoin7 = Instantiate(coin2, new Vector3(6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin8 = Instantiate(coin2, new Vector3(-1, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);

		GameObject newCoin9 = Instantiate(coin, new Vector3(-6, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin10 = Instantiate(coin, new Vector3(4, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin11 = Instantiate(coin, new Vector3(-2, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin12 = Instantiate(coin, new Vector3(0, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin13 = Instantiate(coin, new Vector3(-1, -2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);

		GameObject newCoin14 = Instantiate(coin2, new Vector3(-2, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin15 = Instantiate(coin, new Vector3(-2, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin16 = Instantiate(coin2, new Vector3(3, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin17 = Instantiate(coin, new Vector3(4, 2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);


		////

		GameObject newCoin18 = Instantiate(coin2, new Vector3(-6, 0, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin19 = Instantiate(coin, new Vector3(-6, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin20 = Instantiate(coin2, new Vector3(-7, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin21 = Instantiate(coin, new Vector3(-6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin22 = Instantiate(coin, new Vector3(-2, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin23 = Instantiate(coin, new Vector3(1, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin24 = Instantiate(coin, new Vector3(6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin25 = Instantiate(coin2, new Vector3(-1, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin26 = Instantiate(coin, new Vector3(-6, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin27 = Instantiate(coin2, new Vector3(4, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin28 = Instantiate(coin, new Vector3(-2, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin29 = Instantiate(coin2, new Vector3(0, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin30 = Instantiate(coin, new Vector3(-1, -2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin31 = Instantiate(coin, new Vector3(-2, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(1);

		GameObject newCoin32 = Instantiate(coin2, new Vector3(-2, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin33 = Instantiate(coin, new Vector3(3, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);

		GameObject newCoin34 = Instantiate(coin, new Vector3(4, 2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(2);


		//

		GameObject newCoin35 = Instantiate(coin2, new Vector3(-6, 0, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin36 = Instantiate(coin, new Vector3(-6, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin37 = Instantiate(coin2, new Vector3(-7, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin38 = Instantiate(coin, new Vector3(-6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin39 = Instantiate(coin, new Vector3(-2, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(8);

		GameObject newCoin40 = Instantiate(coin, new Vector3(1, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(9);

		GameObject newCoin41 = Instantiate(coin, new Vector3(6, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin42 = Instantiate(coin2, new Vector3(-1, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(8);

		GameObject newCoin43 = Instantiate(coin, new Vector3(-6, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(9);

		GameObject newCoin44 = Instantiate(coin2, new Vector3(4, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(9);

		GameObject newCoin45 = Instantiate(coin, new Vector3(-2, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(10);

		GameObject newCoin46 = Instantiate(coin2, new Vector3(0, -4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(11);

		GameObject newCoin48 = Instantiate(coin, new Vector3(-1, -2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(12);

		GameObject newCoin49 = Instantiate(coin, new Vector3(-2, -1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(11);

		GameObject newCoin50 = Instantiate(coin2, new Vector3(-2, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(15);

		GameObject newCoin51 = Instantiate(coin, new Vector3(3, 1, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(18);

		GameObject newCoin52 = Instantiate(coin2, new Vector3(4, 2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(10);
	}


	
}


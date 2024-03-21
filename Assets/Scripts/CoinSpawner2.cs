using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner2 : MonoBehaviour
{
    public GameObject coin;
	public GameObject coin2;
	public GameObject car;
	
	void Start()
	{
		
		StartCoroutine(SpawningCoins());
	
	}

	IEnumerator SpawningCoins()
	{
		GameObject newCoin = Instantiate(coin, new Vector3(1, 4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin2 = Instantiate(coin, new Vector3(2, 8, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin3 = Instantiate(coin2, new Vector3(2, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin4 = Instantiate(coin, new Vector3(-4, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin5 = Instantiate(coin, new Vector3(-19, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin6 = Instantiate(coin, new Vector3(-19, 7, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(3);

		GameObject newCoin7 = Instantiate(coin2, new Vector3(-20, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin8 = Instantiate(coin2, new Vector3(-19, -11, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin9 = Instantiate(coin, new Vector3(-17, -13, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(8);

		GameObject newCoin10 = Instantiate(coin, new Vector3(-12, -2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin11 = Instantiate(coin, new Vector3(-15, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin12 = Instantiate(coin, new Vector3(-15, 6, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin13 = Instantiate(coin, new Vector3(-3, -6, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin14 = Instantiate(coin2, new Vector3(-3, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(8);

		GameObject newCoin15 = Instantiate(coin, new Vector3(-9, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin16 = Instantiate(coin2, new Vector3(-3, -10, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin17 = Instantiate(coin, new Vector3(2, -10, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(8);

        GameObject newCoin18 = Instantiate(coin, new Vector3(1, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);


		////

        GameObject newCoin19 = Instantiate(coin, new Vector3(1, 4, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(9);

		GameObject newCoin20 = Instantiate(coin, new Vector3(2, 8, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(9);

		GameObject newCoin21 = Instantiate(coin2, new Vector3(2, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(10);

		GameObject newCoin22 = Instantiate(coin, new Vector3(-4, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin23 = Instantiate(coin, new Vector3(-19, 12, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(10);

		GameObject newCoin24 = Instantiate(coin, new Vector3(-19, 7, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(10);

		GameObject newCoin25 = Instantiate(coin2, new Vector3(-20, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin26 = Instantiate(coin2, new Vector3(-19, -11, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin27 = Instantiate(coin, new Vector3(-17, -13, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin28 = Instantiate(coin, new Vector3(-12, -2, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

		GameObject newCoin29 = Instantiate(coin, new Vector3(-15, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin30 = Instantiate(coin, new Vector3(-15, 6, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin31 = Instantiate(coin, new Vector3(-3, -6, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin32 = Instantiate(coin2, new Vector3(-3, -3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(4);

		GameObject newCoin33= Instantiate(coin, new Vector3(-9, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(6);

		GameObject newCoin34 = Instantiate(coin2, new Vector3(-3, -10, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

		GameObject newCoin35 = Instantiate(coin, new Vector3(2, -10, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);

        GameObject newCoin136 = Instantiate(coin, new Vector3(1, 3, 0), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(7);

	}

}

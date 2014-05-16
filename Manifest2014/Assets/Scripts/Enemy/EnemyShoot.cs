using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
	public GameObject enemyBullet;
	bool enemyCanShoot = true;

	void Update()
	{
		StartCoroutine ("shootAtPlayer");
	}
	IEnumerator shootAtPlayer()
	{
		if (enemyCanShoot) 
		{
			Instantiate (enemyBullet, this.transform.position, this.transform.rotation);
			enemyCanShoot = false;
			yield return new WaitForSeconds (3);
			enemyCanShoot = true;
		} 
    }

}

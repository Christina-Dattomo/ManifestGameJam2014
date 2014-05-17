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
			Instantiate (enemyBullet, new Vector3(transform.position.x, transform.position.y -2, transform.position.z), this.transform.rotation);
			enemyCanShoot = false;
			yield return new WaitForSeconds (3);
			enemyCanShoot = true;
		} 
    }

}

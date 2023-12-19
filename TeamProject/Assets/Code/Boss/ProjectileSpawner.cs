using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public GameObject projectilePrefab;
	public float spawnRate = 1f;
	public float projectileSpeed = 5f;
	private float nextSpawnTime;

	void Update()
	{
		if (Time.time >= nextSpawnTime) {
			SpawnProjectile();
			nextSpawnTime = Time.time + 1f / spawnRate;
		}
	}

	void SpawnProjectile()
	{
		GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
		Projectile projectileComponent = projectile.GetComponent<Projectile>();

		if (projectileComponent != null) {
			projectileComponent.direction = transform.forward * projectileSpeed;
		}
	}
}

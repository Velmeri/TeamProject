using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public GameObject projectilePrefab;
	public float spawnRate = 1f;
	public float projectileSpeed = 5f;
	public float minAngle = -45f; // Минимальный угол
	public float maxAngle = 45f;  // Максимальный угол
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

		// Устанавливаем случайный угол в заданном диапазоне
		float angle = Random.Range(minAngle, maxAngle);
		Quaternion rotation = Quaternion.Euler(0, 0, angle); // Вращение вокруг оси Z

		Projectile projectileComponent = projectile.GetComponent<Projectile>();

		if (projectileComponent != null) {
			// Поворачиваем направление движения проектайла
			Vector3 direction = rotation * Vector3.right; // В Unity, Vector3.right представляет направление вправо (вдоль оси X)
			projectileComponent.direction = new Vector2(direction.x, direction.y) * projectileSpeed;
		}
	}
}

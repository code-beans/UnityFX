using System;
using UnityEngine;

namespace Assets.Src
{
	/// <summary>
	/// Basic shooting script
	/// </summary>
	public class ShootScript : MonoBehaviour
	{

		/// <summary>
		/// Firerate in shots per second. Must not be 0!
		/// </summary>
		public double FireRate = 2;

		/// <summary>
		/// Prefab instantiated when shooting
		/// </summary>
		public GameObject BulletPrefab;

		/// <summary>
		/// Bullet spawn point. Bullet will be shot in local forward direction
		/// </summary>
		public Transform BulletSpawn;

		private double timePassed = 0;

		/// <summary>
		/// Update method called once per frame
		/// </summary>
		public void Update() {
			timePassed += Time.deltaTime;

			if (Input.GetButton("Fire1"))
			{
				if (timePassed > 1/FireRate)
				{
					Rigidbody bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation) as Rigidbody;
					bullet.rigidbody.AddForce(BulletSpawn.forward * bulletSpeed);
					timePassed = 0;
				}
			}
		}
	}
}
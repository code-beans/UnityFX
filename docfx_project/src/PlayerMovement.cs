using System;
using UnityEngine;

namespace Assets.Src
{

	/// <summary>
	/// Basic movement script using WASD/Arrow keyboard input
	/// </summary>
	public class PlayerMovement : MonoBehaviour {

		/// <summary>
		/// Player speed in units per second
		/// </summary>
		public float Speed = 10.0f;


		/// <summary>
		/// Updates the player position per frame
		/// </summary>
		public void Update() {
			transform.Translate(new Vector3(Input.Axis("Horizontal"), 0, Input.Axis("Vertical")) * Time.deltaTime * Speed);
		}
	}
}
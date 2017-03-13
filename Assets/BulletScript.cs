using UnityEngine;
using System.Collections;
public class BulletScript : MonoBehaviour {
	private Rigidbody2D rigidbody2D;
	private SpriteRenderer spriteRenderer;
	private float speed = 5;
	public void InitAndShoot(Vector2 direction)
	{
		rigidbody2D = this.GetComponent<Rigidbody2D>();
		spriteRenderer = this.GetComponent<SpriteRenderer> ();
		spriteRenderer.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		rigidbody2D.velocity = speed * direction;
	}
	// Update is called once per frame
	void Update () {

	}
}
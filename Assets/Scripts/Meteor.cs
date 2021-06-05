using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
	public float jumpForce;

	private Rigidbody2D rb;
	private MeteorHealt meteorHealth;
	private PlayerHealth playerHealth;

    private void Awake()
    {
		rb = GetComponent<Rigidbody2D>();
		meteorHealth = GetComponent<MeteorHealt>();

	}
    void Start()
    {		
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

		rb.AddForce(Vector2.right * Random.Range(200f, -200f));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Missile"))
		{
			meteorHealth.TakeDamage();
		}
		else if (other.tag.Equals("Ground"))
		{		
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			//rb.AddTorque(-rb.angularVelocity * 4f);

			CheckGroundTouch();
		}		
		else if (other.tag.Equals("RightLimit"))
		{
			rb.velocity = Vector2.left * 5f;
		}
		else if (other.tag.Equals("LeftLimit"))
        {
			rb.velocity = Vector2.right * 5f;
		}
		else if (other.tag.Equals("Player"))
		{
			playerHealth.DecreasePlayerHealth();
		}
        
	}

	private void CheckGroundTouch()
    {
		jumpForce -= 0.4f;

		if (jumpForce <= 16)
        {
			jumpForce = 16;
        }
    }	

}

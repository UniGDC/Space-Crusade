using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float moveSpeed;
	public Animator playerAnimator;

	void FixedUpdate()
	{


		Vector3 playerPosition = transform.position;

		if (Input.GetKey("w"))
		{
			playerPosition.y += moveSpeed * Time.fixedDeltaTime;

		}
		if (Input.GetKey("s"))
		{
			playerPosition.y -= moveSpeed * Time.fixedDeltaTime;

		}
		if (Input.GetKey("d"))
		{
			playerPosition.x += moveSpeed * Time.fixedDeltaTime;

		}
		if (Input.GetKey("a"))
		{
			playerPosition.x -= moveSpeed * Time.fixedDeltaTime;

		}

		transform.position = playerPosition;
	}
	private void Update()
	{

		float horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
		float verticalMove = Input.GetAxisRaw("Vertical") * moveSpeed;
		if (Mathf.Abs(horizontalMove) >= 0.01 || Mathf.Abs(verticalMove) >= 0.01)
		{
			playerAnimator.SetBool("isMoving", true);
		}
		else
		{
			playerAnimator.SetBool("isMoving", false);
		}
	}
}
	

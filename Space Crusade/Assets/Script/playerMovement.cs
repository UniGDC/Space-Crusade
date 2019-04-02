using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float moveSpeed;
	public float diagMoveSpeed;
	public Animator playerAnimator;

	public GameObject playerGraphics;
	void FixedUpdate()
	{

		
		Vector3 playerPosition = transform.position;

		if (Input.GetKey("w") && !Input.GetKey("d") && !Input.GetKey("a"))
		{
			playerPosition.y += moveSpeed * Time.fixedDeltaTime;

		}
		if (Input.GetKey("s") && !Input.GetKey("d") && !Input.GetKey("a"))
		{
			playerPosition.y -= moveSpeed * Time.fixedDeltaTime;

		}
		if (Input.GetKey("d") && !Input.GetKey("w") && !Input.GetKey("s"))
		{
			playerPosition.x += moveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);

		}
		if (Input.GetKey("a") && !Input.GetKey("w") && !Input.GetKey("s"))
		{
			playerPosition.x -= moveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);

		}






		if (Input.GetKey("w") && Input.GetKey("d"))
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (Input.GetKey("w") && Input.GetKey("a"))
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		if (Input.GetKey("s") && Input.GetKey("d"))
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (Input.GetKey("s") && Input.GetKey("a"))
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
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
	

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float moveSpeed;
	private float diagMoveSpeed;
	public Animator playerAnimator;

	public GameObject playerGraphics;

	private int directionX;
	private int directionY;



	private void Start()
	{
		diagMoveSpeed = moveSpeed * 0.707f;

	}
	void FixedUpdate()
	{
		directionX = 0;
		directionY = 0;
		
		Vector3 playerPosition = transform.position;

		if (Input.GetKey("w"))
		{
			directionY = 1;
		}
		if (Input.GetKey("s"))
		{
			directionY = -1;
		}
		if (Input.GetKey("d"))
		{
			directionX = 1;
		}
		if (Input.GetKey("a"))
		{
			directionX = -1;
		}






		/*if (Input.GetKey("w") && Input.GetKey("d") && !Input.GetKey("a"))
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
			print("diag right up");
		}
		if (Input.GetKey("w") && Input.GetKey("a") && !Input.GetKey("d"))
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
			print("diag left up");
		}
		if (Input.GetKey("s") && Input.GetKey("d") && !Input.GetKey("a"))
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
			print("diag right down");
		}
		if (Input.GetKey("s") && Input.GetKey("a") && !Input.GetKey("d"))
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
			print("diag left down");
		}*/
		if (directionY == 1 && directionX == 1)
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
			print("diag right up");
		}
		else if (directionY == 1 && directionX == -1)
		{
			playerPosition.y += diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
			print("diag left up");
		}
		else if (directionX == 1 && directionY == -1)
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x += diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
			print("diag right down");
		}
		else if (directionX == -1 && directionY == -1)
		{
			playerPosition.y -= diagMoveSpeed * Time.fixedDeltaTime;
			playerPosition.x -= diagMoveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(-1f, 1f, 1f);
			print("diag left down");
		}
		else if (directionY == 1)
		{
			playerPosition.y += moveSpeed * Time.fixedDeltaTime;
		}
		else if (directionY == -1)
		{
			playerPosition.y -= moveSpeed * Time.fixedDeltaTime;
		}
		else if (directionX == 1)
		{
			playerPosition.x += moveSpeed * Time.fixedDeltaTime;
			playerGraphics.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		else if (directionX == -1)
		{
			playerPosition.x -= moveSpeed * Time.fixedDeltaTime;
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
	

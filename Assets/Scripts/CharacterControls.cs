using UnityEngine;
using System.Collections.Generic;

public class CharacterControls : MonoBehaviour
{
	private CharacterController theCharacterController;
	[SerializeField] private float currentSpeed;
	[SerializeField] private bool isMoving;
	[SerializeField] private float baseMoveSpeed;
	[SerializeField] private float baseRotationSpeed;

	private void Awake ()
	{
		theCharacterController = GetComponent<CharacterController>();
		SetStats ();
	}

	private void Update ()
	{
		Move ();
	}

	private void Move ()
	{
		if (this.gameObject.tag == "Player1") {
			float horizontal = Input.GetAxis ("Horizontal");
			float vertical = Input.GetAxis ("Vertical");
			Vector3 movement = new Vector3 (horizontal, 0, vertical);
			isMoving = movement.magnitude > 0 ? true : false;
			theCharacterController.Move (movement * currentSpeed * Time.deltaTime);
		}
		if (this.gameObject.tag == "Player2") {
			float horizontal = Input.GetAxis ("Horizontal1");
			float vertical = Input.GetAxis ("Vertical1");
			Vector3 movement = new Vector3 (horizontal, 0, vertical);
			isMoving = movement.magnitude > 0 ? true : false;
			theCharacterController.Move (movement * currentSpeed * Time.deltaTime);
		}
	}

	private void SetStats(){
		currentSpeed = baseMoveSpeed;
	}
}

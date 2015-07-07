using UnityEngine;
using System.Collections;

public class MouseCameraMovement : MonoBehaviour {

	// public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	// public RotationAxes axes = RotationAxes.MouseX; //RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	
	public float minimumX = -360F;
	public float maximumX = 360F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;

	public GameObject character;
	// float rotationY = 0F;
	
	void Update ()
	{
		/*if (axes == RotationAxes.MouseXAndY)
		{*/
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			
			// rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			// rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			character.transform.Rotate (new Vector3 (0, rotationX * Time.deltaTime, 0));
			/*
			transform.localEulerAngles = new Vector3(0, rotationX, 0);
			Quaternion characterTransform = transform.rotation;
			characterTransform.x = 0;
			characterTransform.z = 0;

			character.transform.rotation = characterTransform;
			*/
			
		/*}
		else if (axes == RotationAxes.MouseX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			
			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}*/
	}
	
	void Start ()
	{
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public float moveSpeed = 0;
  public Camera childCamera = null;
  public float lookSensitivity = 5.0f;
  public float lookSmooth = 2.0f;
  private Vector2 _lookDirection;
  
    private void Start()
    {
      Cursor.lockState = CursorLockMode.Locked;
      
    }

  
  
private void Update()
{
  ControlMovement();
  ControlLookAround();

  if (Input.GetKeyDown(KeyCode.Escape) == true)
  {
    Cursor.lockState = CursorLockMode.None;
  } 
}

private void ControlMovement()

{

  float xAxisMove = Input.GetAxis("Horizontal");
  float zAxisMove = Input.GetAxis("Vertical");

  transform.Translate(xAxisMove * moveSpeed * Time.deltaTime, 0.0f, zAxisMove * moveSpeed * Time.deltaTime);
}

private void ControlLookAround()
{
  Vector2 mouseDir = new Vector2(Input.GetAxis("MouseX"), Input.GetAxis("MouseY"));

  mouseDir = Vector2.Scale(mouseDir,new Vector2(lookSensitivity, lookSensitivity));

  Vector2 lookDelta = new Vector2();
  lookDelta.x = Mathf.Lerp(lookDelta.x, mouseDir.x, 1.0f / lookSmooth);
  lookDelta.y = Mathf.Lerp(lookDelta.y, mouseDir.y, 1.0f / lookSmooth);
  _lookDirection += lookDelta;

  _lookDirection.y = Mathf.Clamp(_lookDirection.y, -75.0f, 75.0f);

  childCamera.transform.localRotation = Quaternion.AngleAxis(-_lookDirection.y, Vector3.right);
  
  this.transform.localRotation = Quaternion.AngleAxis(_lookDirection.x, this.transform.up);


}

}

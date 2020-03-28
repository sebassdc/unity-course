using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // 1. Mouse
    if (Input.GetMouseButtonDown(0))
    {
      Debug.Log("Button 0 pressed");
    }
    if (Input.GetMouseButton(0))
    {
      Debug.Log("Button 0 is pressed");
    }
    if (Input.GetMouseButtonUp(0))
    {
      Debug.Log("Button 0 released");
    }

    // 2. Keyboard
    // By specific key
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Debug.Log("Using space key");
    }
    // By Input mapped
    if (Input.GetButtonDown("Jump"))
    {
      Debug.Log("Using jump button");
    }

    // 3. Getting Axis for movement
    float horizontal = Input.GetAxis("Horizontal"); // -1 to 1
    float vertical = Input.GetAxis("Vertical"); // -1 to 1

    if (horizontal < 0f || horizontal > 0f)
    {
      Debug.Log("Horizontal axis is " + horizontal);
    }
    if (vertical < 0f || vertical > 0f)
    {
      Debug.Log("Vertical axis is " + vertical);
    }
  }
}

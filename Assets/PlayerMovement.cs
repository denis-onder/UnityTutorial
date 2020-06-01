using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  public float forwardForce = 2000f;
  public float lateralForce = 500f;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    if(Input.GetKey("d"))
    {
    rb.AddForce(lateralForce * Time.deltaTime, 0, 0);
    }

    if(Input.GetKey("a"))
    {
    rb.AddForce(-lateralForce * Time.deltaTime, 0, 0);
    }
  }
}

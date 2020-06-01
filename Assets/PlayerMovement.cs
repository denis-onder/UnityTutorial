using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    rb.AddForce(0, 200, 500 * Time.deltaTime);
  }
}

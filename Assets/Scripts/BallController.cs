using System.Security.Cryptography;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody ballBody;
    [SerializeField] private float ballForce;
    [SerializeField] private float ballJumpForce;
    public bool grounded = false;

    public void MoveBall (Vector3 input)
    {
        input.y = (grounded) ? input.y * ballJumpForce : 0;
        ballBody.AddForce (new Vector3(input.x * ballForce, input.y, input.z * ballForce));
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
    private void OnCollisionExit(Collision collision) 
    {      
        grounded = false;
    }
}

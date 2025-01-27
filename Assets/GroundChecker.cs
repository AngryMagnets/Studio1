using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField]
    private BallController ball;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            
        }
    }

    private void OnTriggerExit(UnityEngine.Collider other)
    {
        if
        ball.grounded = false;
    }
}

using UnityEngine;

public class PlaneBrake : MonoBehaviour
{
    public float decelerationForce = 5f;
    public float minSpeed = 0.1f;

    private Rigidbody planeRigidbody;
    private bool isBraking = false;

    private void Awake()
    {
        planeRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check if the "B" key is held down
        isBraking = Input.GetKey(KeyCode.B);
    }

    private void FixedUpdate()
    {
        if (isBraking && planeRigidbody.velocity.z > minSpeed)
        {
            // Calculate the deceleration force
            float deceleration = decelerationForce * Time.deltaTime;

            // Apply the deceleration force on the z-axis
            planeRigidbody.AddForce(0f, 0f, -deceleration, ForceMode.Force);
        }
    }
}

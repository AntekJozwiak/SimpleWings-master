using UnityEngine;

public class FlapsController : MonoBehaviour
{
    public float rotationAmount = 10f; // The amount to rotate the flaps by
    public float rotationSpeed = 10f; // The speed at which the flaps rotate
    public KeyCode rotateUpKey = KeyCode.S; // The key to rotate the flaps up
    public KeyCode rotateDownKey = KeyCode.W; // The key to rotate the flaps down

    private float targetRotation = 0f; // The target rotation for the flaps

    void Update()
    {
        if (Input.GetKeyDown(rotateUpKey))
        {
            targetRotation -= rotationAmount;
        }
        else if (Input.GetKeyDown(rotateDownKey))
        {
            targetRotation += rotationAmount;
        }

        float currentRotation = transform.rotation.eulerAngles.z;
        float newRotation = Mathf.MoveTowardsAngle(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, newRotation);
    }
}

using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float panSpeed = 100f;

    void Update()
    {
        // Move forward with W key
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Pan left and right with A and D keys
        float panInput = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            panInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            panInput = 1f;
        }

        transform.Rotate(Vector3.up * panInput * panSpeed * Time.deltaTime);
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            movement.z = 1f;

        if (Input.GetKey(KeyCode.DownArrow))
            movement.z = -1f;

        if (Input.GetKey(KeyCode.LeftArrow))
            movement.x = -1f;

        if (Input.GetKey(KeyCode.RightArrow))
            movement.x = 1f;

        transform.position += movement * speed * Time.deltaTime;
    }
}
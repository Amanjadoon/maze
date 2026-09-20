using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
            z = 1f;

        if (Input.GetKey(KeyCode.DownArrow))
            z = -1f;

        if (Input.GetKey(KeyCode.LeftArrow))
            x = -1f;

        if (Input.GetKey(KeyCode.RightArrow))
            x = 1f;

        Vector3 movement = new Vector3(x, 0, z);

        transform.position += movement * speed * Time.deltaTime;

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
    }
}
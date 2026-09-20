using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0, 6, -8);

    void LateUpdate()
    {
        if (player == null)
            return;

        transform.position = player.position + offset;

        transform.LookAt(player);
    }
}
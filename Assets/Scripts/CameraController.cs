using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // GameObject becomes a thing to reference inside Unity UI
	// unclear what "player" does, doesn't change UI label, "Player" appeared anyways?
	
    private Vector3 offset;

    void Start () // "initialization"?
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate () // same thing as update but just later? like priority setting?
    {
        transform.position = player.transform.position + offset;
    }
}

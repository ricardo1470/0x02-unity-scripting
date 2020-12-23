using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Vector3 cameraOffset;

	void Start ()
    {
        cameraOffset = transform.position - player.transform.position;
    }
	void LateUpdate ()
    {
		Vector3 newPosition = player.transform.position + cameraOffset;
        player.position = newPosition;
	}
}

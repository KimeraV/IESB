using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossairsController : MonoBehaviour
{
    public float crosshairSpeed = 5f; // Crosshair movement speed
    public bool isLockedOn = false; // Flag to indicate if crosshair is locked on an enemy
    public float yOffsetWhenLocked = 10f; // Y offset when locked on

    public GameObject nearestEnemy; // Reference to the nearest enemy GameObject

    private Vector3 centerScreenPosition; // Position at the center of the screen

    // Singleton instance
    private static CrossairsController instance;

    public static CrossairsController Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        centerScreenPosition = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
    }

    private void Update()
    {
        // Check if the "3" key is pressed to toggle lock-on
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ToggleLockOn();
        }

        if (isLockedOn && nearestEnemy != null)
        {
            // If locked on, move the crosshair to the nearest enemy's position with Y offset
            Vector3 targetPosition = Camera.main.WorldToScreenPoint(nearestEnemy.transform.position + Vector3.up * yOffsetWhenLocked);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * crosshairSpeed);
        }
        else
        {
            // If not locked on, return the crosshair to the center of the screen
            transform.position = Vector3.Lerp(transform.position, centerScreenPosition, Time.deltaTime * crosshairSpeed);
        }
    }

    // Call this method to toggle locking onto the nearest enemy
    public void ToggleLockOn()
    {
        isLockedOn = !isLockedOn;
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class movement_Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody playerRigidbody;

    public TextMeshProUGUI Reload;

    public float moveSpeed = 5f;
    public float sensitivity = 2f;
    private float rotationX = 0f;
    private Transform playerCamera;

    public int HPplayer = 3;

    public bool SkellyInterruptor = false, ShootingStuffActive = false;

    public GameObject gunEnd; // Reference to the GunEnd GameObject
    public GameObject skellyEnemy; // Reference to the SkellyEnemy GameObject
    private LineRenderer lineRenderer; // Reference to the LineRenderer component

    public Color lineColor = Color.yellow; // LineRenderer color
    public float yOffsetForLineRenderer = 0f; // Offset for the Y axis of SetPosition 1

    // Singleton instance
    private static movement_Player instance;

    public static movement_Player Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerCamera = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Initialize LineRenderer
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.enabled = false; // Initially disable the LineRenderer
        lineRenderer.material.color = lineColor; // Set LineRenderer color
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = playerCamera.TransformDirection(new Vector3(horizontalInput, 0f, verticalInput)).normalized;

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(Vector3.up * mouseX);
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        Vector3 newPosition = transform.position + movement * moveSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(newPosition);

        Quaternion lookRotation = Quaternion.LookRotation(playerCamera.forward, Vector3.up);
        transform.rotation = Quaternion.Euler(0f, lookRotation.eulerAngles.y, 0f);

        if (movement != Vector3.zero)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetMouseButtonDown(0) && CrossairsController.Instance.isLockedOn && !ShootingStuffActive)
        {
            StartCoroutine(ShootingStuff());
        }       
    }

    IEnumerator ShootingStuff()
    {
        animator.SetBool("IsShooting", true);

        SkellyInterruptor = true;
        ShootingStuffActive = true;
        Reload.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(0.2f);

        // Enable LineRenderer and set its positions
        lineRenderer.enabled = true;
        lineRenderer.SetPosition(0, gunEnd.transform.position);
        
        // Apply Y offset for SetPosition 1
        Vector3 skellyEnemyPosition = skellyEnemy.transform.position;
        skellyEnemyPosition.y += yOffsetForLineRenderer;
        lineRenderer.SetPosition(1, skellyEnemyPosition);

        yield return new WaitForSeconds(0.2f);

        lineRenderer.enabled = false;

        animator.SetBool("IsShooting", false);

        yield return new WaitForSeconds(1.8f);
        SkellyInterruptor = false;
        ShootingStuffActive = false;
        Reload.gameObject.SetActive(false);
        print("atirou e recarregou");
    }
}
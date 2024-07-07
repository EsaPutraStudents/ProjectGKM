using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.XR.Haptics;

public class ThirdPersonController : MonoBehaviour
{
   //input fields
    private PlayerControls playerControls;
    private InputAction move;

    //movement fields
    private Rigidbody rb;
    [SerializeField] private float movementForce = 1f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float maxSpeed = 10f;
    private Vector3 forceDirection = Vector3.zero;
    public GameObject sword;

    [SerializeField]
    private Camera playerCamera;
    private Animator animator;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        playerControls = new PlayerControls();
        animator = this.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        playerControls.Player.Jump.started += DoJump;
        playerControls.Player.Attack.started += DoAttack;
        move = playerControls.Player.Move;
        playerControls.Player.Enable();
    }

    

    private void OnDisable()
    {
        playerControls.Player.Jump.started -= DoJump;
        playerControls.Player.Attack.started -= DoAttack;
        playerControls.Player.Disable();
    }

    private void FixedUpdate()
    {
        forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera) * movementForce;
        forceDirection += move.ReadValue<Vector2>().y * GetCameraFoward(playerCamera) * movementForce;

        rb.AddForce(forceDirection, ForceMode.Impulse);
        forceDirection = Vector3.zero;

        if (rb.velocity.y < 0f)
            rb.velocity -= Vector3.down * Physics.gravity.y * 2 * Time.fixedDeltaTime;

        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity.y = 0;
        if (horizontalVelocity.sqrMagnitude > maxSpeed * maxSpeed)
            rb.velocity = horizontalVelocity.normalized * maxSpeed + Vector3.up * rb.velocity.y;
        
        LookAt();
    }

    private void LookAt()
    {
        Vector3 direction = rb.velocity;
        direction.y = 0;

        if(move.ReadValue<Vector2>().sqrMagnitude > 0.1f && direction.sqrMagnitude > 0.1f)
            this.rb.rotation = Quaternion.LookRotation(direction, Vector3.up);
        else
            rb.angularVelocity = Vector3.zero;
    }

    private Vector3 GetCameraFoward(Camera playerCamera)
    {
        Vector3 foward = playerCamera.transform.forward;
        foward.y = 0;
        return foward.normalized;
    }

    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }
    private void DoJump(InputAction.CallbackContext obj)
    {
        if (IsGrounded())
        {
            forceDirection += Vector3.up * jumpForce;
        }
    }

    private bool IsGrounded()
    {
        Ray ray = new Ray(this.transform.position + Vector3.up * 0.25f, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 1.5f))        
            return true;
        else
            return false;        
    }



    private void DoAttack(InputAction.CallbackContext obj)
    {
        animator.SetTrigger("attack");
        sword.SetActive(true);
        StartCoroutine(SwordVisible());       
    }

    IEnumerator SwordVisible()
    {
        yield return new WaitForSeconds(0.75f);
        sword.SetActive(false);
    }

    //private IEnumerator Attack()
    //{
    //    sword.SetActive(true);       
    //    yield return new WaitForSeconds(0.5f);  
    //    sword.SetActive(false);
    //}
}
 

   


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private AgentMover agentMover;

    private AgentRotate agentRotate;

    private AgentAnimation agentAnimator;

    private Vector2 pointerInput, movementInput;

    [SerializeField]
    private InputActionReference movement, pointerPosition;

    private void Awake()
    {
        agentMover = GetComponent<AgentMover>();
        agentRotate = GetComponent<AgentRotate>();
        agentAnimator = GetComponent<AgentAnimation>();
    }

    private void AnimateCharacter()
    {
        agentAnimator.PlayAnimation(movementInput);
    }

    // Update is called once per frame
    private void Update()
    {
        pointerInput = GetPointerInput();

        agentRotate.PointerPosition = pointerInput;

        movementInput = movement.action.ReadValue<Vector2>();

        agentMover.Movementinput = movementInput;

        AnimateCharacter();
    }

    private Vector2 GetPointerInput()
    {
        Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}

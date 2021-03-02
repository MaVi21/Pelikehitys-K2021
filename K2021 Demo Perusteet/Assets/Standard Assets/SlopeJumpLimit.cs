using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

/*
 * https://answers.unity.com/questions/30063/how-to-prevent-steep-wall-climbing.html
 */

public class SlopeJumpLimit : MonoBehaviour
{
    private Vector3 hitNormal;
    public static bool grounded;
    private float slopeLimit;
    private FirstPersonController firstPersonController;
    private CharacterController characterController;

    private void Start()
    {
        firstPersonController = GetComponent<FirstPersonController>();
        characterController = GetComponent<CharacterController>();
        slopeLimit = GetComponent<CharacterController>().slopeLimit;
    }

    private void Update()
    {
        /*
         * https://docs.unity3d.com/ScriptReference/CharacterController-velocity.html
         */
        float speed = this.characterController.velocity.magnitude;

        if (!grounded)
        {
            firstPersonController.m_MoveDir.x += (1f - hitNormal.y) * hitNormal.x * (speed * 1.2f);
            firstPersonController.m_MoveDir.z += (1f - hitNormal.y) * hitNormal.z * (speed * 1.2f);            
        }

        if (!(Vector3.Angle(Vector3.up, hitNormal) <= slopeLimit))
        {
            grounded = false;
        }
        else
        {
            grounded = characterController.isGrounded;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        hitNormal = hit.normal;
    }
}

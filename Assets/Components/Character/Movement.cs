using System;
using UnityEditor.Rendering;
using UnityEngine;

namespace Character
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private CharacterController _character;
        Physics _physics;
        
        public float moveSpeed = 1f;

        private void Start()
        {
            _physics = _character.GetComponent<Physics>();
        }

        private void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);


            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_character.isGrounded)
                {
                    moveDirection.y += 55;
                }
            }

            if (_physics)
                _physics.velocity = (moveDirection * moveSpeed) * Time.fixedDeltaTime;

        }

    }
}


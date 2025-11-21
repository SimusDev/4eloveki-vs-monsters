using UnityEditor.Rendering;
using UnityEngine;

namespace Character
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private CharacterController _character;

        public float moveSpeed = 5f;

        private void FixedUpdate()
        {

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

            moveDirection.y -= 9f * Time.fixedDeltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_character.isGrounded)
                {
                    moveDirection.y += 15f;
                }
            }


            _character.Move(moveDirection * moveSpeed * Time.fixedDeltaTime);
        }

    }
}


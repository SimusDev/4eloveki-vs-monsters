using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

namespace Character
{
    public class Physics : MonoBehaviour
    {
        [SerializeField] private CharacterController _character;
        [SerializeField] float gravity = 9.8f;

        public Vector3 velocity = Vector3.zero;



        void FixedUpdate()
        {

            if (!_character.isGrounded)
                velocity.y -= gravity * Time.fixedDeltaTime;

            _character.Move(velocity);
        }

        void ApplyImpulse(Vector3 impulse)
        {
            
        }
    }
    
}

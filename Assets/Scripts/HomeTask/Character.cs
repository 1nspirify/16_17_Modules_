using UnityEngine;

namespace HomeTask
{
   public class Character : MonoBehaviour
   {
       [SerializeField] float _speed;
   
       [SerializeField] float _rotationSpeed;
       [SerializeField] private Rigidbody _rigidbody;
   
       private const string _horizontal = "Horizontal";
       private const  string _vertical = "Vertical";
   
       private float _xDirection;
       private float _zDirection;
   
       private float _deadZone = 0.05f;
   
       private bool isMove;
   
       float direction;
   
       private void Update()
       {
           GetInput();
   
           if (DeadZone())
           {
               isMove = true;
           }
       }
   
       private void FixedUpdate()
       {
           if (isMove)
           {
               _rigidbody.AddForce(_xDirection * _speed, 0, 0, ForceMode.Force);
               _rigidbody.AddForce(0, 0, _zDirection * _speed, ForceMode.Force);
               
               Vector3 direction = _rigidbody.velocity;
               
               if (direction.magnitude > _deadZone)
               {
                   transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
               }
           }
       }
   
       private void GetInput()
       {
           _xDirection = Input.GetAxis(_horizontal);
           _zDirection = Input.GetAxis(_vertical);
       }
   
       private bool DeadZone() => Mathf.Abs(_zDirection) > _deadZone || Mathf.Abs(_xDirection) > _deadZone;
   } 
}

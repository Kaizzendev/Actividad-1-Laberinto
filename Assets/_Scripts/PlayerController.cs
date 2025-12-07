using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Variables")] 
        [SerializeField] internal float speed = 3;
        [SerializeField] internal float rotSpeed = 3;

        private CharacterController controller;
        private void Awake()
        {
          controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            float yInput = Input.GetAxis("Vertical");
            float xInput = Input.GetAxis("Horizontal");
            
            Vector3 move = transform.forward * yInput * speed * Time.deltaTime;
            
            transform.Rotate(Vector3.up * xInput * rotSpeed * Time.deltaTime);
            
            controller.Move(move);
        }
        
    }
}
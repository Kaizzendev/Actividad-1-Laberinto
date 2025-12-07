using System;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Variables")] 
        [SerializeField] internal float speed = 3;
        [SerializeField] internal float rotSpeed = 3;
        public bool isPlaying;
        
        private CharacterController controller;
        private void Awake()
        {
          controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (isPlaying == false) return; // Esta linea no deja mover al jugador hasta darle al play
            float yInput = Input.GetAxis("Vertical");
            float xInput = Input.GetAxis("Horizontal");

            Vector3 localMove = new Vector3(0, 0, yInput);
            Vector3 move = transform.TransformDirection(localMove) * speed * Time.deltaTime;

            transform.Rotate(Vector3.up * xInput * rotSpeed * Time.deltaTime);

            controller.Move(move);
            
        }

        private void OnTriggerEnter(Collider other) // Al tocar el trofeo ganas!
        {
            if (other.gameObject.CompareTag("Win"))
            {
                GameManager.Instance.Win();
            }
        }
    }
}
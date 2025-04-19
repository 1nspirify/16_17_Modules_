using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace HomeTask
{
    public class Enemy : MonoBehaviour
    {
        private IActiveBehaviour _iActiveBehaviour;
        private IIdleBehaviour _iIdleBehaviour;

        private bool _isActive;

        private Transform _transform;

        private List<Transform> _wayPoints;

        private const string _hasNotFound = "Character has not been found";

        public void Initialize(IActiveBehaviour iActiveBehaviour, IIdleBehaviour iActiveIdleBehaviour)
        {
            _iActiveBehaviour = iActiveBehaviour;
            _iIdleBehaviour = iActiveIdleBehaviour;
        }

        private void OnTriggerEnter(Collider other)
        {
            Character character = other.GetComponentInParent<Character>();
            if (character != null)
            {
                _isActive = true;
            }
            else
            {
                Debug.LogWarning(_hasNotFound);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            Character character = other.GetComponentInParent<Character>();
            if (character != null)
            {
                _isActive = false;
            }
            else
            {
                Debug.LogWarning(_hasNotFound);
            }
        }

        private void Update()
        {
            if (_isActive)
                _iActiveBehaviour.Activate();

            if (_isActive == false)
                _iIdleBehaviour.Idle();
        }
    }
}
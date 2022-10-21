using UnityEngine;
using UnityEngine.Assertions;

namespace Oculus.Interaction.Samples
{
    public class LookAtTarget : MonoBehaviour
    {
        [SerializeField]
        private Transform _toRotate;

        [SerializeField]
        private Transform _target;

        protected virtual void Start()
        {
            Assert.IsNotNull(_toRotate);
            Assert.IsNotNull(_target);
        }

        protected virtual void Update()
        {
            Vector3 dirToTarget = (_target.position - _toRotate.position).normalized;
            _toRotate.LookAt(_toRotate.position - dirToTarget, Vector3.up);
        }
    }
}

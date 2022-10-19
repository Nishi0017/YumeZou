using UnityEngine;

public class LookAtCameraCanvas : MonoBehaviour
{

    [SerializeField]
    private Transform _CenterEyeAnchor = null;

    private void Update()
    {
        transform.LookAt(_CenterEyeAnchor);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
    [SerializeField] OVRHand MYRightHand;
    [SerializeField] OVRSkeleton MYRightSkelton;
    [SerializeField] GameObject IndexSphere;
    private bool isIndexPinching;
    private float ThumbPinchStrength;

    void Update()
    {
        isIndexPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);

        ThumbPinchStrength = MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);

        Vector3 indexTipPos = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
        Quaternion indexTipRotate = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.rotation;
        IndexSphere.transform.position = indexTipPos;
        IndexSphere.transform.rotation = indexTipRotate;
    }

    void OnTriggerStay(Collider other)
    {

        if (ThumbPinchStrength>0.9)///つかんだ
        {
            other.gameObject.transform.parent = IndexSphere.transform;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.localPosition = Vector3.zero;

        }
        else///はなした
        {
            other.GetComponent<Rigidbody>().isKinematic = false;
            other.transform.parent = null;

        }
    }
}
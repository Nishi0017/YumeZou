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
    private bool flag = false;

    void Update()
    {
        /*if(!flag)
        {
            GameObject HI3_CCo = GameObject.Find("Hand_Index3_CapsuleCollider");
            GameObject HI2_CCo = GameObject.Find("Hand_Index2_CapsuleCollider");
            GameObject HI1_CCo = GameObject.Find("Hand_Index1_CapsuleCollider");
            GameObject HM2_CCo = GameObject.Find("Hand_Middle2_CapsuleCollider");
            GameObject HM3_CCo = GameObject.Find("Hand_Middle3_CapsuleCollider");
            GameObject HT1_CCo = GameObject.Find("Hand_Thumb1_CapsuleCollide");

            if(HI3_CCo != null)
            {
                Rigidbody rigidbody_HI3 = HI3_CCo.AddComponent<Rigidbody>();
            }
            if(HI2_CCo != null)
            {
                Rigidbody rigidbody_HI2 = HI2_CCo.AddComponent<Rigidbody>();
            }
            if(HI1_CCo != null)
            {
                Rigidbody rigidbody_HI1 = HI1_CCo.AddComponent<Rigidbody>();
            }
            if(HM2_CCo != null)
            {
                Rigidbody rigidbody_HM2 = HM2_CCo.AddComponent<Rigidbody>();
            }
            if(HM3_CCo != null)
            {
                Rigidbody rigidbody_HM3 = HM3_CCo.AddComponent<Rigidbody>();
            }
            if(HT1_CCo != null)
            {
                Rigidbody rigidbody_HT1 = HT1_CCo.AddComponent<Rigidbody>();
            }
            
            
                
            flag = true;
        }
        */


        isIndexPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);

        ThumbPinchStrength = MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);

        Vector3 indexTipPos = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
        Quaternion indexTipRotate = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.rotation;
        IndexSphere.transform.position = indexTipPos;
        IndexSphere.transform.rotation = indexTipRotate;
        //Debug.Log((int)OVRSkeleton.BoneId.Hand_IndexTip);
    }

    void OnTriggerStay(Collider other)
    {
        var component = other.gameObject.GetComponent<Rigidbody>();
        if(component != null)
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
}
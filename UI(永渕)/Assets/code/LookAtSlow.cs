using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSlow : MonoBehaviour
{
    public GameObject targetObject; // �����������I�u�W�F�N�g��Inspector�������Ă���

    // Update is called once per frame
    void Update()
    {
        // �⊮�X�s�[�h�����߂�
        float speed = 0.1f;
        // �^�[�Q�b�g�����̃x�N�g�����擾
        Vector3 relativePos = targetObject.transform.position - this.transform.position;
        // �������A��]���ɕϊ�
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        // ���݂̉�]���ƁA�^�[�Q�b�g�����̉�]����⊮����
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
    }
}

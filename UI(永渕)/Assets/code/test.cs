using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform targetObject; // �����������I�u�W�F�N�g��Inspector�������Ă���
    private Vector3 input;

    // Update is called once per frame
    void Update()
    {
        // �⊮�X�s�[�h�����߂�
        float speed = 0.01f;
        // �^�[�Q�b�g�����̃x�N�g�����擾
        Vector3 relativePos = new Vector3(targetObject.position.x, this.transform.position.y, targetObject.position.z) - this.transform.position;
        // �������A��]���ɕϊ�
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        // ���݂̉�]���ƁA�^�[�Q�b�g�����̉�]����⊮����
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
    }
}

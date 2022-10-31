using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ykotei : MonoBehaviour
{
    public GameObject targetObject; // 注視したいオブジェクトをInspectorから入れておく

    // Update is called once per frame
    void Update()
    {
        // 補完スピードを決める
        float speed = 0.01f;
        // ターゲット方向のベクトルを取得
        Vector3 relativePos = new Vector3(targetObject.transform.position.x, this.transform.position.y, targetObject.transform.position.z) - this.transform.position;
        // 方向を、回転情報に変換
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        // 現在の回転情報と、ターゲット方向の回転情報を補完する
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, speed);
    }
}

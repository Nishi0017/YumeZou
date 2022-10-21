using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaGenerater : MonoBehaviour
{
    [Header("クローン数")] public int n = 30;

    // プレハブ格納用
    public GameObject CubePrefab;
    private Vector3 clonePos;
    private float speed = 0;

    void Start()
    {
        clonePos = this.transform.position;
    }

    void Update()
    {
        // 一定時間ごとにプレハブを生成
        if (Time.frameCount % 5.0f == 0 && n >= 0)
        {
            // 生成位置
            Vector3 pos = clonePos;
            // プレハブを指定位置に生成
            Instantiate(CubePrefab, pos, Quaternion.identity);
            n -= 1;

        }
    }
}

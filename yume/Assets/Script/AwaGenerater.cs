using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaGenerater : MonoBehaviour
{
    [Header("煙")] public kemuriController kemuriController;
    [Header("クローン数")] public int n = 30;
    [Header("泡のプレハブ")]public GameObject awaPrefab;

    private GameObject Obj;
    private GameObject parentFloor;
    private Vector3 clonePos;

    void Start()
    {
        clonePos = this.transform.position;
        parentFloor = transform.parent.gameObject;
        
    }

    void Update()
    {
        // 一定時間ごとにプレハブを生成
        if (Time.frameCount % 5.0f == 0 && n >= 0)
        {
            // 生成位置
            Vector3 pos = clonePos;
            // プレハブを指定位置に生成
            Obj = Instantiate(awaPrefab, pos, Quaternion.identity);
            Obj.transform.parent = parentFloor.transform;
            n -= 1;
        }else if(n == 0)
        {
            kemuriController.StopKemuri();
        }
    }
}

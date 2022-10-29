using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaGenerater : MonoBehaviour
{
    [Header("煙")] public kemuriController kemuriController;
    [Header("クローン数")] public int n = 30;
    [Header("泡のプレハブ")]public GameObject[] awaPrefab;
    [Header("発生する感覚（最小）")] public int mini = 3;
    [Header("発生する感覚（最大）")] public int max = 60;


    private int GenePs = 3;
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
        if (Time.frameCount % GenePs == 0 && n >= 0)
        {
            int r = Random.Range(0, awaPrefab.Length);
            // 生成位置
            Vector3 pos = clonePos;
            // プレハブを指定位置に生成
            Obj = Instantiate(awaPrefab[r], pos, Quaternion.identity);
            Obj.transform.parent = parentFloor.transform;
            n -= 1;
            GenePs = Random.Range(mini, max);
        }else if(n == 0)
        {
            kemuriController.StopKemuri();
            Debug.Log("終了");
        }
    }
}

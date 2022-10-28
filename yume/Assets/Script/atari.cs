using com.zibra.liquid.DataStructures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atari : MonoBehaviour
{
    public GameObject kemuri;

    private Color objColor = Color.white;
    
    private GameObject waterObj;
    private saveColor saveColorScript;
    
    private Transform[] awaGene;
    private int ChildNum= 0;

    private void Start()
    {
        objColor = new Color(161.0f / 255, 161.0f / 255, 161.0f / 255, 1.0f);
        //isOn_color = false;
        //isOn = false ;
        
        waterObj = transform.parent.gameObject;
        ChildNum = waterObj.transform.childCount;
        Debug.Log(ChildNum);
        saveColorScript = waterObj.GetComponent<saveColor>();

        //ZibraLiquidMaterialParameters = waterObj.GetComponent<ZibraLiquidMaterialParameters>();
        
        awaGene = new Transform[ChildNum];
        
    }

    IEnumerator StartAnime() 
    {
    kemuri.gameObject.SetActive(true);
    Debug.Log("発生");
    //2秒待つ
    yield return new WaitForSeconds(2);
 
    kemuri.gameObject.SetActive(false);
    Debug.Log("消す");
    //再開してから実行したい処理を書く
    //例：敵オブジェクトを破壊
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Color")
        {
            //isOn_color = true;
            GameObject obj = other.gameObject;
            objColor = obj.GetComponent<Renderer>().material.color;
            //ZibraLiquidMaterialParameters.Color = objColor; 
            GetComponent<Renderer>().material.color = objColor;
            saveColorScript.SaveColor(objColor);
            Destroy(obj);
        }
        else if (other.gameObject.tag == "KL")
        {

            Destroy(other.gameObject);
            StartCoroutine("StartAnime");
            //isOn = true;


            for (int i = 0; i < ChildNum; i++)
            {
                int I = i + 1;
                awaGene[i] = waterObj.transform.Find("AwaGene" + I);
                Debug.Log(awaGene[i]);
                Debug.Log("AwaGene" + I);
                if (awaGene[i] != null)
                {
                    awaGene[i].gameObject.SetActive(true);
                }
                else
                {
                    break;
                }

            }
            Destroy(this.gameObject);
        }

    }

    
}

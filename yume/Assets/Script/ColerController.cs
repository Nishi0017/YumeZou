using com.zibra.liquid.DataStructures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColerController : MonoBehaviour
{
    public ZibraLiquidMaterialParameters ZibraLiquidMaterialParameters;
    public atari atari;
    public bool once = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!once && atari.isOn_color)
        {
            ZibraLiquidMaterialParameters.Color = atari.objColor;
            once = true;
        }
    }
}

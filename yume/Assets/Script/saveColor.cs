using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveColor : MonoBehaviour
{
    public Color colorSave = Color.white;
    public void SaveColor(Color color)
    {
        colorSave = color;
    }
}

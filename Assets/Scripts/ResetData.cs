using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetData : MonoBehaviour
{
    public void ClearData()
    {
        SaveController.Instance.ClearSave();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OperationsOnData : MonoBehaviour
{
    private static string _json;
    DataJSON _dataJSON;
    public void SaveData()
    {
        _json = JsonUtility.ToJson(_dataJSON);
        Debug.Log(_json);
    }

    public void LoadData()
    {
        JsonUtility.FromJsonOverwrite(_json, _dataJSON);
        Debug.Log(_dataJSON);
    }
}

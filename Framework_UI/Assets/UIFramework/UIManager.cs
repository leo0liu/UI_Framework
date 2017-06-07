using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class UIManager  {

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new UIManager();
            }
            return _instance;
        }
    }

    private Dictionary<UIPanelType, string> panelPathDict;//存储所有面板Prefab路径


    private UIManager()
    {
        ParseUIPanelTypeJson();
    }

    [Serializable]

    class UIPanelTypeJson
    {
        public List<UIPanelInfo> infolist;
    }

     private void ParseUIPanelTypeJson()
    {
        panelPathDict = new Dictionary<UIPanelType,string>();
        TextAsset ta=Resources.Load<TextAsset>("UIPanelTpe");

      UIPanelTypeJson jsonObject= JsonUtility.FromJson<UIPanelTypeJson>(ta.text);

        foreach (UIPanelInfo info in jsonObject.infolist)
        {
            panelPathDict.Add(info.panelType,info.path);
        }
    }

    public void Test()
    {
        string path;
        panelPathDict.TryGetValue(UIPanelType.Knapsack,out path);
        Debug.Log(path);
    }
}


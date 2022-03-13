using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlSelect : MonoBehaviour{
    void Start(){}
    void Update(){}
    public void SetMap(string str){if(!String.IsNullOrEmpty(str))GameSession.instance.mapCurrent=str;}
}

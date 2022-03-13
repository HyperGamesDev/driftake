using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSettings : MonoBehaviour{
    [SerializeField] _BGClass[] bgs;
    
    SpriteRenderer spr;
    Sprite defSpr;
    Material defMat;
    void Start(){
        spr=GetComponent<SpriteRenderer>();
        defSpr=spr.sprite;
        defMat=spr.material;
    }
    void Update(){
        var gs=GameSession.instance;
        var bg=Array.Find(bgs,x=>x._refName==gs.mapCurrent);
        if(bg.sprite!=null){spr.sprite=bg.sprite;}
        else{spr.sprite=defSpr;}
        if(bg.mat!=null){spr.material=bg.mat;}
        else{spr.material=defMat;}
    }
}

[System.Serializable]
public class _BGClass{
    public string _refName="map1";
    public Sprite sprite;
    public Material mat;
}
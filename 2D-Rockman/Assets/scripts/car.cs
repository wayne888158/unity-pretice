﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
     //單行註解 2021.4.25 wayne
     /*
        * 多行註解
        */
       //物件資料 - 欄位 Field:儲存物件資料
       //欄位語法
       //類型 名稱  指定 預設值 結尾

       //四大類型
       //整 數int:任何沒有小數點的正負整數
       //浮點數 float:任何有小數點的正負整數,有小數點結尾要加f(大小寫都可)
       //字 串 string:任何文字,必須使用雙引號""
       //布林值 bool:正反 true false
       //關鍵字 顏色 :藍色
       //自訂名稱 顏色:白色
       //修飾詞
       //私人:不顯示 private(預設值)
       //公開:顯示 public

       //欄位屬性語法
       //[屬性名稱(屬性內容)]
       //標題 Header(字串)
       //提示 Tooltip(字串)
       //範圍 Range
        [Header("汽車的cc數")]
        [Tooltip("這是汽車的cc數.")]
        [Range(1000,5000)]
        public int cc = 3000;
        // 逗號後面的空格可有可無
        [Header("汽車的重量"), Tooltip("這是汽車的重量."), Range(0.5f,10)]
       public float weight = 1.8f;
       [Header("汽車的品牌")]      
       public string brand = "BMW";
       [Header("有沒有天窗")] 
       bool hasWindow = true;

    //Unity 常見類型
    //顏色 Color
    public Color color;
    public Color red = Color.red;
    public Color y = Color.yellow;
    //指定顏色的值為0-1
    public Color myColor = new Color(0.3f, 0, 0.5f);           //Color(紅,綠,藍)
    public Color myColor2 = new Color(0, 0.5f, 0.5f, 0.5f);    //Color(紅,綠,藍)

    // 座標二維-四維 Vecter2 Vector3 Vector4
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one =Vector2.one;
    public Vector2 v2my = new Vector2(7, 9);

    public Vector3 v3 = new Vector3(1, 2, 3);
    public Vector4 v4 = new Vector4(1, 2, 3, 4);

    //按鍵 keyCode
    public KeyCode key1;
    public KeyCode key2 = KeyCode.A;
    public KeyCode key3 = KeyCode.Mouse0;



    


}

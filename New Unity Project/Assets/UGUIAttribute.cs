using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
 
public class UGUIAttribute: Attribute
{
     
    public Type type;
    public string childObjectPath;
    public UGUIAttribute(System.Type type, string childObjectPath = null)
    {
        this.type = type;
        this.childObjectPath = childObjectPath;
    } 
    public static void Init(MonoBehaviour behaviour)
    { 
        foreach (var field in behaviour.GetType().GetFields())
        {
            var attribute = field.GetCustomAttribute(typeof(UGUIAttribute)) as UGUIAttribute;
            if (attribute != null)
            {
                var name = field.Name;
                //이름이 _로 시작하는 경우만 찾음 

                string path = null;
                if (attribute.childObjectPath == null)
                {
                    path = $"_{name}"; 
                }
                else
                {
                    //마지막에 /를 적은경우 지워주기
                    if(attribute.childObjectPath[attribute.childObjectPath.Length-1] == '/') 
                        attribute.childObjectPath = attribute.childObjectPath.Remove(attribute.childObjectPath.Length-1, 1); 

                    path = $"{attribute.childObjectPath}/{name}"; 
                }
                var find = behaviour.gameObject.transform.Find(path); 
                if(find != null)
                {  
                   field.SetValue(behaviour, find.GetComponent(attribute.type));
                }
            }
        }
    }
}

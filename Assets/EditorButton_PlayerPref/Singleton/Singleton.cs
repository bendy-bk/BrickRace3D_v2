﻿using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<T>();
            return _instance;
        }
    }
}

//public abstract class Singleton<T> where T : class, new()
//{
//    private static T _instance;

//    public static T Instance
//    {
//        get
//        {
//            if (_instance == null)
//                _instance = new T();
//            return _instance;
//        }
//    }
//}
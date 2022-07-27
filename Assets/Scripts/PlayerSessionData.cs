using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSessionData : MonoBehaviour
{
    public static PlayerSessionData Instance;
    public string playerName;

    public void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

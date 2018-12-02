using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour {
    public static PlayerMenu instance;
    #region Singleton
    void Awake()
    {
        if(instance!=null)
        {
            Debug.LogWarning("More than one player_menu has found");
            return;
        }
        instance = this;
    }

#endregion
}

using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;
    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public event Action<Vector3> OnMapClick;

    public void TriggerMapClick(Vector3 _Position)
    {
        OnMapClick?.Invoke(_Position);
    }
    /*====================================================================
                                    Interactables
    ======================================================================*/
    public event Action OnGive;
    public event Action OnPickUp;
    public event Action OnUse;

    public event Action OnOpen;
    public event Action OnLookAt;
    public event Action OnPush;

    public event Action OnClose;
    public event Action OnTalkTo;
    public event Action OnPull;
}

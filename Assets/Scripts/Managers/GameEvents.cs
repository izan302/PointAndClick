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
    public event Action<String> OnMouseOverInteractable;
    public void TriggerMouseOverInteractable(String _InteractableName) {
        OnMouseOverInteractable?.Invoke(_InteractableName);
    }
    public event Action OnMouseExitInteractable;
    public void TriggerMouseExitInteractable() {
        OnMouseExitInteractable?.Invoke();
    }

    // Buttons 
    public event Action<String> OnGive;

    public event Action<String> OnPickUp;
    public event Action<String> OnUse;

    public event Action<String> OnOpen;
    public event Action<String> OnLookAt;
    public event Action<String> OnPush;

    public event Action<String> OnClose;
    public event Action<String> OnTalkTo;
    public event Action<String> OnPull;
    
    // --- TRIGGERS ---
    public void TriggerOnGive(string _Text) => OnGive?.Invoke(_Text);
    
    public void TriggerOnPickUp(string _Text) => OnPickUp?.Invoke(_Text);
    
    public void TriggerOnUse(string _Text) => OnUse?.Invoke(_Text);

    public void TriggerOnOpen(string _Text) => OnOpen?.Invoke(_Text);
    
    public void TriggerOnLookAt(string _Text) => OnLookAt?.Invoke(_Text);
    
    public void TriggerOnPush(string _Text) => OnPush?.Invoke(_Text);

    public void TriggerOnClose(string _Text) => OnClose?.Invoke(_Text);
    
    public void TriggerOnTalkTo(string _Text) => OnTalkTo?.Invoke(_Text);
    
    public void TriggerOnPull(string _Text) => OnPull?.Invoke(_Text);
}

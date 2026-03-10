using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;



    enum ActiveVerb
    {
        WalkTo,
        Give,
        PickUp,
        Use,
        Open,
        LookAt,
        Push,
        Close,
        TalkTo,
        Pull
    }
    private ActiveVerb m_ActiveVerb = ActiveVerb.WalkTo;
    void Awake()
    {
        if (Instance == null) Instance = this;
        GameEvents.Instance.OnGive += HandleGive;
        GameEvents.Instance.OnPickUp += HandlePickUp;
        GameEvents.Instance.OnUse += HandleUse;
        GameEvents.Instance.OnOpen += HandleOpen;
        GameEvents.Instance.OnLookAt += HandleLookAt;
        GameEvents.Instance.OnPush += HandlePush;
        GameEvents.Instance.OnClose += HandleClose;
        GameEvents.Instance.OnTalkTo += HandleTalkTo;
        GameEvents.Instance.OnPull += HandlePull;
    }

    void Update()
    {
        
    }

    private void HandleGive(string _text)  {
        
    }
    private void HandlePickUp(string _text){
        
    }
    private void HandleUse(string _text)   {
        
    }
    private void HandleOpen(string _text)  {
        
    }
    private void HandleLookAt(string _text){
        
    }
    private void HandlePush(string _text)  {
        
    }
    private void HandleClose(string _text) {
        
    }
    private void HandleTalkTo(string _text){
        
    }
    private void HandlePull(string _text)  {
        
    }
}

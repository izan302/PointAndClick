using System.Data.Common;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    [SerializeField] private LayerMask m_MapLayerMask;
    [SerializeField] private LayerMask m_Interactable;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {

    }

    public Vector3 GetWorldMousePosition()
    {

        Vector3 l_MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        l_MousePosition.z = 0;

        RaycastHit2D l_RaycastHit = Physics2D.Raycast(l_MousePosition, Vector2.zero, 0f, m_MapLayerMask);
        if (l_RaycastHit.collider != null)
        {
            return l_RaycastHit.point;
        }
       return Vector3.negativeInfinity;
    }
}

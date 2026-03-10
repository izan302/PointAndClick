using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField] private Camera m_Camera;
    [SerializeField] private Collider2D m_CameraBounds;

    [Header("Configuración Ventana")]
    [Tooltip("Porcentaje de la pantalla ocupado por el HUD")]
    [Range(0f, 1f)]
    [SerializeField] private float m_UIPercentage = 0.3f;
    [SerializeField] private float m_SmoothSpeed = 5f;

    private Transform m_Target;
    void Start()
    {
        m_Target = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerContoller>().m_FootTransform;

        if (m_Camera == null) m_Camera = Camera.main;
        if (m_CameraBounds == null) Debug.LogError("Collider2D reference is missing");
    }

    void LateUpdate()
    {
        if (m_Target == null || m_CameraBounds == null) return;

        float l_FullHeight = m_Camera.orthographicSize;
        float l_FullWidth = l_FullHeight * m_Camera.aspect;

        float l_UIOffset = l_FullHeight * m_UIPercentage;
        float l_VisibleHeight = l_FullHeight - l_UIOffset;

        Bounds l_Bounds = m_CameraBounds.bounds;
        Vector3 l_LocalMin = transform.InverseTransformPoint(l_Bounds.min);
        Vector3 l_LocalMax = transform.InverseTransformPoint(l_Bounds.max);

        float l_MinX = l_LocalMin.x + l_FullWidth;
        float l_MaxX = l_LocalMax.x - l_FullWidth;

        float l_MinY = l_LocalMin.y + l_VisibleHeight;
        float l_MaxY = l_LocalMax.y - l_FullHeight;

        Vector3 l_PlayerLocalPos = transform.InverseTransformPoint(m_Target.position);
        float l_TargetLocalX = Mathf.Clamp(l_PlayerLocalPos.x, l_MinX, l_MaxX);
        float l_TargetLocalY = Mathf.Clamp(l_PlayerLocalPos.y - l_UIOffset, l_MinY, l_MaxY);

        Vector3 l_CurrentLocalPos = m_Camera.transform.localPosition;
        Vector3 l_NextLocalPos = new Vector3(l_TargetLocalX, l_TargetLocalY, l_CurrentLocalPos.z);

        m_Camera.transform.localPosition = Vector3.Lerp(
            l_CurrentLocalPos,
            l_NextLocalPos,
            Time.deltaTime * m_SmoothSpeed
        );
    }
}
using UnityEngine;

public class CameraCControl : MonoBehaviour
{
    [Header("目標物件")]
    public Transform target;
    
    [Header("速度"), Range(0, 1000)]
    public float speed = 1.5f;

    
    /// <summary>
    /// 追蹤目標物件
    /// </summary>
    private void Track()
    {
        Vector3 posA = target.position;
        Vector3 posB = transform.position;
        posA.z = -10;
        posB = Vector3.Lerp(posA, posB, 0.5f * speed * Time.deltaTime);
        transform.position = posB;
    }

    private void LateUpdate()
    {
        Track();
    }


}

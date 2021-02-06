using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed;

    public float h;
    private Rigidbody2D rig;

    #endregion

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        GetHorizontal();
    }


    #region 方法

    private void GetHorizontal()
    {
        h = Input.GetAxis("Horizontal");
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
    }





        #endregion
    }

using UnityEngine;
public class Player : MonoBehaviour
{ //移動速度
    [Header("玩家移動速度")]
    [Tooltip("這是玩家移動速度")]
    [Range(0, 1000)]
    public float  speed = 10.5f;
    [Header("玩家跳躍高度")]
    [Tooltip("這是玩家跳越高度")]
    [Range(0, 3000)]
    public int high = 100;
    [Header("玩家血量")]
    [Tooltip("這是玩家血量")]
    [Range(0, 200)]
    public float hp = 100;
    [Header("有沒有在地板上")]
    [Tooltip("角色是否在地板上")]
    public bool onfloor = true;
    [Header("子彈")]
    [Tooltip("角色要發射的子彈物件")]
    public GameObject bullet;
    [Header("子彈生成點")]
    [Tooltip("生成子彈的位置")]
    public Transform bulletPoint;
    [Range(0, 5000)]
    public int bulletSpeed = 800;
    [Header("開槍音效")]
    [Tooltip("開槍的聲音")]
    public AudioClip bulletsound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
}

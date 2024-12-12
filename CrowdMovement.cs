using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour
{
    //设置相应的分身的活动范围
    public float AvatarRange = 25;
    private Animator animator;
    //插值动画参数Speed，和Direction的时间
    private float SpeedDampTime = 0.25f;
    private float DirectionDampTime = 0.25f;
    private Vector3 TargetPosition = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
        {
            return;
        }
        //对跳跃翻滚的全部随机设置
        int r = Random.Range(0, 50);
        animator.SetBool("jump", r == 20);
        animator.SetBool("dive", r == 30);
        //设置计算两个坐标点之间的距离
        if (Vector3.Distance(TargetPosition, animator.rootPosition) > 5)
        {
            //注意这个SetFloat函数， 其中SpeedDampTime的是到达目标值所用时间
            //一个缓入的过程
            animator.SetFloat("speed", 1, SpeedDampTime, Time.deltaTime);
            //得到当前角色方向，得到当前的方向的规范向量。
            Vector3 curentDir = animator.rootRotation * Vector3.forward;
            //规范化向量
            //得到应该朝向的方向
            Vector3 wantedDir = (TargetPosition - animator.rootPosition).normalized;
            //如果当前的角度没有超过90度
            if (Vector3.Dot(curentDir, wantedDir) > 0)
            {
                //注意其DirectionDampTime，可以使得旋转方向缓慢增加
                animator.SetFloat("direction", Vector3.Cross(curentDir, wantedDir).y, DirectionDampTime, Time.deltaTime);
            }
            //超过90度，当前朝向方向和目标方向差距过大。
            else
            {
                animator.SetFloat("direction", Vector3.Cross(curentDir, wantedDir).y > 0 ? 1 : -1, DirectionDampTime, Time.deltaTime);
            }
        }
        //如果目标位置和当前位置的差距比较小。
        else
        {
            //不断减速。缓入减速。
            animator.SetFloat("speed", 0, SpeedDampTime, Time.deltaTime);
            //得到当前speed的值并且重置当前的目标位置。
            if (animator.GetFloat("speed") < 0.01f)
            {
                TargetPosition = new Vector3(Random.Range(-AvatarRange, AvatarRange), 0, Random.Range(-AvatarRange, AvatarRange));
            }
        }
    }
}

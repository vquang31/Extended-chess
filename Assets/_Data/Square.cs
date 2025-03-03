using System.ComponentModel;
using UnityEngine;

public class Square : NewMonoBehaviour
{
    private Vector2Int _position;
    public Vector2Int Position
    {
        get => _position;
    }



    private int _height = 1;

    private ItemBuff itemBuff;

    protected override void Awake()
    {
        this.LoadComponents();
    }


    protected void RandomHeight()
    {
        _height = Random.Range(1, Const.MAX_BEGIN_HEIGHT_GROUND);
    }

    protected override void Reset()
    {
        this.LoadComponents();
        this.ResetValues();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.RandomHeight();
    }

}

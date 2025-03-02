using Mono.Cecil;
using System;
using System.Collections.Generic;
using UnityEngine;
using static Const;

public class Piece : NewMonoBehaviour
{
    private int side;

    protected int maxHp;

    protected int hp;

    protected int attackPoint;

    protected int jumpPoint;

    //private int movePoint;
    //protected int speed;

    protected List<Effect> effects;



    protected override void Reset()
    {
        this.LoadComponents();
        this.ResetValues();
    }

    protected virtual void LoadSide()
    {
        
    }
    protected override void ResetValues()
    {
        this.LoadSide();
        // switch expression C# 8.0
        PieceType pieceType = this switch
        {
            Bishop => PieceType.Bishop,
            Rook => PieceType.Rook,
            Queen => PieceType.Queen,
            Pawn => PieceType.Pawn,
            King => PieceType.King,
            _ => throw new InvalidOperationException("Unknown piece type")
        };

         var stats = Const.DEFAULT_STATS[pieceType];
        // Gán giá trị cho các thuộc tính
        this.maxHp = stats.MaxHp;
        this.hp = this.maxHp;
        this.attackPoint = stats.AttackPoint;
        this.jumpPoint = stats.JumpPoint;


        this.effects = new List<Effect>();
    }


    public virtual List<Vector2Int> GetValidMoves()
    {
        return new List<Vector2Int>();
    }

    public virtual List<Vector2Int> GetValidAttacks(int side)
    {
        return new List<Vector2Int>();
    }

    protected virtual void Move(Vector2Int newPos)
    {

    }

    protected virtual void Attack(Vector2Int targetPos)
    {

    }
    protected void Delete()
    {
        Destroy(gameObject);
    }


}

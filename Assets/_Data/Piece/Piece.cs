using Mono.Cecil;
using System;
using System.Collections.Generic;
using UnityEngine;
using static Const;

public class Piece : NewMonoBehaviour
{
    private int _side;

    protected int _maxHp;

    protected int _hp;

    protected int _attackPoint;

    protected int _jumpPoint;

    // height range attack of piece
    protected int _heightRangeAttack;

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
        this._maxHp = stats.MaxHp;
        this._hp = this._maxHp;
        this._attackPoint = stats.AttackPoint;
        this._jumpPoint = stats.JumpPoint;
        this._heightRangeAttack = stats.RangeAttack;

        this.effects = new List<Effect>();
    }


    protected virtual List<Vector2Int> GetValidMoves()
    {
        return new List<Vector2Int>();
    }

    protected virtual List<Vector2Int> GetValidAttacks(int side)
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

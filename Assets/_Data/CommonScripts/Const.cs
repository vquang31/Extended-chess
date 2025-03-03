using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Const
{
    public const int SIDE_WHITE = 1;
    public const int SIDE_BLACK = -1;


    public const int MAX_HEIGHT_GROUND = 10;

    public const int MAX_BEGIN_HEIGHT_GROUND = 5;

    public const int MAX_BOARD_SIZE = 24;


    public enum PieceType
    {
        Pawn = 0,
        Rook = 1,
        Knight = 2,
        Bishop = 3,
        Queen = 4,
        King = 5
    }

    public static readonly Dictionary<PieceType, (int MaxHp, int AttackPoint, int JumpPoint, int RangeAttack)> 
        DEFAULT_STATS = new Dictionary<PieceType, (int, int, int,int)>
        {
            { PieceType.Pawn,   (100,  10, 1, 1) },
            { PieceType.Rook,   (200,  50, 1, 2) },
            { PieceType.Knight, (150,  30, 3, 3) },
            { PieceType.Bishop, (150,  40, 1, 2) },
            { PieceType.Queen,  (300,  60, 2 ,2) },
            { PieceType.King,   (500, 100, 2, 2) }
        };
}

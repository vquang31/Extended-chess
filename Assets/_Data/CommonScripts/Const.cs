using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Const
{
    public const int SIDE_WHITE = 1;
    public const int SIDE_BLACK = -1;

    public enum PieceType
    {
        Pawn = 0,
        Knight = 1,
        Bishop = 2,
        Rook = 3,
        Queen = 4,
        King = 5
    }

    public static readonly Dictionary<PieceType, (int MaxHp, int AttackPoint, int JumpPoint)> 
        DEFAULT_STATS = new Dictionary<PieceType, (int, int, int)>
        {
            { PieceType.Pawn, (100, 1, 1) },
            { PieceType.Rook, (200, 5, 1) },
            { PieceType.Knight, (150, 3, 3) },
            { PieceType.Bishop, (150, 4, 1) },
            { PieceType.Queen, (300, 6, 2) },
            { PieceType.King, (500, 10, 2) }
        };



}

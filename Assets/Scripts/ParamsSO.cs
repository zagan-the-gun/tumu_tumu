using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ParamsSO : ScriptableObject
{
    [Header("初期のボールの数")]
    public int initBallCount;

    [Header("ボールを消した時のスコア")]
    public int scorePoint;

    [Header("ボールの距離判定")]
    public float ballDistance;

    public const string PATH = "ParamsSO";

    private static ParamsSO _entity;
    public static ParamsSO Entity
    {
        get
        {
            if (_entity == null)
            {
                _entity = Resources.Load<ParamsSO>(PATH);
                if (_entity == null)
                {
                    Debug.LogError(PATH + " not found");
                }
            }
            return _entity;
        }
    }
}


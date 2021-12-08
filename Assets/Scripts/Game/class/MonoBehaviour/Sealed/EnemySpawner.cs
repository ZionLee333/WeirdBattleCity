
using UnityEngine;

public sealed class EnemySpawner : Spawner
{
    public static EnemySpawner instance { get; private set; }

    protected override void Awake()
    {
        base.Awake();

        instance = this;
    }

    public void Spawn(CharacterCode characterCode, int characterLevel, int spotNumber)
    {
        var character = ObjectPool.instance.Pop(characterCode);

        character.transform.parent = spots[spotNumber];

        character.transform.localPosition = Vector3.zero;

        character.transform.localEulerAngles = Vector3.zero;

        character.SetLevel(characterLevel);

        ++spawnCount;
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateNotes : MonoBehaviour
{
    [SerializeField] private Notes notePrefab_1;
    [SerializeField] private Notes notePrefab_2;

    private int _rnd;
    private Notes _usingNotes;
    public void SpawnNote()
    {
        _rnd = Random.Range(1, 3);
        _usingNotes = _rnd % 2 == 0 ? notePrefab_1 : notePrefab_2;
        Instantiate(_usingNotes, new Vector3(20, 0, 0), Quaternion.identity);
    }
}

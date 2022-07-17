using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NotesInstance : MonoBehaviour
{
    [SerializeField] private GenerateNotes generateNotes = default;
    public void NoteEvent()
    {
        Debug.Log("音なったンゴ");
        generateNotes.SpawnNote();
    }
}

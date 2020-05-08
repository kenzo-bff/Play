﻿using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class RecordedNote
{
    public int RecordedMidiNote { get; set; }
    public int RoundedMidiNote { get; set; }

    public int StartBeat { get; set; }
    public int EndBeat { get; set; }

    public Note TargetNote { get; set; }

    public RecordedNote(int recordedMidiNote, int roundedMidiNote, int startBeat, int endBeat, Note targetNote)
    {
        RecordedMidiNote = recordedMidiNote;
        RoundedMidiNote = roundedMidiNote;
        StartBeat = startBeat;
        EndBeat = endBeat;
        TargetNote = targetNote;
    }
}

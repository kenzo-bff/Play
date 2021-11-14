
using System;

[Serializable]
public class AudioSettings
{
    // Range: 0..100
    public int PreviewVolumePercent { get; set; } = 50;
    public bool BackgroundMusicEnabled { get; set; } = true;

    public EPitchDetectionAlgorithm pitchDetectionAlgorithm = EPitchDetectionAlgorithm.Dywa;
}

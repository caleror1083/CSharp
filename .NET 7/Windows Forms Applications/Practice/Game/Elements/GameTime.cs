using System;

namespace Game.Elements;

public class GameTime
{
    public DateTime StartDate { get; set; }
    public DateTime FrameDate { get; set; }
    public TimeSpan TotalTime { get { return FrameDate - StartDate; } }
    public int FrameMilliseconds { get; set; }

    public GameTime()
    {
        StartDate =
        FrameDate = DateTime.Now;
    }
}
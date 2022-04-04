using System;

public class Training
{
    public string Description { get; set; }
    private Training[] _lessons;

    public Training(params Training[] lessons)
    {
        _lessons = new Training[lessons.Length];
        for(int i=0;i<lessons.Length;i++)
        {
            _lessons[i] = lessons[i];
        }
    }

    public void Add(Training tr)
    {
        Array.Resize(ref _lessons, _lessons.Length + 1);
        _lessons[_lessons.Length-1] = tr;
    }

    public bool IsPractical()
    {
        foreach(var lesson in _lessons)
        {
            if (!(lesson is PracticalLesson)) return false;
        }
        return true;
    }

    public Training Clone()
    {
        return new(_lessons);
    }
}
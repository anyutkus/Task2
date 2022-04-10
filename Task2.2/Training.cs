using System;

public class Training : BasicItem
{
    private Lesson[] _lessons;

    public Training(params Lesson[] lessons)
    {
        _lessons = new Lesson[lessons.Length];
        for(int i=0;i<lessons.Length;i++)
        {
            _lessons[i] = lessons[i];
        }
    }

    public void Add(Lesson tr)
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
        Training newTr = new Training();

        for(var i = 0; i < this._lessons.Length; i++)
        {
            newTr.Add(_lessons[i] is Lection ? ((Lection)_lessons[i]).Clone() : ((PracticalLesson)_lessons[i]).Clone());
        }

        return newTr;
    }
}
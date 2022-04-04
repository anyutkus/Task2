using System;
using System.Linq;

public class Matrix
{
    private int[] _elements;
    public int Size { get; }

    public Matrix (params int[] elements)
    {
        if (elements == null)
        {
            Size = 0;
        }
        else
        {
            Size = elements.Length;
            _elements = new int[Size];
            for (var i = 0; i < Size; i++)
            {
                _elements[i] = elements[i];
            }
        }
    }

    public int this[int i, int j]
    {
        get
        {
            if((i!=j)||(i<0)||(i>=Size)||(j<0)||(j>=Size))
            {
                return 0;
            }
            else
            {
                return _elements[i];
            }
        }
    }

    public int Track() => _elements.Sum();

    public override bool Equals(object obj)
    {
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            Matrix m = (Matrix)obj;

            if (m.Size == this.Size)
            {
                foreach (int i in _elements)
                {
                    if (i != m._elements[i]) return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public override string ToString()
    {
        string str = "";

        for (int i=0;i<Size;i++)
        {
            for(int j=0;j<Size;j++)
            {
                if (i != j)
                {
                    str += string.Format("{0,5:D}", 0);
                }
                else
                {
                    str += string.Format("{0,5:D}", _elements[i]);
                }
            }
            str += "\n";
        }
        return str;
    }

}
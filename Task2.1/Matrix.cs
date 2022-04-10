using System;

public class Matrix
{
    private int[] _elements;
    public int Size
    {
        get => _elements.Length;
    }

    public Matrix (params int[] elements)
    {
        var size = elements == null ? 0 : elements.Length;

        _elements = new int[size];
        for (var i = 0; i < Size; i++)
        {
           _elements[i] = elements[i];
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
        set
        {
            if(i==j)
            {
                _elements[i] = value;
            }
        }
    }

    public int Track()
    {
        var sum = 0;
        for(var i = 0; i < Size; i++)
        {
            sum += _elements[i];
        }
        return sum;
    }

    public override bool Equals(object obj)
    {
        if ((obj == null) || this is not Matrix || obj is not Matrix)
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
        var str = "";
        for (var i = 0; i < Size; i++)
        {
            str += _elements[i].ToString();
        }
        return str.GetHashCode();
    }

    public override string ToString()
    {
        string str = "";
            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    if (i != j)
                    {
                        str += $"{0,5:D}";
                }
                    else
                    {
                        str += $"{_elements[i],5:D}";
                    }
                }
                str += "\n";
            }
        
        return str;
    }

}
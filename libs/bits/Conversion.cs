namespace bits;

public class Conversion
{
    public int ToNumber(String bit)
    {
        int agg = 0;
        int len = bit.Length;
        for (int i = len; i > 0; i--)
        {
             agg+= (int) Math.Pow(2, i-1) * int.Parse(bit[len-i].ToString()); 
        }
        return agg;
    }

    public int ToUNumber(String bit)
    {
        int agg = 0;
        int len = bit.Length;

        if(bit[0]=='1')
            agg += -1 * (int) Math.Pow(2, len-1);

        for (int i = len-1; i > 0; i--)
        {
            agg+= (int) Math.Pow(2, i-1) * int.Parse(bit[len-i].ToString()); 
        }
        return agg;
    }
}

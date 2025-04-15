namespace App;

public static class Rectangles
{
    
    public static void setRightCoordinates(ref int x1,ref int y1,ref int x2,ref int y2)
    {
        if (x1 > x2)
        {
            x1 += x2;
            x2 = x1 - x2;
            x1 -= x2;
        }

        if (y1 > y2)
        {
            y1 += y2;
            y2 = y1 - y2;
            y1 -= y2;
        }
    }
    public static bool IsIntersected(
        // первый прямоугольник
        int x1, int y1, int x2, int y2,
        // второй прямоугольник
        int x3, int y3, int x4, int y4)
    {
        bool isIntersected;
        setRightCoordinates(ref x1,ref y1,ref x2,ref y2);
        setRightCoordinates(ref x3,ref y3,ref x4,ref y4);
        
        bool noIntersection = x2 < x3 || x4 < x1 || y2 < y3 || y4 < y1;
        
        return !noIntersection;
    }
    
    public static bool IsNested(
        // первый прямоугольник
        int x1, int y1, int x2, int y2,
        // второй прямоугольник
        int x3, int y3, int x4, int y4)
    {
        setRightCoordinates(ref x1,ref y1,ref x2,ref y2);
        setRightCoordinates(ref x3, ref y3, ref x4,ref y4);
         
        bool first_temp = x1 >= x3 && y1 >= y3 && x2 <= x4 && y2 <= y4;
        bool second_temp = x3 >= x1 && y3 >= y1 && x4 <= x2 && y4 <= y2;
        return first_temp || second_temp;
    }
}
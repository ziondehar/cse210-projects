using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shapes
{
   private Double _side;

   public class Square (Double side)
   {
        _side = side;
   }

}
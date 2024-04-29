using System;


class RoomArea {

    public static void Main() {

        Console.WriteLine("Welcome to The Calculator App");

        Console.WriteLine("What is the Length of your room in feet?");

        decimal Length = decimal.Parse(Console.ReadLine());

        Console.WriteLine("What is the width of your room in feet ?");

        decimal Width = decimal.Parse(Console.ReadLine());

        decimal Area = Length * Width;

        decimal perimeter = (Length *2 ) + (Width *2);
        //string sperimeter = int.Parse(perimeter);
       

        if (Area < 250) {Console.Write("You have a small sized room." + " The perimeter is "+ perimeter +"ft." + " The area is " +  Area + " square ft.");}
        else if (Area >= 250 && Area < 650) { Console.WriteLine("You have a medium sized room." + " The perimeter is " + perimeter + "ft." + " The area is " + Area + " square ft."); }
        else if (Area >= 650) { Console.WriteLine("You have a large sized room" + " The perimeter is " + perimeter + "ft." + " The area is " + Area + " square ft.");}


    }

}
//Console.WriteLine("You have a " + Console.WriteLine(RoomSize) + " room!");
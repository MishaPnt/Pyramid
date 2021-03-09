using pyramid;
using System;

namespace многокутник
{        /* 19. Створити клас: правильний многокутник. Об’єкт визначається через 5 цілих чисел X1,Y1, R, N.
Тут O(X1,Y1) – центр описаного кола, R – радіус описаного кола, N – кількість сторін, A(X1-R, Y1) – координати першої вершини. Створити конструктори й деструктор.

Перевизначити оператори:
“==” , “!=”– порівняння двох об’єктів;
“<<”– друк інформації про об’єкт.
Визначити функції:
знаходження площі й периметра об’єкта;
знаходження радіуса вписаного кола;
знаходження кута при вершині;   
графічного зображення об’єкта на екрані;
зсуву зображення на 20 пікселів уліво.*/

  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tВведіть значення для першої піраміди");
            Console.WriteLine("Введiть x1");
             int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть радіус");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть кількість сторін");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть х2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть y2");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\tВведіть вершину");
            int height = int.Parse(Console.ReadLine());
            Polygon regularPolygon = new Polygon(x1,y1,r,n);
            Polygon polygon = new Polygon(x1,y1,r,n);
            Polygon polygon1 = new Polygon(x1,y1,r,n);  
            Pyramid pyramid = new Pyramid(x1, y1, x2,y2,height,r,n);
            Console.WriteLine("Введiть значення для другої пiрамiди");
            Console.WriteLine("Введiть x1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть радiус");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть сторiн");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть х2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть вершину");
            height = int.Parse(Console.ReadLine());
            Pyramid pyramid1 = new Pyramid(x1, y1, x2,y2,height,r,n);
            Console.WriteLine("Периметр: " + regularPolygon.Perimeter());
            Console.WriteLine("Площа: " + regularPolygon.Area());
            Console.WriteLine("Площа: " + regularPolygon.Area());
            Console.WriteLine("Вершина кута: " + regularPolygon.GetAngleOfPolygon());
            Console.WriteLine("Радiус вписаного кола: " + regularPolygon.RadiusInscribedCircle());
            Console.WriteLine("бiчна сторона: "+pyramid.GetLateralArea());
            Console.WriteLine("об'єм пiрамiди: "+pyramid.GetVolumePyramid());
            Console.WriteLine( polygon == polygon1);
            Console.WriteLine(pyramid >= pyramid1); 
            Console.Write("кiлькiсть викликаних об'єктiв: ");
            Polygon.GetCountOfCreatedObjects();
        }   
    }
}

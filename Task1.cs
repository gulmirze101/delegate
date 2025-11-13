/*int[] ints = { 4, -2, 7, 4 };


int max = ints.Max();
int min = ints.Min();

Console.WriteLine($"max: {max}, min: {min}");
*/ // 1

/*int[] ints = { 0, 1, 2, 3,9,1,0,5 };

for(int i = 0; i < ints.Length/2; i++)
{
    int temp = ints[i];
    ints[i] = ints[ints.Length-1-i];
    ints[ints.Length-1-i] = temp;
}

foreach(int num in ints)
{
    Console.WriteLine(num);
}*/ //2 

/*List<int> ints = new List<int> { 1, 2, 3, 12, 5, 6, 7, 8 };

List<int> evens = ints.Where(i=>i % 2 == 0).ToList();

foreach(int num in evens)
{
    Console.WriteLine(num);
}

*/ //3


/*bool IsWorkday(Weekday weekday)
{
    return weekday <= Weekday.Friday&&weekday>=Weekday.Monday;
}

Weekday day = Weekday.Friday;
Weekday day1 = Weekday.Saturday;

Console.WriteLine(IsWorkday(day));
Console.WriteLine(IsWorkday(day1));
enum Weekday { 
    Monday=1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
      
}*/ //4


/*Point p = new Point(3, 4); 

Console.WriteLine(p.length());
struct Point {      
    double X; 
    double Y; 

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double length()
    {
        return Math.Sqrt(X*X+ Y*Y);
    }

};*/ // 5

/*ConsoleGreeter consoleGreeter = new ConsoleGreeter();

Console.WriteLine(consoleGreeter.Greet("Ramzi muellim"));
interface IGreeter
{
    string Greet(string name);
}

class ConsoleGreeter:IGreeter
{


    public string Greet(string name)
    {
        return $"Hello {name}";
    }

}*/ // 6

/*string[] s = { "A", "", "B" };

Console.WriteLine(Array.Exists(s, x=>string.IsNullOrEmpty(x)));*/ //7

/*List<int> ints = new List<int> { 1, 2, 3,5,5,5,5,2,3,1,0 };

HashSet<int> ints1 = ints.ToHashSet();

ints = ints1.ToList();
foreach(int i in ints)
{
    Console.WriteLine(i);
}*/ // 8

/*List<int> ints = new List<int> { 1, 2, 3, 5, 5, 5, 5, 2, 3, 1, 0 };

int hedef = 5;
for (int i = 0;i < ints.Count();i++)
{
    if (ints[i] == hedef)
    {
        Console.WriteLine(i);
    }
}*/ //9


/*string s = "salam  DUNya salam";
 
s = char.ToUpper(s[0]) + s.Substring(1);
for(int i = 0;i < s.Length-1; i++)
{
    if(s[i] == ' ')
    {
         s = s.Substring(0,i+1)+char.ToUpper(s[i+1]) + s.Substring(i+2).ToLower();
    }
    
}
Console.WriteLine(s);*/ //10

/*if (Advance(OrderStatus.Created, OrderAction.Pay, out OrderStatus next))
    Console.WriteLine(next); 
else
    Console.WriteLine("Invalid transition");

if (Advance(OrderStatus.Created, OrderAction.Ship, out next))
    Console.WriteLine(next);
else
    Console.WriteLine("Invalid transition");




static bool Advance(OrderStatus current, OrderAction action, out OrderStatus nextStatus)
{
    nextStatus = current; 

    switch (current)
    {
        case OrderStatus.Created:
            if (action == OrderAction.Pay)
            {
                nextStatus = OrderStatus.Paid;
                return true;
            }
            else if (action == OrderAction.Cancel)
            {
                nextStatus = OrderStatus.Cancelled;
                return true;
            }
            break;

        case OrderStatus.Paid:
            if (action == OrderAction.Ship)
            {
                nextStatus = OrderStatus.Shipped;
                return true;
            }
            else if (action == OrderAction.Cancel)
            {
                nextStatus = OrderStatus.Cancelled;
                return true;
            }
            break;

        case OrderStatus.Shipped:
            if (action == OrderAction.Deliver)
            {
                nextStatus = OrderStatus.Delivered;
                return true;
            }
            break;

        case OrderStatus.Delivered:
        case OrderStatus.Cancelled:
           
            break;
    }

    return false; 
enum OrderStatus
{
    Created,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}

enum OrderAction
{
    Pay,
    Ship,
    Deliver,
    Cancel
}
*/ //11

/*var p1 = new Point2d(1, 1);
var p2 = p1.Move(2,3);

Console.WriteLine(p1);
Console.WriteLine(p2);
readonly struct Point2d
{
    public double X { get; }
    public double Y { get; }


    public Point2d(double x, double y)
    {
        X = x; 
        Y = y;
    }
    public Point2d Move(double dx, double dy)
    {
        return new Point2d(X + dx, Y + dy);
    }

    public override string ToString()
    {
        return $"{X},{Y}";
        ;
    }
}*///12




/*List<IShape> shapes = new List<IShape>() {new Circle(5),new Circle(10), new Rectangle(4,5) };
double areaSum = 0;
double PmSum = 0;
foreach(IShape shape in shapes)
{
    areaSum += shape.Area();
    PmSum += shape.Perimeter();
}
Console.WriteLine(areaSum);
Console.WriteLine(PmSum);
interface IShape {
    double Area();
    double Perimeter();
}

class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI*Radius*Radius;
    }
    public double Perimeter()
    {
        return 2*Math.PI * Radius;
    }

}

class Rectangle : IShape
{
    public double Length;
    public double Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public double Area()
    {
        return Width*Length;
    }
    public double Perimeter()
    {
        return 2 * (Width + Length);
    }
}*/ //13

/*Console.WriteLine(ParseOrderStatus("paid")); 
Console.WriteLine(ParseOrderStatus("foo"));  
Console.WriteLine(ParseOrderStatus("SHIPPED")); 


static OrderStatus? ParseOrderStatus(string input)
{
    if (Enum.TryParse<OrderStatus>(input, ignoreCase: true, out var status))
    {
        return status;
    }
    return null;
}

enum OrderStatus
{
    Created,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}*///14

/*List<Product> products = new List<Product> {new Product(1,"Snickers",1.5m), new Product(2,"Tutku",0.6m), new Product(3,"YEMEK",1000.0m)};

decimal max = products.Max(p=>p.Price);

foreach(Product product in products)
{
    if(product.Price == max)
    {
        Console.WriteLine(product.Name);
    }
}



public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}*///15

/*var ordersByStatus = new Dictionary<OrderStatus, List<Order>>
        {
            { OrderStatus.Created, new List<Order> { new Order(1, "A"), new Order(2, "B") } },
            { OrderStatus.Paid,    new List<Order> { new Order(3, "C"), new Order(4, "D") } },
            { OrderStatus.Shipped, new List<Order> { new Order(5, "E") } }
        };

MovePaidToShipped(ordersByStatus);


foreach (var kvp in ordersByStatus)
{
    Console.WriteLine($"{kvp.Key} ({kvp.Value.Count}): {string.Join(", ", kvp.Value.ConvertAll(o => o.Name))}");
}




static void MovePaidToShipped(Dictionary<OrderStatus, List<Order>> dict)
{
    if (!dict.ContainsKey(OrderStatus.Paid)) return;

    if (!dict.ContainsKey(OrderStatus.Shipped))
        dict[OrderStatus.Shipped] = new List<Order>();

    List<Order> paidOrders = dict[OrderStatus.Paid];

  
    dict[OrderStatus.Shipped].AddRange(paidOrders);

    dict[OrderStatus.Paid].Clear();
}
class Order
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Order(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
enum OrderStatus
{
    Created,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}*/ //16

/*List<string> strings = new List<string> {"aaaa","aaa","aaaaaaa","bbbb","aaa","acca","AZaaa" };
HashSet<string> stringss = strings.ToHashSet();

strings = stringss.ToList();

strings = strings.Where(x => (x.Length >= 4 && char.ToUpper(x[0])=='A')).ToList();
strings = (strings.OrderBy(x => x).ToList()).Select(x=>x.ToUpper()).ToList();

foreach(string s in strings)
{
    Console.WriteLine(s);
}*///17




/*List<Student> students = new List<Student>
        {
            new Student("Eli", new List<double> { 70, 80, 90 }),
            new Student("Leyla", new List<double> { 50, 60, 55 }),
            new Student("Kamran", new List<double> { 65, 75, 85 }),
            new Student("Nigar", new List<double> { 40, 50, 55 })
        };

foreach (var student in students)
{
    if (student.Average() > 60)
    {
        Console.WriteLine($"{student.Name} - Ortalama: {student.Average():F2}");
    }
}
public class Student{
    public string Name;
    public List<double> Grades;

    public Student(string name, List<double>grades )
    {
        Name = name;
        Grades = grades;
    }
    public double Average()
    {
        return Grades.Average();
    }
}*///18


/*List<Product> products = new List<Product> { new Product(1, "Snickers", 1.5m), new Product(2, "Tutku", 0.6m), new Product(3, "YEMEK", 1000.0m) };

string name = "Snickers";

foreach(Product product in products)
{
    if(product.Name == name)
    {
        Console.WriteLine(product.Price);
        break;
    }
}







public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}*///19



      
        /*string[] days = {
            "Bazar ertəsi",
            "Çərşənbə axşamı",
            "Çərşənbə",
            "Cümə axşamı",
            "Cümə",
            "Şənbə",
            "Bazar"
        };

        double[] temps = new double[7];


        for (int i = 0; i < days.Length; i++)
        {
            Console.Write($"{days[i]} üçün temperaturu daxil edin: ");
            temps[i] = double.Parse(Console.ReadLine());
        }

        double avg = temps.Average();

      
        double maxTemp = temps.Max();
        double minTemp = temps.Min();

        int hottestDayIndex = Array.IndexOf(temps, maxTemp);
        int coldestDayIndex = Array.IndexOf(temps, minTemp);

      
        Console.WriteLine("\n--- Nəticələr ---");
        Console.WriteLine($"Orta temperatur: {avg:F1}°C");
        Console.WriteLine($"Ən isti gün: {days[hottestDayIndex]}, {maxTemp}°C");
        Console.WriteLine($"Ən soyuq gün: {days[coldestDayIndex]}, {minTemp}°C");
    */ //20
public class Program
{
    private static void Main(string[] args)
    {
        // Bước 1: Thông báo về chức năng của chương trình
        Console.WriteLine("Linear Equation Resolver");
        Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

        // Bước 2: Nhận giá trị của các hệ số
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Bước 3: Tìm nghiệm của phương trình khi a != 0
        if (a != 0)
        {
            double solution = -b / a;
            Console.Write("The solution is: {0}!", solution);
        }
        // Bước 4: Tìm nghiệm của phương trình khi a == 0
        else
        {
            if (b == 0)
            {
                Console.Write("The solution is all x!");
            }
            else
            {
                Console.Write("No solution!");
            }
        }
    }
}
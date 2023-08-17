
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество этажей небоскреба: ");
        int N = Convert.ToInt32(Console.ReadLine());// кол-во этажей

        Console.Write("Введите количество этажей, после которых будет повышена стоимость квартиры: ");
        int M = Convert.ToInt32(Console.ReadLine());// кол-во этажей с одной стоимостью

        Console.Write("Введите стоимость квартиры на первом этаже: ");
        int X = Convert.ToInt32(Console.ReadLine());// стоимость квартиры в первой группе

        int numOfGroup = N / M;// кол-во групп этажей с одной стоимостью

        int smallGroup = 0; // последняя группа этажей (с неполным количеством)

        if (N % M > 0)
        {
            smallGroup = N % M;

            ++numOfGroup;
        }
        int increase = 1000;// сумма повышения стоимости в след. группе

        int groupPrice;//Общая стоимость внутри группы

        int total = 0;//Общая стоимость всех этажей

        for (int i = 0; i < numOfGroup; i++)
        {
            if (i == numOfGroup - 1 && smallGroup > 0)
            {

                groupPrice = X * smallGroup;

                total += groupPrice;

                break;

            }
            groupPrice = X * M;

            total += groupPrice;

            X += increase;
        }
        Console.WriteLine($"Общая стоимость всех квартир в небоскрёбе: {total}$");
    }
}
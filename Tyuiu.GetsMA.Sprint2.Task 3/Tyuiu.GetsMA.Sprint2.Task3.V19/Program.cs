using Tyuiu.GetsMA.Sprint2.Task3.V19.Lib;

ChessService cs = new ChessService();

Console.Write("Введите x1 (1-8): ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1 (1-8): ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2 (1-8): ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2 (1-8): ");
int y2 = Convert.ToInt32(Console.ReadLine());

bool canMove = cs.CanBishopMove(x1, y1, x2, y2);
Console.WriteLine(canMove);

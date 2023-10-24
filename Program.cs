Console.WriteLine("Raqamlar sonini kiriting:");
int raqamlar_soni = Convert.ToInt32(Console.ReadLine());
double summa = 0;
 Console.WriteLine("Sonlarni kiriting:");
for (int birinchi_son = 0;birinchi_son < raqamlar_soni;birinchi_son++){
    Console.Write(">> ");
    summa += Convert.ToSingle(Console.ReadLine());
}
Console.WriteLine("Kiritilgan raqamlar o'rta arifmetigi " + summa/raqamlar_soni);
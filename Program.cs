int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Nma Siswa: ");
nama = Console.ReadLine();


Console.Write("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Selamat Anda Lulus!");
}
else
{
    Console.WriteLine("Maaf, Anda Belum Lulus");
}
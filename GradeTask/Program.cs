//Programm kysib mis hinde kasutaja sai
//Kui kasutaja sai "A", konsool kuvab "Suureparane!"
//Kui kasutaja sai "B", konsool kuvab "Vaga hea!"
//Kui kasutaja sai "C", konsool kuvab "Hea!"
//Kui kasutaja sai "D", konsool kuvab "Rahuldav!"
//Kui kasutaja sai "E", konsool kuvab "Kasin!"
//Kui kasutaja sai "F", konsool kuvab "Puudulik!"
//Kui kasutaja sai midagi muud, konsool kuvab "Vale v22rtus!"
//Kasuta IF loogikat

Console.WriteLine("Sisesta palun oma hinne:");
string userGrade = Console.ReadLine().ToUpper();

if (userGrade == "A")
{
    Console.WriteLine("Suureparane!");
}
else if (userGrade == "B")
{
    Console.WriteLine("Vaga hea!");
}
else if (userGrade == "C")
{
    Console.WriteLine("Hea!");
}
else if (userGrade == "D")
{
    Console.WriteLine("Rahuldav!");
}
else if (userGrade == "E")
{
    Console.WriteLine("Kasin!");
}
else if (userGrade == "F")
{
    Console.WriteLine("Puudulik! 6pi veel");
}
else
{
    Console.WriteLine("Vale v22rtus!");
}

Console.WriteLine("Olgu sinu p2ev sellegi poolest vinge!");
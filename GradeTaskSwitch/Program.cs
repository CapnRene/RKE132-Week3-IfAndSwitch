//Programm kysib mis hinde kasutaja sai
//Kui kasutaja sai "A", konsool kuvab "Suureparane!"
//Kui kasutaja sai "B", konsool kuvab "Vaga hea!"
//Kui kasutaja sai "C", konsool kuvab "Hea!"
//Kui kasutaja sai "D", konsool kuvab "Rahuldav!"
//Kui kasutaja sai "E", konsool kuvab "Kasin!"
//Kui kasutaja sai "F", konsool kuvab "Puudulik!"
//Kui kasutaja sai midagi muud, konsool kuvab "Vale v22rtus!"
//Kasuta SWITCH loogikat

Console.WriteLine("Sisesta palun oma hinne:");
string userGrade = Console.ReadLine().ToUpper();

switch(userGrade)
{
    case "A":
        Console.WriteLine("Suureparane!");
        break;
    case "B":
        Console.WriteLine("Vaga hea!");
        break;
    case "C":
        Console.WriteLine("Hea!");
        break;
    case "D":
        Console.WriteLine("Rahuldav!");
        break;
    case "E":
        Console.WriteLine("Kasin!");
        break;
    case "F":
        Console.WriteLine("Puudulik! 6pi veel!");
        break;
    default:
        Console.WriteLine("Vale v22rtus!");
        break;
}

Console.WriteLine("Oled parim!");
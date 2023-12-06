using System.Windows.Forms;
using Microsoft.VisualBasic;

using static System.Console;

namespace _1_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Известна стоимость монитора, системного блока, клавиатуры и мыши.");
            WriteLine("Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?");
            WriteLine("В случае если, введеные данные будут <0, то будет ДСТ");
            ReadLine();
            uint monitorCost = uint.Parse(Interaction.InputBox("Напишите стоимость монитора?", "Элементы компьютера"));
            uint systemUnitCost = uint.Parse(Interaction.InputBox("Напишите стоимость системного блока?", "Элементы компьютера"));
            uint keyboardCost = uint.Parse(Interaction.InputBox("Напишите стоимость клавиатуры?", "Элементы компьютера"));
            uint mouseCost = uint.Parse(Interaction.InputBox("Стоимость мыши?", "Элементы компьютера"));
            uint computerCount = uint.Parse(Interaction.InputBox("Сколько компьютеров купить?", "Кол-во компьютеров"));
            MessageBox.Show($"3 компьютера будут стоить {(monitorCost + systemUnitCost + keyboardCost + mouseCost) * 3} ; {computerCount} компьютеров будут стоить {(monitorCost + systemUnitCost + keyboardCost + mouseCost) * computerCount}", "Стоимость компьютеров");


        }
    }
}

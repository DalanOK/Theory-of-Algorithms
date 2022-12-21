using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace TuringMashine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            char[] alphabet = { 'a', 'b', '0', '1','2','3','4','5','6','7','8'};
            char[] alp = {'0',','};
            Machine machine = new Machine(0, line, alp);
            char[,] instruction2 = {
                { 'A', '0', '0','R','A' },
                { 'B', '0', '0','R','A' },
                { 'A', ' ', ',','R','B' },
                { 'B', ' ', ' ','L','C' },
                { 'C', ',', ' ','S','#' },
            };
            char[,] instruction = { 
                { 'A', 'a', 'a','R','1' },
                { '1', 'a', 'a','R','2' },
                { '2', 'a', 'a','R','3' },
                { '3', 'a', 'a','R','4' },
                { '4', 'a', 'a','R','5' },
                { '5', 'a', 'a','R','6' },
                { '6', 'a', 'a','R','7' },
                { '7', 'a', 'a','R','8' },
                { 'A', ' ', ' ','S','#' },
                { '1', ' ', '1','S','#' },
                { '2', ' ', '2','S','#' },
                { '3', ' ', '3','S','#' },
                { '4', ' ', '4','S','#' },
                { '5', ' ', '5','S','#' },
                { '6', ' ', '6','S','#' },
                { '7', ' ', '7','S','#' },
                { '8', ' ', '8','S','#' },
                { 'A', 'b', 'b','R','A' },
                { '1', 'b', 'b','R','1' },
                { '2', 'b', 'b','R','2' },
                { '3', 'b', 'b','R','3' },
                { '4', 'b', 'b','R','4' },
                { '5', 'b', 'b','R','5' },
                { '6', 'b', 'b','R','6' },
                { '7', 'b', 'b','R','7' },
                { 'A', '1', '1','R','A' },
                { '1', '1', '1','R','1' },
                { '2', '1', '1','R','2' },
                { '3', '1', '1','R','3' },
                { '4', '1', '1','R','4' },
                { '5', '1', '1','R','5' },
                { '6', '1', '1','R','6' },
                { '7', '1', '1','R','7' },
                { 'A', '2', '2','R','A' },
                { '1', '2', '2','R','1' },
                { '2', '2', '2','R','2' },
                { '3', '2', '2','R','3' },
                { '4', '2', '2','R','4' },
                { '5', '2', '2','R','5' },
                { '6', '2', '2','R','6' },
                { '7', '2', '2','R','7' },
                { 'A', '3', '3','R','A' },
                { '1', '3', '3','R','1' },
                { '2', '3', '3','R','2' },
                { '3', '3', '3','R','3' },
                { '4', '3', '3','R','4' },
                { '5', '3', '3','R','5' },
                { '6', '3', '3','R','6' },
                { '7', '3', '3','R','7' },
                { 'A', '4', '4','R','A' },
                { '1', '4', '4','R','1' },
                { '2', '4', '4','R','2' },
                { '3', '4', '4','R','3' },
                { '4', '4', '4','R','4' },
                { '5', '4', '4','R','5' },
                { '6', '4', '4','R','6' },
                { '7', '4', '4','R','7' },
                { 'A', '5', '5','R','A' },
                { '1', '5', '5','R','1' },
                { '2', '5', '5','R','2' },
                { '3', '5', '5','R','3' },
                { '4', '5', '5','R','4' },
                { '5', '5', '5','R','5' },
                { '6', '5', '5','R','6' },
                { '7', '5', '5','R','7' },
                { 'A', '6', '6','R','A' },
                { '1', '6', '6','R','1' },
                { '2', '6', '6','R','2' },
                { '3', '6', '6','R','3' },
                { '4', '6', '6','R','4' },
                { '5', '6', '6','R','5' },
                { '6', '6', '6','R','6' },
                { '7', '6', '6','R','7' },
                { 'A', '7', '7','R','A' },
                { '1', '7', '7','R','1' },
                { '2', '7', '7','R','2' },
                { '3', '7', '7','R','3' },
                { '4', '7', '7','R','4' },
                { '5', '7', '7','R','5' },
                { '6', '7', '7','R','6' },
                { '7', '7', '7','R','7' },
                { 'A', '8', '8','R','A' },
                { '1', '8', '8','R','1' },
                { '2', '8', '8','R','2' },
                { '3', '8', '8','R','3' },
                { '4', '8', '8','R','4' },
                { '5', '8', '8','R','5' },
                { '6', '8', '8','R','6' },
                { '7', '8', '8','R','7' },
                { 'A', '0', '0','R','A' },
                { '1', '0', '0','R','1' },
                { '2', '0', '0','R','2' },
                { '3', '0', '0','R','3' },
                { '4', '0', '0','R','4' },
                { '5', '0', '0','R','5' },
                { '6', '0', '0','R','6' },
                { '7', '0', '0','R','7' },

            };
            machine.ReadInstruction(instruction2);
            machine.PrintTape();
        }
    }
    public class Tape
    {
        public List<char> tapeLine = new List<char>();
        public int head;
        private char[] alphabet;
        public bool tapeLineDataCorect = true;
        public Tape(int head, char[] alphabet)
        {
            this.head = head;
            this.alphabet = alphabet;
        }

        public void AddItemsOnTape(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                bool canBeAddOnTape = ItemCanBeAddedCheker(line[i]);
                if (!canBeAddOnTape)
                {
                    break;
                }
                else
                {
                    this.tapeLine.Add(line[i]);
                }
            }
        }
        public bool ItemCanBeAddedCheker(char item)
        {
            for (int j = 0; j < this.alphabet.Length; j++)
            {
                if (item == this.alphabet[j] || item == ' ')
                {
                    return true;
                }
            }
            Console.WriteLine("Wrong symbol");
            tapeLineDataCorect = false;
            return tapeLineDataCorect;
        }
        public int MoveLeft()
        {
            return head--;
        }
        public int MoveRight()
        {
            head++;
            if(head+1 > tapeLine.Count)
            {
                this.tapeLine.Add(' ');
            } 
            return head;
        }
        public int Stay()
        {
            return head;
        }
    }
    public class Machine
    {
        public Tape tape;
        public char state = 'A';
        char[] alphabet; 
        public Machine(int headPositon,string line, char[] alphabet)
        {
            tape = new Tape(headPositon,alphabet);
            this.alphabet = alphabet;
            tape.AddItemsOnTape(line);
        }
        public void PrintTape()
        {
            if (tape.tapeLineDataCorect)
            {
                for (int i = 0; i < tape.tapeLine.Count; i++)
                {
                    Console.Write(tape.tapeLine[i] + " ");
                }
            }
        }
        public void ReadInstruction(char[,] instruction)
        {
            if (tape.tapeLineDataCorect)
            {
                for (int i = 0; state != '#'; i++)
                {
                    if (instruction[i, 0] == state && instruction[i, 1] == tape.tapeLine[tape.head])
                    {
                        if (tape.ItemCanBeAddedCheker(instruction[i, 2]))
                        {
                            tape.tapeLine[tape.head] = instruction[i, 2];
                        }
                        else
                        {
                            break;
                        }
                        if (instruction[i, 3] == 'R')
                        {
                            tape.MoveRight();
                        }
                        else if (instruction[i, 3] == 'L')
                        {
                            tape.MoveLeft();
                        }
                        else if (instruction[i, 3] == 'S')
                        {
                            tape.Stay();
                        }
                        state = instruction[i, 4];
                        i = -1;
                    }
                }
            }
        }
    }
}
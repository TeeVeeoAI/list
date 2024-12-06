using System.Collections.Generic;

List<List<char>> l = new List<List<char>>();

List<char> c1 = new List<char>();
List<char> c2 = new List<char>();
List<char> c3 = new List<char>();
List<char> c4 = new List<char>();

c1.Add('t');
c1.Add('h');
c2.Add('5');
c3.Add('r');
c4.Add('g');

l.Add(c1);
l.Add(c2);
l.Add(c3);
l.Add(c4);

int i = 1;

foreach (List<char> cl in l) {
    Console.WriteLine("Char list " + i);
    foreach (char C in cl) {
        if (cl.IndexOf(C) == cl.Count - 1)
            Console.WriteLine(C);
        else
            Console.Write(C + ", ");
    }
    i++;
}
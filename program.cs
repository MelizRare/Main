string[] input_mass =new string[] {"hello", "2", "world", ":-)"};
string[] rez_mass= new string[] {" "};
for (int i= 0; i<input_mass.Length;i++)
    {
        if((int)input_mass[i].Length<= 3)
        {
            rez_mass.Append(input_mass[i]).ToArray();
        }
    }
for (int z= 0; z<rez_mass.Length;z++)
    {
        Console.Write("2 "+rez_mass[z]+" ");
    }
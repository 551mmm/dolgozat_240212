using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_240212
{
    public class Author
    {
        public string Keresztnev { get; }
        public string Vezeteknev { get; }
        public Guid Id { get; }

        public Author(string teljesnev)
        {
            var names = teljesnev.Split(' ');
            if (names.Length != 2 || names[0].Length < 3 || names[1].Length < 3 || names[0].Length > 32 || names[1].Length > 32)
                throw new ArgumentException("fffffffffff");

            Keresztnev= names[0];
            Vezeteknev= names[1];
            Id = Guid.NewGuid();
        }
    }
}
